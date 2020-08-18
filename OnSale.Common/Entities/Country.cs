﻿using System.ComponentModel.DataAnnotations;

namespace OnSale.Common.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [MaxLength(50,ErrorMessage ="The Filed {0} must contain less than {1} characteres")]
        [Required]
        public string Name { get; set; }
    }
}
