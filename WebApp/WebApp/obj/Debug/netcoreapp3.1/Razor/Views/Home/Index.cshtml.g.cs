#pragma checksum "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f9ead95c4dcbbc93848977b850569a58619711e"
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
#line 1 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f9ead95c4dcbbc93848977b850569a58619711e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Models.Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-begin", new global::Microsoft.AspNetCore.Html.HtmlString("clearInputField"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-complete", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-failure", new global::Microsoft.AspNetCore.Html.HtmlString("alert(\'Fail\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("sendMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var userName = User.Identity.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<div class=""jumbotron bg-light"">
    <h2 class=""text-center text-primary"">
        <i class=""fab fa-facebook-messenger""></i>&nbsp; Public Talk
    </h2>

    <div class=""row"">
        <div class=""col-md-12"" id=""chat"">
");
#nullable restore
#line 19 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
                 foreach (var message in Model.OrderBy(m => m.Time))
                {
                    string containerClass, timePosition, textAlign, contcolor, offset;
                    if (userName == message.UserName)
                    {
                        containerClass = "container darker";
                        timePosition = "time-right text-light";
                        textAlign = "text-right text-white";
                        contcolor = "bg-primary";
                        offset = "col-md-6 offset-md-6";
                    }
                    else
                    {
                        containerClass = "container";
                        timePosition = "time-left";
                        textAlign = "text-left";
                        contcolor = "bg-light";
                        offset = "";
                    }


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 1556, "\"", 1571, 1);
#nullable restore
#line 42 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1564, offset, 1564, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 1607, "\"", 1641, 2);
#nullable restore
#line 43 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1615, containerClass, 1615, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1630, contcolor, 1631, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <p");
            BeginWriteAttribute("class", " class=\"", 1679, "\"", 1704, 2);
            WriteAttributeValue("", 1687, "sender", 1687, 6, true);
#nullable restore
#line 44 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 1693, textAlign, 1694, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
                                                        Write(message.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p");
            BeginWriteAttribute("class", " class=\"", 1763, "\"", 1781, 1);
#nullable restore
#line 45 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1771, textAlign, 1771, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
                                                 Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <span");
            BeginWriteAttribute("class", " class=\"", 1839, "\"", 1860, 1);
#nullable restore
#line 46 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1847, timePosition, 1847, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
                                                       Write(message.Time.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 51 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
                 
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f9ead95c4dcbbc93848977b850569a58619711e11802", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3f9ead95c4dcbbc93848977b850569a58619711e12077", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 59 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <div class=""form-group"">
                    <input name=""Text"" class=""form-control"" id=""messageText""/>
                </div>
                <div class=""form-group"">
                    <input type=""submit"" value=""Send"" id=""submitButton"" class=""btn""/>
                </div>
                <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 2751, "\"", 2768, 1);
#nullable restore
#line 66 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2759, userName, 2759, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"username\"/>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>

</div>

<script>
    <sctipt src=""~/signalr/signalr.min.js"" />
    <script src=""~/lib/jquery/dist/jquery.unobtrusive-ajax.min.js"" />
    <script src=""~/js/chat.js""/>
    <script src=""~/js/signalrReqHandler.js""/>
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Models.Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
