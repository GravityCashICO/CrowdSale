#pragma checksum "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67e090bf21523065189f93d9efef6345ad8d9df0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e090bf21523065189f93d9efef6345ad8d9df0", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07cf0a217bd801a86d29a3073d3b6b421cdc174d", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Transaction>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
  
    var p = Convert.ToDecimal(Math.Pow(10, 18));
    string lastTrnxDate = (Model.Count() <= 0) ? null : Model.LastOrDefault().CreationDate.AddSeconds(1).ToString();

#line default
#line hidden
            BeginContext(210, 333, true);
            WriteLiteral(@"<section>
    <div class=""section__content section__content--p30"">
        <div class=""container-fluid"">


            <div class=""table-responsive"">
                <table class=""table"" id=""myTable"">
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(544, 43, false);
#line 17 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.FromKey));

#line default
#line hidden
            EndContext();
            BeginContext(587, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(691, 41, false);
#line 20 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.ToKey));

#line default
#line hidden
            EndContext();
            BeginContext(732, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(836, 46, false);
#line 23 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.CoinAmount));

#line default
#line hidden
            EndContext();
            BeginContext(882, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(986, 42, false);
#line 26 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1132, 48, false);
#line 29 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1284, 46, false);
#line 32 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.StatusType));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1434, 43, false);
#line 35 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.HashHex));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1581, 45, false);
#line 38 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Signature));

#line default
#line hidden
            EndContext();
            BeginContext(1626, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1730, 51, false);
#line 41 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.FeeInCoinAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 166, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 47 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2028, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2137, 42, false);
#line 51 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FromKey));

#line default
#line hidden
            EndContext();
            BeginContext(2179, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2295, 40, false);
#line 54 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.ToKey));

#line default
#line hidden
            EndContext();
            BeginContext(2335, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2451, 45, false);
#line 57 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CoinAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2496, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2612, 41, false);
#line 60 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2653, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2769, 47, false);
#line 63 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(2816, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2932, 45, false);
#line 66 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.StatusType));

#line default
#line hidden
            EndContext();
            BeginContext(2977, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3093, 42, false);
#line 69 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.HashHex));

#line default
#line hidden
            EndContext();
            BeginContext(3135, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3251, 44, false);
#line 72 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Signature));

#line default
#line hidden
            EndContext();
            BeginContext(3295, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3411, 50, false);
#line 75 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FeeInCoinAmount));

#line default
#line hidden
            EndContext();
            BeginContext(3461, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3576, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67e090bf21523065189f93d9efef6345ad8d9df013889", async() => {
                BeginContext(3621, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3629, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(3669, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67e090bf21523065189f93d9efef6345ad8d9df016261", async() => {
                BeginContext(3717, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3728, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(3768, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67e090bf21523065189f93d9efef6345ad8d9df018639", async() => {
                BeginContext(3815, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                                                             WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3825, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 83 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3928, 719, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
            <div class=""col-sm-4 col-sm-offset-4"" style=""margin-top: 3%;"">
                <input type=""submit"" id=""execSign"" tabindex=""4"" class=""form-control btn btn-primary"" value=""Delegate Transfer"">
            </div>

            <label id=""txlink"" style=""margin-left: 20%"">
                <span id=""txspan"" style=""display: none;"">Check your transaction status : </span>
                <a id=""linktx"" href='' target=""_blank""></a>
            </label>
        </div>
        </div>

    </section>

        

        <script type=""text/javascript"">
    $(function () {
        $('#myTable').DataTable();
        alert('");
            EndContext();
            BeginContext(4648, 12, false);
#line 105 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
          Write(lastTrnxDate);

#line default
#line hidden
            EndContext();
            BeginContext(4660, 77, true);
            WriteLiteral("\');\r\n        //window.location.href = \"/Admin/UploadTransaction?lastTrnxDate=");
            EndContext();
            BeginContext(4738, 12, false);
#line 106 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                                                                   Write(lastTrnxDate);

#line default
#line hidden
            EndContext();
            BeginContext(4750, 726, true);
            WriteLiteral(@"&hash=mmmmmm"";
    })

    window.addEventListener('load', async () => {
        // Modern dapp browsers...
        if (window.ethereum) {
            window.web3 = new Web3(ethereum);
            try {
                // Request account access if needed
                await ethereum.enable();
            } catch (error) {
                console.log(error);
            }
        }
        // Legacy dapp browsers...
        else if (window.web3) {
            window.web3 = new Web3(web3.currentProvider);
        }
        // Non-dapp browsers...
        else {
            console.log('Non-Ethereum browser detected. You should consider trying MetaMask!');
        }
    });


    var signs = '");
            EndContext();
            BeginContext(5477, 13, false);
#line 131 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
            Write(ViewBag.signs);

#line default
#line hidden
            EndContext();
            BeginContext(5490, 98, true);
            WriteLiteral("\';\r\n    var _toes = [];\r\n\r\n    var _values = [];\r\n    var _fees = [];\r\n\r\n    var _nonces = [];\r\n\r\n");
            EndContext();
#line 139 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
     foreach (var d in Model)
    {

#line default
#line hidden
            BeginContext(5626, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(5636, 12, true);
            WriteLiteral("_toes.push(\"");
            EndContext();
            BeginContext(5649, 7, false);
#line 141 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                 Write(d.ToKey);

#line default
#line hidden
            EndContext();
            BeginContext(5656, 13, true);
            WriteLiteral("\");\r\n        ");
            EndContext();
            BeginContext(5671, 14, true);
            WriteLiteral("_values.push(\"");
            EndContext();
            BeginContext(5687, 41, false);
#line 142 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                    Write((d.CoinAmount*p).ToString().Split('.')[0]);

#line default
#line hidden
            EndContext();
            BeginContext(5729, 13, true);
            WriteLiteral("\");\r\n        ");
            EndContext();
            BeginContext(5744, 12, true);
            WriteLiteral("_fees.push(\"");
            EndContext();
            BeginContext(5758, 19, false);
#line 143 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                  Write(d.FeeInCoinAmount*p);

#line default
#line hidden
            EndContext();
            BeginContext(5778, 13, true);
            WriteLiteral("\");\r\n        ");
            EndContext();
            BeginContext(5793, 20, true);
            WriteLiteral("_nonces.push(\'0\');\r\n");
            EndContext();
#line 145 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(5820, 2031, true);
            WriteLiteral(@"


    //alert(_toes);//data=""0x5377a6e400000000000000000000000000000000000000000000000000000000000000a0000000000000000000000000000000000000000000000000000000000000016000000000000000000000000000000000000000000000000000000000000001a000000000000000000000000000000000000000000000000000000000000001e0000000000000000000000000000000000000000000000000000000000000022000000000000000000000000000000000000000000000000000000000000000843078643836316233353232313663393538393333363631333830646661653231626131336366333139373233326132343633656562616634666534303261323237633034326631666638346166666232373331343362386264616230353864353337356532353031333830313963353062636533316534393831643034643136333731620000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000009c7feb9d283f038e7ad638b5996b78793a545c3000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000008000000000000000000000000000000000000000");
            WriteLiteral(@"0000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000""


            

        $(""#execSign"").click(function () {
            web3.eth.getAccounts(function (error, accounts) {
                contract.transferArray(signs, _toes, _values, _fees, _nonces, function (error, txHash) {
                    //contract.transferMul(fromA, toA, valA, feeA, function(error, txHash) {
                    if (!error) {
                        alert(txHash);
                        //$(""#label_common"").text(""Transaction hash : "" + txHash);
                        $(""#txspan"").show();
                        $(""#linktx"").text(txHash);
                        $(""#linktx"").attr('href', 'https://rinkeby.etherscan.io/tx/' + txHash);

                        window.location.href = ""/Admin/UploadTransaction?lastTrnxDate=");
            EndContext();
            BeginContext(7852, 12, false);
#line 165 "C:\Users\toufi\Desktop\CrowdSale\Gravity\Views\Admin\Index.cshtml"
                                                                                 Write(lastTrnxDate);

#line default
#line hidden
            EndContext();
            BeginContext(7864, 242, true);
            WriteLiteral("&hash=\" + txHash;\r\n                    } else {\r\n                        alert(error);\r\n                        //$(\"#label_common\").text(error);\r\n                    }\r\n                });\r\n            });\r\n        });\r\n\r\n        </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
