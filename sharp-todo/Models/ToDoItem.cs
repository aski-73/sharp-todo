using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sharp_todo.Models
{
    public class ToDoItem
    {
        public long Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public bool IsComplete { get; set; }

        public String ToDo { get; set; }
    }
}
