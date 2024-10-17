using System.ComponentModel.DataAnnotations;

namespace DIYManagementAPI.Models
{
    public class DIYEveningModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string ExtraInfo { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public string Mechanic { get; set; }

    }
}
