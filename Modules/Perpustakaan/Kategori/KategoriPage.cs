using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenPro.Perpustakaan.Pages
{

    [PageAuthorize(typeof(KategoriRow))]
    public class KategoriController : Controller
    {
        [Route("Perpustakaan/Kategori")]
        public ActionResult Index()
        {
            return View("~/Modules/Perpustakaan/Kategori/KategoriIndex.cshtml");
        }
    }
}