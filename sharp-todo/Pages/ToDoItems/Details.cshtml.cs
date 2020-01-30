using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sharp_todo.Data;
using sharp_todo.Models;

namespace sharp_todo
{
    public class DetailsModel : PageModel
    {
        private readonly sharp_todo.Data.ToDoContext _context;

        public DetailsModel(sharp_todo.Data.ToDoContext context)
        {
            _context = context;
        }

        public ToDoItem ToDoItem { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ToDoItem = await _context.ToDoItem.FirstOrDefaultAsync(m => m.Id == id);

            if (ToDoItem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
