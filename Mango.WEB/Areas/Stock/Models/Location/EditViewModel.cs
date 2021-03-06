﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Mango.WEB.Areas.Stock.Models.Location
{
    public class EditViewModel
    {
        [Required]
        public Guid LocationUID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [MaxLength(50)]
        public string Floor { get; set; }
        public string Address { get; set; }
    }
}
