namespace PitStop.WebApp.Controllers;

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
    public async Task<IActionResult> New()
    {
        var reparateurs = await _DIYManagamentAPI.GetReparateursAsync();

        var model = new DIYNewViewModel
        {
            DIYNAvond = new DIYAvond(),
            Reparateurs = reparateurs.Select(r => new SelectListItem
            {
                Value = r.Id.ToString(),
                Text = r.Name
            })
        };
        return View(model);
    }


    public IActionResult Error()
    {
        return View();
    }
}