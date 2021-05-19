using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminManagement.Models
{
    public class InventoryItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        public int Value { get; set; }
    }
}
