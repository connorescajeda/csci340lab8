using RazorPagesLab8.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorPagesLab8.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesLab8.Data.SchoolContext _context;

        public IndexModel(RazorPagesLab8.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Course> Courses { get; set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}