#pragma checksum "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a96c6b2725396947573befecc59ada40751aacb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PrivateMessages_Chat), @"mvc.1.0.view", @"/Views/PrivateMessages/Chat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a96c6b2725396947573befecc59ada40751aacb", @"/Views/PrivateMessages/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_PrivateMessages_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApp.Models.PrivateMessage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PrivateMessages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/signalr/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalrPMReqHandler.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
  
    ViewData["Title"] = "Chat Page";
    var userName = User.Identity.Name;
    var userId = ViewBag.UserId;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron bg-light\">\r\n    <h2 class=\"text-center text-primary\">\r\n        <i class=\"fab fa-facebook-messenger\"></i>&nbsp; Public Chat Room\r\n    </h2>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\" id=\"chat\">\r\n");
#nullable restore
#line 15 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
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
            BeginWriteAttribute("class", " class=\"", 1411, "\"", 1426, 1);
#nullable restore
#line 38 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
WriteAttributeValue("", 1419, offset, 1419, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 1462, "\"", 1496, 2);
#nullable restore
#line 39 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
WriteAttributeValue("", 1470, containerClass, 1470, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
WriteAttributeValue(" ", 1485, contcolor, 1486, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <p");
            BeginWriteAttribute("class", " class=\"", 1534, "\"", 1559, 2);
            WriteAttributeValue("", 1542, "sender", 1542, 6, true);
#nullable restore
#line 40 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
WriteAttributeValue(" ", 1548, textAlign, 1549, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
                                                        Write(message.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p");
            BeginWriteAttribute("class", " class=\"", 1618, "\"", 1636, 1);
#nullable restore
#line 41 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
WriteAttributeValue("", 1626, textAlign, 1626, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
                                                 Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <span");
            BeginWriteAttribute("class", " class=\"", 1694, "\"", 1715, 1);
#nullable restore
#line 42 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
WriteAttributeValue("", 1702, timePosition, 1702, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
                                                       Write(message.Time.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 46 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""col-md-12"">
            <div class=""form-group"">
                <input name=""Text"" class=""form-control"" id=""messageText"" />
            </div>
            <div class=""form-group"">
                <input type=""button"" value=""Send"" id=""submitButton"" class=""btn"" />
            </div>
            <input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 2238, "\"", 2253, 1);
#nullable restore
#line 56 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
WriteAttributeValue("", 2246, userId, 2246, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"userId\" />\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2303, "\"", 2320, 1);
#nullable restore
#line 57 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
WriteAttributeValue("", 2311, userName, 2311, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"username\" />\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2372, "\"", 2399, 1);
#nullable restore
#line 58 "C:\data\bsuir\asp\WebApplication1\WebApp\WebApp\Views\PrivateMessages\Chat.cshtml"
WriteAttributeValue("", 2380, ViewBag.CombinedId, 2380, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"combinedId\"/>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a96c6b2725396947573befecc59ada40751aacb12198", async() => {
                WriteLiteral("\r\n                Back\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a96c6b2725396947573befecc59ada40751aacb13723", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a96c6b2725396947573befecc59ada40751aacb14763", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApp.Models.PrivateMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
