namespace Pitstop.WebApp.Models
{
    public class DIYFeedback
    {
        public int DIYEveningId { get; set; }

        [Required]
        [Display(Name = "Customer name")]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Feedback")]
        public string Feedback { get; set; }
    }
}