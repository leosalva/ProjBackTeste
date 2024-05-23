using Microsoft.EntityFrameworkCore;

namespace ProjBackTeste.Data.Context
{
    public class ProjBackContext : DbContext
    {
        public ProjBackContext(DbContextOptions<ProjBackContext> option) : base(option) { }

        //DBSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Class Maps
        }
    }
}
