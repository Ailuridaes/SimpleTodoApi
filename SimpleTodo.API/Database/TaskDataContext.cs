using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SimpleTodo.API.Models;

namespace SimpleTodo.API.Database
{
    public class TaskDataContext : DbContext
    {
        public TaskDataContext() : base("TaskDatabase")
        {

        }

        public IDbSet<Task> Tasks { get; set; }
    }
}