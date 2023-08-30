using CoinGraphic.Models;
using Microsoft.EntityFrameworkCore;

namespace CoinGraphic.Context
{
    public class ADDContext : DbContext
    {
        public ADDContext(DbContextOptions<ADDContext> options) : base(options) 
        {
        }
        public DbSet<CoinHistoric5Y> CoinHistoric5ys { get; set; }
        public DbSet<CoinHistoricLast30Days> CoinHistoricLast30Days { get; set; }
    }
}
