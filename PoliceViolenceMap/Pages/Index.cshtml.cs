using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PoliceViolenceMap.Models;

namespace PoliceViolenceMap.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PoliceViolenceContext _context;

        public IndexModel(PoliceViolenceContext context)
        {
            _context = context;
        }

        public IList<PoliceKillings> Incidents { get; set; }

        public async Task OnGetAsync()
        {
            Incidents = await _context.PoliceKillings.Where(c => c.Latitude != null).ToListAsync();
        }
    }

    public class LatLong
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
