using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreCountry.Models;

namespace CoreCountry.Pages.Destinations
{
    public class IndexModel : PageModel
    {
        private readonly CoreCountry.Models.CoreCountryContext _context;

        public IndexModel(CoreCountry.Models.CoreCountryContext context)
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
