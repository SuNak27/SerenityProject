#pragma checksum "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cafc92512d23501e9186bebf6a8b5ccd2b993d77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Perpustakaan_Peminjaman_PeminjamanDetailReport), @"mvc.1.0.view", @"/Modules/Perpustakaan/Peminjaman/PeminjamanDetailReport.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\_ViewImports.cshtml"
using SerenPro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cafc92512d23501e9186bebf6a8b5ccd2b993d77", @"/Modules/Perpustakaan/Peminjaman/PeminjamanDetailReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d1312eb8739167b3053a8d0dec019e72c384c1", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Perpustakaan_Peminjaman_PeminjamanDetailReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SerenPro.Perpustakaan.PeminjamanDetailReportData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 5px; width:2cm;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/site/images/logoPerpus.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml"
 if ((bool?)ViewData["Printing"] == true)
{
  Layout = "_LayoutNoNavigation";
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h6>\r\n  <section class=\"invoice\">\r\n    <div class=\"pull-left\">\r\n      <center>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cafc92512d23501e9186bebf6a8b5ccd2b993d775448", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      </center>\r\n      <br>\r\n    </div>\r\n    <div class=\"row\">\r\n      <h2 class=\"page-header\">\r\n        Invoice Peminjaman Buku\r\n        <small class=\"pull-right\">Date: ");
#nullable restore
#line 19 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml"
                                   Write(DateTime.Now.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
      </h2>
    </div>
    <!-- info row -->
    <div class=""row invoice-info"">
      <div class=""col-sm-4 invoice-col"">
        <address>
          <br><br>
          <strong>PERPUSTAKAAN OPOP</strong><br>
          Jl. Loncat Indah Ruko Modern A7 Tasikmadu Malang<br>
          Phone: +62 812-3430-6725<br>
          Email: perpusopop@gmail.com
        </address>
      </div>
      <!-- /.col -->
      <div class=""col-sm-4 invoice-col"">
        <address>
          <strong>");
#nullable restore
#line 36 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml"
             Write(Model.Order.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong><br>
        </address>
      </div>
      <!-- /.col -->
    </div>
    <!-- /.row -->
    <!-- Table row -->
    <div class=""row"">
      <div class=""col-xs-12 col-12 table-responsive"">
        <table class=""table table-striped"">
          <thead>
            <tr>
              <th>Kode Peminjaman</th>
              <th>Kode Anggota</th>
              <th>Nama</th>
              <th>Buku</th>
              <th>Status</th>
              <th>Tanggal Peminjaman</th>
              <th>Tanggal Kembali</th>
              <th>Denda</th>
          </thead>
          <tbody>
            <tr>
              <td>");
#nullable restore
#line 59 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml"
             Write(Model.Order.KodePeminjaman);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 60 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml"
             Write(Model.Order.KodeAnggota);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 61 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml"
             Write(Model.Order.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>\r\n");
#nullable restore
#line 63 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml"
                 foreach (var d in Model.Details)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <p>");
#nullable restore
#line 65 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml"
                Write(d.IdBukuJudulBuku);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 66 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </td>\r\n              <td>");
#nullable restore
#line 68 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml"
             Write(Model.Order.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 69 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml"
             Write(Model.Order.TglPinjam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 70 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml"
             Write(Model.Order.TglKembali);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 71 "C:\Users\Alfad\OneDrive\Documents\Santri\SerenPro\SerenPro.Web\Modules\Perpustakaan\Peminjaman\PeminjamanDetailReport.cshtml"
             Write(Model.Order.Denda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n          </tbody>\r\n        </table>\r\n      </div>\r\n      <!-- /.col -->\r\n    </div>\r\n\r\n\r\n    <div class=\"text-center\">\r\n      <h4>Terima Kasih Telah Meminjam Buku Di Perpustakaan Kita</h4>\r\n    </div>\r\n\r\n  </section>\r\n</h6>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SerenPro.Perpustakaan.PeminjamanDetailReportData> Html { get; private set; }
    }
}
#pragma warning restore 1591
