namespace Pitstop.WebApp.Models
{
    public class DIYCustomerHistory
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Reparations")]
        public string Reparations { get; set; }
        [Display(Name = "StartDate")]
        public DateTime StartDate { get; set; }
        [Display(Name = "EndDate")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Feedback")]
        public string Feedback { get; set; }
    }
}
