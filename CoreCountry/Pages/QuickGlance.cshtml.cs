using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoreCountry.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreCountry.Pages
{
    public class QuickGlanceModel : PageModel
    {
        private CoreCountryContext coreCountryContext;

        public QuickGlanceModel(CoreCountryContext coreCountryContext)
        {
            this.coreCountryContext = coreCountryContext;
        }

        public ICollection<Destination> Destinations { get; set; }

        public void OnGet()
        {
            Destinations = coreCountryContext.Destination.OrderBy(a => a.Id).Include(x => x.Country).OrderBy(m => m.Country.CName).ToList();

        }
    }
}