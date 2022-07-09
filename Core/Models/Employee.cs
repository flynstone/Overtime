﻿using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Employee : BaseEntity
    {
        [Required]
        public int EmployeeId { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        public int CrewId { get; set; }
        public Crew Crew { get; set; }

        public int JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }

        public int RuleTypeId { get; set; }
        public RuleType RuleType { get; set; }
    }
}