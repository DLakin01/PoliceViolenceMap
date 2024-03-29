﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PoliceViolenceMap.Models;

namespace PoliceViolenceMap.Pages
{
    public class DataModel : PageModel
    {
        private readonly PoliceViolenceContext _context;

        public DataModel(PoliceViolenceContext context)
        {
            _context = context;
        }

        public IList<KillingsByState> StateIncidents { get; set; }
        public IList<PoliceKillings> AllIncidents { get; set; }
        public IList<SelectListItem> States { get; set; }
        public string SelectedState { get; set; }

        public async Task OnGetAsync()
        {
            StateIncidents = await _context.KillingsByState.ToListAsync();
            AllIncidents = await _context.PoliceKillings.ToListAsync();
        }

        public PartialViewResult StateBreakdown(string selectedState)
        {
            IList<KillingsByState> SelectedIncidents = StateIncidents.Where(c => c.State == selectedState).ToList();
            return Partial("_StateBreakdown", SelectedIncidents);
        }
    }
}