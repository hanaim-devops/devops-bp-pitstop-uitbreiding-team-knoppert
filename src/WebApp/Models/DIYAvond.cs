namespace Pitstop.WebApp.Models
{
    public class DIYAvond
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "ExtraInfo")]
        public string ExtraInfo { get; set; }

        [Required]
        [Display(Name = "StartDate")]
        [DataType(DataType.DateTime)]
        public string StartDate { get; set; }

        [Required]
        [Display(Name = "StartTime")]
        [DataType(DataType.Time)]
        public string StartTime { get; set; }

        [Required]
        [Display(Name = "EndDate")]
        [DataType(DataType.DateTime)]
        public string EndDate { get; set; }

        [Required]
        [Display(Name = "EndTime")]
        public string EndTime { get; set; }

        public IEnumerable<Reparateur> Reparateurs { get; set; }

        [Required(ErrorMessage = "Reperateurs is required")]
        [Display(Name = "Reparateur")]
        public IEnumerable<SelectListItem> SelectedReparateurs { get; set; }

        public string Error { get; set; }
    }
}
