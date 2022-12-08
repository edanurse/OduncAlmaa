using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OduncAlma.Data;
using OduncAlma.Model;

namespace OduncAlma.Pages
{
    public class ReturnModel : PageModel
    {
        //[BindProperty(SupportsGet = true)]
        //public int Id { get; set; }

        [BindProperty]
        public OduncVerme OduncVerme { get; set; }

        private readonly OduncAlmaDbContext db;
        public ReturnModel(OduncAlmaDbContext db)
        {
            this.db = db;
        }
        public void OnGet(int id)
        {
            OduncVerme = db.OduncIslemler.Find(id);
        }

        public IActionResult OnPost()
        {
            if (OduncVerme.DateTake is not null
               &&
               DateTime.Compare(OduncVerme.DateGive, (DateTime)OduncVerme.DateTake) > 0)
            {
                ModelState.AddModelError("@OduncIslem.DateReturn", "iade tarihi veriliþ tarihinden önce olamaz");
            }
            if (ModelState.IsValid)
            {
                db.OduncIslemler.Update(OduncVerme);
                db.SaveChanges();
            return RedirectToPage();
            }
            return Page();
        }
    }
}
