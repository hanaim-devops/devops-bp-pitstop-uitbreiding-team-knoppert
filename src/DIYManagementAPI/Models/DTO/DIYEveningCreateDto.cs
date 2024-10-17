using System.ComponentModel.DataAnnotations;

namespace DIYManagementAPI.Models.DTO
{
    public class DIYEveningCreateDto
    {
        [Required]
        public string Title { get; set; }

        public string ExtraInfo { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public string Mechanic { get; set; }

    }
}
