using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoreCRUD3.Models;

namespace CoreCRUD3.Pages.Destinations
{
    public class CreateModel : PageModel
    {
        private readonly CoreCRUD3.Models.CoreCRUD3Context _context;

        public CreateModel(CoreCRUD3.Models.CoreCRUD3Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CountryId"] = new SelectList(_context.Country, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Destination Destination { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Destination.Add(Destination);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}