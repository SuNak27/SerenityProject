using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace SerenPro.Perpustakaan.Pages
{

    [PageAuthorize(typeof(StatusRow))]
    public class StatusController : Controller
    {
        [Route("Perpustakaan/Status")]
        public ActionResult Index()
        {
            return View("~/Modules/Perpustakaan/Status/StatusIndex.cshtml");
        }
    }
}