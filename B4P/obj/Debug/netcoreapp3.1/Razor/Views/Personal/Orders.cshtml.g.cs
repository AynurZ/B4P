#pragma checksum "C:\Users\aynur\source\repos\B4P\B4P\Views\Personal\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "083b93b1d8f7f40fdd6e31b6480424fe65e85c79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Orders), @"mvc.1.0.view", @"/Views/Personal/Orders.cshtml")]
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
#line 1 "C:\Users\aynur\source\repos\B4P\B4P\Views\_ViewImports.cshtml"
using B4P;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aynur\source\repos\B4P\B4P\Views\_ViewImports.cshtml"
using B4P.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"083b93b1d8f7f40fdd6e31b6480424fe65e85c79", @"/Views/Personal/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5b3877403e845933dc6a0df672316162953ca10", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<B4P.Models.Orders>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"top-main\">\r\n    <div><p class=\"main-popular\">Заказы</p></div>\r\n    <table class=\"order-table\">\r\n");
#nullable restore
#line 5 "C:\Users\aynur\source\repos\B4P\B4P\Views\Personal\Orders.cshtml"
           for (int i = 0; i < 2; i++) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"order-line\">\r\n                <td class=\"order-line-left\">\r\n                    <table class=\"order-basket\">\r\n");
#nullable restore
#line 9 "C:\Users\aynur\source\repos\B4P\B4P\Views\Personal\Orders.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <ul>\r\n                                    <li><h2>");
#nullable restore
#line 14 "C:\Users\aynur\source\repos\B4P\B4P\Views\Personal\Orders.cshtml"
                                       Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></li>\r\n                                    <li><p>");
#nullable restore
#line 15 "C:\Users\aynur\source\repos\B4P\B4P\Views\Personal\Orders.cshtml"
                                      Write(item.OrderSum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></li>\r\n");
#nullable restore
#line 16 "C:\Users\aynur\source\repos\B4P\B4P\Views\Personal\Orders.cshtml"
                                      
                                        if (@item.StatusId == 1)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><p style=\"color: #6fac61;\">Доставлен</p></li>\r\n");
#nullable restore
#line 20 "C:\Users\aynur\source\repos\B4P\B4P\Views\Personal\Orders.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li><p style=\"color:black;\">В заказе</p></li>\r\n");
#nullable restore
#line 24 "C:\Users\aynur\source\repos\B4P\B4P\Views\Personal\Orders.cshtml"
                                        }

                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </td>
                            <td>
                                <div class=""form-group"">
                                    <input type=""submit"" value=""Подробнее о заказе"" class=""btn btn-outline-dark"" />
                                </div>
                            </td>
                        </tr>
");
#nullable restore
#line 35 "C:\Users\aynur\source\repos\B4P\B4P\Views\Personal\Orders.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </table>
                </td>
                <td>
                    <table class=""order-images"">
                        <tr>
                            <td><img src=""/images/logo.png""></td>
                            <td><img src=""/images/logo.png""></td>
                            <td><img src=""/images/logo.png""></td>
                        </tr>
                    </table>
                    <ul>
");
            WriteLiteral("                        \r\n                        \r\n                        \r\n");
            WriteLiteral("                    </ul>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\aynur\source\repos\B4P\B4P\Views\Personal\Orders.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<B4P.Models.Orders>> Html { get; private set; }
    }
}
#pragma warning restore 1591
