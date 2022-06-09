using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenPro.Perpustakaan.Pages
{

    [PageAuthorize(typeof(PeminjamanRow))]
    public class PengembalianController : Controller
    {
        [Route("Perpustakaan/Pengembalian")]
        public ActionResult Index()
        {
            return View("~/Modules/Perpustakaan/Peminjaman/PengembalianIndex.cshtml");
        }
    }
}