﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoListApp.Models
{
    public class Task
    {
        [Key] // Primary Key
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}