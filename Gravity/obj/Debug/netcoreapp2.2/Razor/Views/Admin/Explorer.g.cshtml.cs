#pragma checksum "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47b0f9580f36250d8385e303e0f9b307ddc2eac4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Explorer), @"mvc.1.0.view", @"/Views/Admin/Explorer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Explorer.cshtml", typeof(AspNetCore.Views_Admin_Explorer))]
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
#line 1 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\_ViewImports.cshtml"
using Gravity;

#line default
#line hidden
#line 2 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\_ViewImports.cshtml"
using Gravity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b0f9580f36250d8385e303e0f9b307ddc2eac4", @"/Views/Admin/Explorer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07cf0a217bd801a86d29a3073d3b6b421cdc174d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Explorer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MineTransaction>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 383, true);
            WriteLiteral(@"

<section>
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">


            <div class=""table-responsive"">
                <table class=""table"" id=""myTable"">
                    <thead>
                        <tr>
                            <th>TX Link</th>
                            <th>
                                ");
            EndContext();
            BeginContext(421, 42, false);
#line 15 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                           Write(Html.DisplayNameFor(model => model.GasFee));

#line default
#line hidden
            EndContext();
            BeginContext(463, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(567, 44, false);
#line 18 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                           Write(Html.DisplayNameFor(model => model.TotalFee));

#line default
#line hidden
            EndContext();
            BeginContext(611, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(715, 48, false);
#line 21 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                           Write(Html.DisplayNameFor(model => model.totalCoinFee));

#line default
#line hidden
            EndContext();
            BeginContext(763, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(867, 48, false);
#line 24 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                           Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(915, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1019, 54, false);
#line 27 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                           Write(Html.DisplayNameFor(model => model.LastTransactinTime));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1177, 42, false);
#line 30 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                           Write(Html.DisplayNameFor(model => model.txHash));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 129, true);
            WriteLiteral("\r\n                            </th>\r\n\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                         foreach (var item in Model)
                        {
                            string url = "https://rinkeby.etherscan.io/tx/" + item.txHash;

#line default
#line hidden
            BeginContext(1521, 72, true);
            WriteLiteral("                            <tr>\r\n                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1593, "\"", 1604, 1);
#line 40 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
WriteAttributeValue("", 1600, url, 1600, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1605, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1607, 3, false);
#line 40 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                                              Write(url);

#line default
#line hidden
            EndContext();
            BeginContext(1610, 85, true);
            WriteLiteral("</a></td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1696, 41, false);
#line 42 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                               Write(Html.DisplayFor(modelItem => item.GasFee));

#line default
#line hidden
            EndContext();
            BeginContext(1737, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1853, 43, false);
#line 45 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                               Write(Html.DisplayFor(modelItem => item.TotalFee));

#line default
#line hidden
            EndContext();
            BeginContext(1896, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2012, 47, false);
#line 48 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                               Write(Html.DisplayFor(modelItem => item.totalCoinFee));

#line default
#line hidden
            EndContext();
            BeginContext(2059, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2175, 47, false);
#line 51 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2338, 53, false);
#line 54 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                               Write(Html.DisplayFor(modelItem => item.LastTransactinTime));

#line default
#line hidden
            EndContext();
            BeginContext(2391, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2507, 41, false);
#line 57 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                               Write(Html.DisplayFor(modelItem => item.txHash));

#line default
#line hidden
            EndContext();
            BeginContext(2548, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 60 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Explorer.cshtml"
                        }

#line default
#line hidden
            BeginContext(2651, 249, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            \r\n        </div>\r\n        </div>\r\n\r\n    </section>\r\n\r\n        \r\n\r\n        \r\n<script>\r\n     $(function () {\r\n        $(\'#myTable\').DataTable();\r\n    })\r\n</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MineTransaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591