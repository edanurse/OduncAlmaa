using Microsoft.EntityFrameworkCore;
using OduncAlma.Model;

namespace OduncAlma.Data
{
    public class OduncAlmaDbContext: DbContext
    {
        public DbSet<OduncVerme> OduncIslemler { get; set; }
        public OduncAlmaDbContext(DbContextOptions<OduncAlmaDbContext> option) : base(option)
        {

        }
        
    }


}
