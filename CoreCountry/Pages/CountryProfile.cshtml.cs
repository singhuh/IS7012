using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCountry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CoreCountry.Pages
{
    public class CountryProfileModel : PageModel
    {
        private CoreCountryContext coreCrudContext;

        public CountryProfileModel(CoreCountryContext coreCrudContext)
        {
            this.coreCrudContext = coreCrudContext;
        }

        public Country Countries { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Countries = coreCrudContext.Country.Include(a => a.Destinations).Where(c => c.Id == id).OrderBy(x => x.Id).FirstOrDefault();
            if (Countries == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
