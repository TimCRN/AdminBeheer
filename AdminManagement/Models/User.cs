﻿// <copyright file="User.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdminManagement.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int RoleId { get; set; }

        public Role Role { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [MaxLength(15)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
