using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoAPI1.Models;

namespace ToDoAPI1.Data
{
    public class ToDoAPI1Context : DbContext
    {
        public ToDoAPI1Context (DbContextOptions<ToDoAPI1Context> options)
            : base(options)
        {
        }

        public DbSet<ToDoAPI1.Models.ToDoItem> ToDoItem { get; set; } = default!;
    }
}
