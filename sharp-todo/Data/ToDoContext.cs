using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sharp_todo.Models;

namespace sharp_todo.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext (DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }

        public DbSet<sharp_todo.Models.ToDoItem> ToDoItem { get; set; }
    }
}
