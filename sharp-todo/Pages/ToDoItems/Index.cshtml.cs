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
    public class IndexModel : PageModel
    {
        private readonly sharp_todo.Data.ToDoContext _context;

        public IndexModel(sharp_todo.Data.ToDoContext context)
        {
            _context = context;
        }

        public IList<ToDoItem> ToDoItem { get;set; }

        public async Task OnGetAsync()
        {
            ToDoItem = await _context.ToDoItem.ToListAsync();
        }
    }
}
