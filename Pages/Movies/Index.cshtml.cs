using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesmovie.Data;
using RazorPagesmovie.Models;

namespace RazorPagesmovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesmovie.Data.RazorPagesMovieContext _context;

        public IndexModel(RazorPagesmovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
