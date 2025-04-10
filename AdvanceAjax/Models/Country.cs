﻿using System.ComponentModel.DataAnnotations;

namespace AdvanceAjax.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(3)]
        public string Code { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string CurrencyName { get; set; }
    }
}
