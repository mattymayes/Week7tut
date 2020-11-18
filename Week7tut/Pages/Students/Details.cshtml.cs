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
    public class DetailsModel : PageModel
    {
        private readonly Week7tut.Data.Week7tutContext _context;

        public DetailsModel(Week7tut.Data.Week7tutContext context)
        {
            _context = context;
        }

        public Students Students { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Students = await _context.Students.FirstOrDefaultAsync(m => m.Id == id);

            if (Students == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
