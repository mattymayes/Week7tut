using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Week7tut.Data;
using Week7tut.Models;

namespace Week7tut.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly Week7tut.Data.Week7tutContext _context;

        public IndexModel(Week7tut.Data.Week7tutContext context)
        {
            _context = context;
        }

        public IList<Students> Students { get;set; }

        public async Task OnGetAsync()
        {
            Students = await _context.Students.ToListAsync();
        }
    }
}
