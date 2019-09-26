using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCountry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreCountry.Pages
{
    public class IndexModel : PageModel
    {
        private CoreCountryContext _context;

        public IndexModel(CoreCountryContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            CountOfDestinations = _context.Destination.Count();
            CountofCountries = _context.Country.Count();

        }

        public int CountOfDestinations { get; set; }
        public int CountofCountries { get; set; }
    }
}
