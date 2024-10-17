using System.ComponentModel.DataAnnotations;

namespace DIYManagementAPI.Models
{
    public class Reparateur
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Navigation property for the many-to-many relationship
        //public ICollection<DIYAvondModel> DIYAvonden { get; set; }
        public ICollection<DIYAvondModel> DIYAvonden { get; set; } = new List<DIYAvondModel>();
    }
}
