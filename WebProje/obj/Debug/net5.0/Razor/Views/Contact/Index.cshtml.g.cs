#pragma checksum "C:\Users\HuseyinCan\source\repos\WebProje\WebProje\Views\Contact\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bb0446662830e851d119dd27da7de66900d61ef48203eab1331978e145e81dcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HuseyinCan\source\repos\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\HuseyinCan\source\repos\WebProje\WebProje\Views\_ViewImports.cshtml"
using WebProje.Models

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\HuseyinCan\source\repos\WebProje\WebProje\Views\Contact\Index.cshtml"
 using varlikKatmani.Concrete

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bb0446662830e851d119dd27da7de66900d61ef48203eab1331978e145e81dcd", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1ec0f35b8ffb1d479411b74211d562334f50a28c53417813250aa4ce612ae9b7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<message>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\HuseyinCan\source\repos\WebProje\WebProje\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Mesajlar</h4>
            <p class=""card-description"">

            </p>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>İsim</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Düzenle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 27 "C:\Users\HuseyinCan\source\repos\WebProje\WebProje\Views\Contact\Index.cshtml"
                         foreach (var item in Model)
                        {


#line default
#line hidden
#nullable disable

            WriteLiteral("                            <tr>\r\n                                <td>");
            Write(
#nullable restore
#line 31 "C:\Users\HuseyinCan\source\repos\WebProje\WebProje\Views\Contact\Index.cshtml"
                                     item.messageID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td>");
            Write(
#nullable restore
#line 32 "C:\Users\HuseyinCan\source\repos\WebProje\WebProje\Views\Contact\Index.cshtml"
                                     item.name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td>");
            Write(
#nullable restore
#line 33 "C:\Users\HuseyinCan\source\repos\WebProje\WebProje\Views\Contact\Index.cshtml"
                                      ((DateTime)item.date).ToString("dd-MMM-yyyy")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1174, "\"", 1219, 2);
            WriteAttributeValue("", 1181, "/Contact/DeleteMessage/", 1181, 23, true);
            WriteAttributeValue("", 1204, 
#nullable restore
#line 34 "C:\Users\HuseyinCan\source\repos\WebProje\WebProje\Views\Contact\Index.cshtml"
                                                                     item.messageID

#line default
#line hidden
#nullable disable
            , 1204, 15, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1304, "\"", 1346, 2);
            WriteAttributeValue("", 1311, "/Contact/SeeMessage/", 1311, 20, true);
            WriteAttributeValue("", 1331, 
#nullable restore
#line 35 "C:\Users\HuseyinCan\source\repos\WebProje\WebProje\Views\Contact\Index.cshtml"
                                                                  item.messageID

#line default
#line hidden
#nullable disable
            , 1331, 15, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Gör</a></td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\HuseyinCan\source\repos\WebProje\WebProje\Views\Contact\Index.cshtml"


                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n             \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
