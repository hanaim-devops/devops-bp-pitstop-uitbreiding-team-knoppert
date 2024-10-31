﻿using System.ComponentModel.DataAnnotations;

namespace DIYManagementAPI.Models
{
    public class DIYEveningModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string ExtraInfo { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public required string Mechanic { get; set; }

        public bool Cancelled { get; set; } = false;

        public bool IsStarted => TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.Utc, TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time")) >= StartDate;
    }
}
