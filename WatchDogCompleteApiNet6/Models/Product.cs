﻿using System.ComponentModel.DataAnnotations;

namespace WatchDogCompleteApiNet6.Models {
    public class Product {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        public bool IsOnSale { get; set; }
    }
}
