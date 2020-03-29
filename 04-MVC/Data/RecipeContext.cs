using Microsoft.EntityFrameworkCore;
using _04_MVC.Models;

namespace _04_MVC.Data
{
    public class RecipeContext : DbContext
    {
        public RecipeContext (DbContextOptions<RecipeContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipe { get; set; }
    }
}