﻿namespace PitStop.WebApp.Controllers;

    public class DIYManagementController : Controller
{
    private IDIYManagementAPI _DIYManagamentAPI;
    private readonly Microsoft.Extensions.Logging.ILogger _logger;
    private ResiliencyHelper _resiliencyHelper;

    public DIYManagementController(IDIYManagementAPI DIYManagamentAPI, ILogger<WorkshopManagementController> logger)
    {
        _DIYManagamentAPI = DIYManagamentAPI;
        _logger = logger;
        _resiliencyHelper = new ResiliencyHelper(_logger);
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return await _resiliencyHelper.ExecuteResilient(async () =>
        {
            var model = new DIYManagementViewModel
            {
                DIYAvonden = await _DIYManagamentAPI.GetDIYAvonden()
            };
            
            return View(model);
        }, View("Offline", new DIYManagementOfflineViewModel()));
    }

    [HttpGet]
    public IActionResult NewRegistration(string diyAvondId)
    {
        var model = new DIYManagementNewRegistrationViewModel
        {
            DIYRegistration = new DIYRegistration
            {
                DIYAvondId = diyAvondId
            }
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> RegisterCustomer([FromForm] DIYManagementNewRegistrationViewModel inputModel)
    {
        if (ModelState.IsValid)
        {
            return await _resiliencyHelper.ExecuteResilient(async () =>
            {
                //RegisterCustomer cmd = inputModel.MapToRegisterCustomer();
                //await _customerManagementAPI.RegisterCustomer(cmd);
                //await _DIYManagamentAPI.RegisterDIYAvondCustomer(cmd);
                return RedirectToAction("Index");
            }, View("Offline", new CustomerManagementOfflineViewModel()));
        }
        else
        {
            return View("New", inputModel);
        }
    }

    public IActionResult Error()
    {
        return View();
    }
}