﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreCRUD3.Models;

namespace CoreCRUD3.Pages.Destinations
{
    public class DetailsModel : PageModel
    {
        private readonly CoreCRUD3.Models.CoreCRUD3Context _context;

        public DetailsModel(CoreCRUD3.Models.CoreCRUD3Context context)
        {
            _context = context;
        }

        public Destination Destination { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Destination = await _context.Destination
                .Include(d => d.Country).FirstOrDefaultAsync(m => m.Id == id);

            if (Destination == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
