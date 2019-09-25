using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreCRUD3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreCRUD3.Pages
{
    public class IndexModel : PageModel
    {
        private CoreCRUD3Context _context;
        public IndexModel(CoreCRUD3Context context)
        {
            _context = context;
        }
        public void OnGet()
        {

            CountofMetropolitan = _context.Destination
                                                   .Where(x => x.Type == "Metropolitan")
                                                   .Count();

        }
        public int CountofMetropolitan { get; set; }
    }
}
