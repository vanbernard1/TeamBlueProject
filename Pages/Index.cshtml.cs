using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using TeamBlueProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TeamBlueProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CLODbContext _context; //Replaces "db" variable

        public List<CLO> CLOs {get; set;}

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(CLODbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            CLOs = _context.CLOs.ToList();       

        }
    }
}