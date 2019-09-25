using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreCRUD3.Models;

namespace CoreCRUD3.Pages.Destinations
{
    public class IndexModel : PageModel
    {
        private readonly CoreCRUD3.Models.CoreCRUD3Context _context;

        public IndexModel(CoreCRUD3.Models.CoreCRUD3Context context)
        {
            _context = context;
        }

        public IList<Destination> Destination { get;set; }

        public async Task OnGetAsync()
        {
            Destination = await _context.Destination
                .Include(d => d.Country).ToListAsync();
        }
    }
}
