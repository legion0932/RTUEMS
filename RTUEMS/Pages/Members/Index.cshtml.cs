using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RTUEMS.Data;
using RTUEMS.Models;

namespace RTUEMS.Pages.Members
{
    public class IndexModel : PageModel
    {
        private readonly RTUEMS.Data.EventContext _context;

        public IndexModel(RTUEMS.Data.EventContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; } = default!;
        public IList<Event> Event { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Member != null)
            {
                Member = await _context.Member.ToListAsync();
            }
        }
    }
}
