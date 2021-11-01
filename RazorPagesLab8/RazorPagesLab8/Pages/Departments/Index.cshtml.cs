using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLab8.Data;
using RazorPagesLab8.Models;

namespace RazorPagesLab8.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesLab8.Data.SchoolContext _context;

        public IndexModel(RazorPagesLab8.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Department> Department { get;set; }

        public async Task OnGetAsync()
        {
            Department = await _context.Departments
                .Include(d => d.Administrator).ToListAsync();
        }
    }
}
