using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace CCPT2W5_HIITExercises.Models
{
    public class ExerciseContext : DbContext
    {
        public ExerciseContext(DbContextOptions<ExerciseContext> options)
            : base(options)
        {
        }

        public DbSet<Exercise> Exercises { get; set; } = null!;
    }
}
