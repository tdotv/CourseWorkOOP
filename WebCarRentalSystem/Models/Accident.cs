﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCarRentalSystem.Models
{
    public class Accident
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Dtp Date")]
        public DateTime DateDtp { get; set; }

        public string? Collisions { get; set; }

        public decimal? Result { get; set; }

        [ForeignKey("Contract")]
        [Required(ErrorMessage = "Please Enter Contract Id")]
        public int ContractId { get; set; }
        public Contract Contract { get; set; }

        [ForeignKey("ApplicationUser")]
        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}
