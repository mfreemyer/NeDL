using Microsoft.EntityFrameworkCore;

namespace CCPT2W5_HIITExercises.Models
{
    public class CCPT2W5Context : DbContext
    {
        public CCPT2W5Context(DbContextOptions<CCPT2W5Context> options)
            : base(options)
        {

        }

        public DbSet<Exercise> Exercise { get; set; }
    }
}
