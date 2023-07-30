using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using WebApplication2.Data;

namespace WebApplication2.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication2.Data.SchoolContext _context;

        public IndexModel(WebApplication2.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Students.ToListAsync();
            }
        }
    }
}
