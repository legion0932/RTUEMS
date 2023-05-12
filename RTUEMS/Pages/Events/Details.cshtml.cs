using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RTUEMS.Data;
using RTUEMS.Models;

namespace RTUEMS.Pages.Events
{
    public class DetailsModel : PageModel
    {
        private readonly RTUEMS.Data.EventContext _context;

        public DetailsModel(RTUEMS.Data.EventContext context)
        {
            _context = context;
        }

        public Event Event { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Event.FirstOrDefaultAsync(m => m.Id == id);

            if (Event == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
