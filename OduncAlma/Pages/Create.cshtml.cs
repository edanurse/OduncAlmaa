using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OduncAlma.Data;
using OduncAlma.Model;
using System;

namespace OduncAlma.Pages
{
    public class CreateModel : PageModel
    {
       
        
        [BindProperty]
        public OduncVerme OduncVerme { get; set; }
        public List<SelectListItem> Items { get; } = new List<SelectListItem>() 
        { 
            new SelectListItem{Value = "Bilgisayar", Text = "Bilgisayar" },
            new SelectListItem{ Value = "Kamera", Text = "Kamera"},
            new SelectListItem{ Value = "Kitap", Text = "Kitap" } 
            
        };

        private OduncAlmaDbContext _db;
        public CreateModel(OduncAlmaDbContext db) {
            _db = db;
        }
        public void OnGet()
        {
        } 
        public IActionResult OnPost()
        {
            //OduncVermeTarihi Boþ olamaz
            //if (string.IsNullOrWhiteSpace(OduncVerme.DateGive.ToString()))
            //{
            //    //SÝSTEMÝN TANIMLADIÐI HATALAR DIÞINDA BENÝM KABUL ETTÝÐÝM HATAYI EKLEME
            //    ModelState.AddModelError("OduncVerme.DateGive","Tarih Seçilmedi");
            //}
            ///validation
            if (ModelState.IsValid)
            {
            _db.OduncIslemler.Add(OduncVerme);
            _db.SaveChanges();
            return RedirectToPage("Index");
            }
            return Page();
        }
    }
}  