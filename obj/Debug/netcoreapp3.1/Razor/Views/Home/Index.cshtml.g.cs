#pragma checksum "D:\Education\AnnuitetCalculator\AnnuitetCalculator\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e969849167b5bcc1529d1a47ce8361db5ce7f0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Education\AnnuitetCalculator\AnnuitetCalculator\Views\_ViewImports.cshtml"
using AnnuitetCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Education\AnnuitetCalculator\AnnuitetCalculator\Views\_ViewImports.cshtml"
using AnnuitetCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e969849167b5bcc1529d1a47ce8361db5ce7f0c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"470a96cf7fe329e42c321d8ed2fcdd33de902000", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Loan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Calculate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e969849167b5bcc1529d1a47ce8361db5ce7f0c3831", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"Sum\">Сумма займа</label>\r\n        <div class=\"input-group\">\r\n            ");
#nullable restore
#line 6 "D:\Education\AnnuitetCalculator\AnnuitetCalculator\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Sum, new { @class = "form-control", @type = "number", @placeholder = "Сумма", @name = "Sum" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"input-group-append\">\r\n                <div class=\"input-group-text\">руб</div>\r\n            </div>\r\n        </div>\r\n        ");
#nullable restore
#line 11 "D:\Education\AnnuitetCalculator\AnnuitetCalculator\Views\Home\Index.cshtml"
   Write(Html.ValidationMessageFor(m => m.Sum, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"Time\">Срок займа (в днях)</label>\r\n        ");
#nullable restore
#line 15 "D:\Education\AnnuitetCalculator\AnnuitetCalculator\Views\Home\Index.cshtml"
   Write(Html.TextBoxFor(m => m.Time, new { @class = "form-control", @type = "number", @placeholder = "Срок", @name = "Time" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 16 "D:\Education\AnnuitetCalculator\AnnuitetCalculator\Views\Home\Index.cshtml"
   Write(Html.ValidationMessageFor(m => m.Time, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"Rate\">Ставка (в день)</label>\r\n        <div class=\"input-group\">\r\n            ");
#nullable restore
#line 21 "D:\Education\AnnuitetCalculator\AnnuitetCalculator\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Rate, new { @class = "form-control", @type = "number", @placeholder = "Ставка", @name = "Rate" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"input-group-append\">\r\n                <span class=\"input-group-text\">%</span>\r\n            </div>\r\n        </div>\r\n        ");
#nullable restore
#line 26 "D:\Education\AnnuitetCalculator\AnnuitetCalculator\Views\Home\Index.cshtml"
   Write(Html.ValidationMessageFor(m => m.Rate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"Rate\">Шаг платежа</label>\r\n        <div class=\"input-group\">\r\n            ");
#nullable restore
#line 31 "D:\Education\AnnuitetCalculator\AnnuitetCalculator\Views\Home\Index.cshtml"
       Write(Html.TextBoxFor(m => m.Step, new { @class = "form-control", @type = "number", @placeholder = "Шаг", @name = "Step" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        ");
#nullable restore
#line 33 "D:\Education\AnnuitetCalculator\AnnuitetCalculator\Views\Home\Index.cshtml"
   Write(Html.ValidationMessageFor(m => m.Step, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Рассчитать</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Loan> Html { get; private set; }
    }
}
#pragma warning restore 1591
