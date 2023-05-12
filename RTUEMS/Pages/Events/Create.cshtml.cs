using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RTUEMS.Data;
using RTUEMS.Models;

namespace RTUEMS.Pages.Events
{
    public class CreateModel : PageModel
    {
        private readonly RTUEMS.Data.EventContext _context;

        public CreateModel(RTUEMS.Data.EventContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Event Event { get; set; } = default!;

        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Event == null || Event == null)
            {
                return Page();
            }

            _context.Event.Add(Event);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
