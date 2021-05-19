using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminManagement.Models
{
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
