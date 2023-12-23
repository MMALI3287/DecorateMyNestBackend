﻿using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}