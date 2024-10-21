using System.ComponentModel.DataAnnotations;

namespace DIYManagementAPI.Models
{
    public class DIYRegistration
    {
        [Key]
        public int Id {  get; set; } 

        public int DIYEveningID {  get; set; } 

        public string? CustomerName { get; set; }

        public string? Reparations {  get; set; }
    }
}
