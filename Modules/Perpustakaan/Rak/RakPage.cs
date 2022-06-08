using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenPro.Perpustakaan.Pages
{

    [PageAuthorize(typeof(RakRow))]
    public class RakController : Controller
    {
        [Route("Perpustakaan/Rak")]
        public ActionResult Index()
        {
            return View("~/Modules/Perpustakaan/Rak/RakIndex.cshtml");
        }
    }
}