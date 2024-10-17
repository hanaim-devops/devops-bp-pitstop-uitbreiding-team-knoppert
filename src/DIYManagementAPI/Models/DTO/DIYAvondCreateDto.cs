using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DIYManagementAPI.Models.DTO
{
    public class DIYAvondCreateDto
    {
        [Required]
        public string Title { get; set; }

        public string ExtraInfo { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        public List<int> ReparateurIds { get; set; }
    }
}
