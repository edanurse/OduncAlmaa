using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OduncAlma.Data;
using OduncAlma.Model;

namespace OduncAlma.Pages
{
    public class IndexModel : PageModel
    {
       
        public IEnumerable<OduncVerme> OduncIslem { get; set; }
        private readonly OduncAlmaDbContext _db;

      
        public IndexModel(OduncAlmaDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
            OduncIslem = _db.OduncIslemler;
        }
    }
}