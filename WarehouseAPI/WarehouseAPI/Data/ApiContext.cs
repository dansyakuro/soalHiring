using Microsoft.EntityFrameworkCore;
using WarehouseAPI.Models;

namespace WarehouseAPI.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Warehouse> Products { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options)
            :base (options) 
        { 
        }
    }
}
