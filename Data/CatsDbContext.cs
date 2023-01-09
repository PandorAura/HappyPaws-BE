using HappyPaws_BE.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace HappyPaws_BE.Data
{
    public class CatsDbContext: DbContext
    {
        public CatsDbContext(DbContextOptions<CatsDbContext> options): base(options)
        {

        }

        public DbSet<Cats> Cats { get; set; }
    }
}
