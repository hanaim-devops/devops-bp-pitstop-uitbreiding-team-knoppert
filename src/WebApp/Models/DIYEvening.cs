﻿namespace Pitstop.WebApp.Models
{
    public class DIYEvening
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "ExtraInfo")]
        public string ExtraInfo { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mmZ}", ApplyFormatInEditMode = true)] // "Z" indicates UTC time
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mmZ}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Mechanic is required")]
        [Display(Name = "Mechanic")]
        public string Mechanic { get; set; }

        public string Error { get; set; }

        public bool Cancelled { get; set; }

        public bool IsStarted { get; set; }
    }
}
