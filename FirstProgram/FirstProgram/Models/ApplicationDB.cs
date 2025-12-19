using Microsoft.EntityFrameworkCore;
namespace FirstProgram.Models
{
    public class ApplicationDB :DbContext
    {
        public ApplicationDB(DbContextOptions<ApplicationDB> options) : base(options)
            { }
        public DbSet<Students> Students { get; set; }

    }
}
