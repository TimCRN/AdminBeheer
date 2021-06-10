// <copyright file="Service.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdminManagement.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Service
    {
        [Key]
        public int Id { get; set; }

        // Owner of the service
        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int Value { get; set; }
    }
}
