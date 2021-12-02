using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;        // Required using directives for Data Validation
using System.ComponentModel.DataAnnotations.Schema;
using TeamBlueProject.Models;

namespace TeamBlueProject.Pages.CourseLearningObjectives
{
    public class CreateModel : PageModel
    {        
        private readonly TeamBlueProject.Models.AssessmentDbContext _context;

        public CreateModel(TeamBlueProject.Models.AssessmentDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CLO CLO { get; set; }

        // protect from overposting attacks
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CLOs.Add(CLO);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}