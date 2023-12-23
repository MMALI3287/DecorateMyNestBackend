﻿using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}