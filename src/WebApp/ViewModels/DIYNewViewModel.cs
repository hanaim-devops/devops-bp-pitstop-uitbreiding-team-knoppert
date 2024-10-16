namespace Pitstop.WebApp.ViewModels;

public class DIYNewViewModel
{
    public DIYAvond DIYNAvond{ get; set; }
    public IEnumerable<SelectListItem> Reparateurs { get; set; }
    [Required(ErrorMessage = "Reparateurs is required")]
    public string SelectedReparateursId { get; set; }
}