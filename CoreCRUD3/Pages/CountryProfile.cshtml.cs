using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoreCRUD3.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreCRUD3.Pages
{
    public class CountryProfileModel : PageModel
    {
        private readonly CoreCRUD3Context _context;
        public CountryProfileModel(CoreCRUD3Context context)
        {
            _context = context;
        }
       public List<Destination> Destinations { get; set; }
       public void OnGet()
        {
            
        }
     }
}



