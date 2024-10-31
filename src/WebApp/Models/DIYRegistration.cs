namespace Pitstop.WebApp.Models
{
    public class DIYRegistration
    {
        public int Id { get; set; }

        public int DIYEveningId { get; set; }

        [Required]
        [Display(Name = "Customer name")]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Reparations")]
        public string Reparations { get; set; }
    }
}
