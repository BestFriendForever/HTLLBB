﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HTLLBB.Models.ForumViewModels
{
    public class CreateViewModel
    {
        [Required]
        public int CatID { get; set; }
        [Required]
        [RegularExpression("[^/]+", ErrorMessage = "The field Name must not contain slashes")]
        public String Name { get; set; }
    }
}
