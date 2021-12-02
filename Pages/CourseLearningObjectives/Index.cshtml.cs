using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TeamBlueProject.Models;


namespace TeamBlueProject.Pages.CourseLearningObjectives
{
    public class IndexModel : PageModel
    {        
        private readonly TeamBlueProject.Models.AssessmentDbContext _context;
        
        public IndexModel(TeamBlueProject.Models.AssessmentDbContext context)
        {
            _context = context;
        }
        public IList<CLO> CLO { get;set; }

        public async Task OnGetAsync()
        {
            CLO = await _context.CLOs.ToListAsync();
        }
    }
}
