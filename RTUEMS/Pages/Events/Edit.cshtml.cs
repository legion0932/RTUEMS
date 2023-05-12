using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RTUEMS.Data;
using RTUEMS.Models;

namespace RTUEMS.Pages.Events
{
    public class EditModel : PageModel
    {
        private readonly RTUEMS.Data.EventContext _context;

        public EditModel(RTUEMS.Data.EventContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Event Event { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Event == null)
            {
                return NotFound();
            }

            var foundEvent = await _context.Event.FirstOrDefaultAsync(m => m.Id == id);
            if (foundEvent == null)
            {
                return NotFound();
            }
            Event = foundEvent;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Event).State = EntityState.Modified;

            try
            {
                int myId = id ?? default;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EventExists(int? id)
        {
            int myId = id ?? default;
            return _context.Event.Any(e => e.Id == myId);
        }

    }
}
