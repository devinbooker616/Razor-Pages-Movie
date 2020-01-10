using Microsoft.EntityFrameworkCore;

namespace RazorPagesmovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options) : base(options)
        {

        }

        public DbSet<RazorPagesmovie.Models.Movie> Movie { get; set; }
    }
}