using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleTodo.API.Models
{
    public class Task
    {
        [Required]
        public int TaskId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public Priorities Priority { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

    }
}