#pragma checksum "C:\Users\Admin\Documents\project\project\web-api\HarpstoreWeb\HarpstoreWeb\HarpstoreWeb\Views\Product\OfProducer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "127666fdc3e2f6ff552e61ab47eb025130a0a181"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_OfProducer), @"mvc.1.0.view", @"/Views/Product/OfProducer.cshtml")]
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
#line 1 "C:\Users\Admin\Documents\project\project\web-api\HarpstoreWeb\HarpstoreWeb\HarpstoreWeb\Views\_ViewImports.cshtml"
using HarpstoreWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\project\project\web-api\HarpstoreWeb\HarpstoreWeb\HarpstoreWeb\Views\_ViewImports.cshtml"
using HarpstoreWeb.Models.Producer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\project\project\web-api\HarpstoreWeb\HarpstoreWeb\HarpstoreWeb\Views\_ViewImports.cshtml"
using HarpstoreWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"127666fdc3e2f6ff552e61ab47eb025130a0a181", @"/Views/Product/OfProducer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"467e29bf198ef1d71a73ad2b517831707b0c5f20", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_OfProducer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmAddEditdepartment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/product.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin\Documents\project\project\web-api\HarpstoreWeb\HarpstoreWeb\HarpstoreWeb\Views\Product\OfProducer.cshtml"
  
    ViewBag.Title = "List Products";
    var producer = ViewBag.Producer as Producer;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 103, "\"", 111, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1 class=\"display-4\">");
#nullable restore
#line 6 "C:\Users\Admin\Documents\project\project\web-api\HarpstoreWeb\HarpstoreWeb\HarpstoreWeb\Views\Product\OfProducer.cshtml"
                         Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 6 "C:\Users\Admin\Documents\project\project\web-api\HarpstoreWeb\HarpstoreWeb\HarpstoreWeb\Views\Product\OfProducer.cshtml"
                                           Write(producer.ProducerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <input hidden id=\"ProducerId\"");
            BeginWriteAttribute("value", " value=\"", 229, "\"", 257, 1);
#nullable restore
#line 7 "C:\Users\Admin\Documents\project\project\web-api\HarpstoreWeb\HarpstoreWeb\HarpstoreWeb\Views\Product\OfProducer.cshtml"
WriteAttributeValue("", 237, producer.ProducerId, 237, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        <div class=""row"">
            <div class=""col-12 mb-3"">
                <a href=""javascript:void(0);"" class=""btn btn-info""
                   onclick=""home.openAddEditdepartment()"">Create</a>
            </div>
        </div>
        <table id=""tbProduct"" class=""table table-bordered table-hover"">
            <thead>
                <tr>
                    <th>Product Name</th>
                    <th>AvataPath</th>
                    <th>ProType</th>
                    <th>ProductPrice</th>
                    <th>Action</th>
                </tr>
            </thead>
            <tbody>
");
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <!-- Modal -->\r\n        <div id=\"addEditdepartment\" class=\"modal fade\" role=\"dialog\">\r\n            <div class=\"modal-dialog modal-lg\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "127666fdc3e2f6ff552e61ab47eb025130a0a1816947", async() => {
                WriteLiteral(@"
                    <!-- Modal content-->
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h4 class=""modal-title"">Add New Department</h4>
                            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                        </div>
                        <input hidden id=""DepartmentId"" name=""DepartmentId"">
                        <div class=""modal-body"">
                            <div class=""row form-group"">
                                <div class=""col-3"">
                                    <label>Department Name</label>
                                </div>
                                <div class=""col-9"">
                                    <input type=""text"" id=""DepartmentName"" name=""Department Name"" class=""form-control"" data-rule-required=""true"">
                                </div>
                            </div>
                        </div>
           ");
                WriteLiteral(@"             <div class=""modal-footer"">
                            <button type=""button"" class=""btn btn-info"" data-dismiss=""modal"">Close</button>
                            <a href=""javascript:;"" class=""btn btn-danger"" onclick=""home.save()"">Save</a>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "127666fdc3e2f6ff552e61ab47eb025130a0a1819849", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 67 "C:\Users\Admin\Documents\project\project\web-api\HarpstoreWeb\HarpstoreWeb\HarpstoreWeb\Views\Product\OfProducer.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
