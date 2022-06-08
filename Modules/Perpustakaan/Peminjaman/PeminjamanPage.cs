using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenPro.Perpustakaan.Pages
{

    [PageAuthorize(typeof(PeminjamanRow))]
    public class PeminjamanController : Controller
    {
        [Route("Perpustakaan/Peminjaman")]
        public ActionResult Index()
        {
            return View("~/Modules/Perpustakaan/Peminjaman/PeminjamanIndex.cshtml");
        }
    }
}