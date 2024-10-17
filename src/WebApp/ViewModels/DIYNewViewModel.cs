namespace Pitstop.WebApp.ViewModels;

public class DIYNewViewModel
{
    public DIYAvond DIYNAvond { get; set; }
    public IEnumerable<SelectListItem> Reparateurs { get; set; }

    [Display(Name = "Reparateurs")]
    [Required(ErrorMessage = "Reparateurs is required")]
    public List<int> SelectedReparateursIds { get; set; } = new List<int>();
}