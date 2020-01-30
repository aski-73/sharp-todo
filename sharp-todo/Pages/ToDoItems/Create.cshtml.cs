using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using sharp_todo.Data;
using sharp_todo.Models;

namespace sharp_todo
{
    public class CreateModel : PageModel
    {
        private readonly sharp_todo.Data.ToDoContext _context;

        public CreateModel(sharp_todo.Data.ToDoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ToDoItem ToDoItem { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ToDoItem.Add(ToDoItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
