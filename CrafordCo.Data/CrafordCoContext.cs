using CrafordCo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrafordCo.Data
{
    public class CrafordCoContext:DbContext
    {
        public CrafordCoContext(DbContextOptions<CrafordCoContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<LossType> LossTypes { get; set; }
    }
}
