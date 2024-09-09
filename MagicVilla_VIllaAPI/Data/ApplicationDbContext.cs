using MagicVilla_VIllaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VIllaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        public DbSet<Villa> Villas { get; set; }
    }
}
