﻿using System.ComponentModel.DataAnnotations;

namespace WebCarRentalSystem.ViewModels.Contract
{
    public class EditContractViewModel
    {
        public DateTime? DateContract { get; set; }
        public DateTime? DateEnd { get; set; }
        [Required]
        public int ClientID { get; set; }
        [Required]
        public int CarId { get; set; }
        public decimal? ContractDays { get; set; }
        public decimal? Price { get; set; }
    }
}