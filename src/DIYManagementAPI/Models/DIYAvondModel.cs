using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DIYManagementAPI.Models
{
    public class DIYAvondModel
    {
        [Key]
        public int Id { get; set; }

        //[Required]
        public string Title { get; set; }

        //[Required]
        public string ExtraInfo { get; set; }

        //[Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        //[Required]
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        //[Required]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        //[Required]
        [Display(Name = "EndTime")]
        public TimeSpan EndTime { get; set; }

        //public ICollection<Reparateur> Reparateurs { get; set; }
        public ICollection<Reparateur> Reparateurs { get; set; } = new List<Reparateur>();
    }
}
