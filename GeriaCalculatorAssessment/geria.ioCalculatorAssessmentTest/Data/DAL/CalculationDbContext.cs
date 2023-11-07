using geria.ioCalculatorAssessmentTest.Models;
using Microsoft.EntityFrameworkCore;
using System.IO.Pipelines;

namespace geria.ioCalculatorAssessmentTest.Data.DAL
{
    public class CalculationDbContext : DbContext
    {
        public CalculationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<CalculationModel> Calculations { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
