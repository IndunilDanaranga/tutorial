#pragma checksum "C:\Users\Indunil\Desktop\My Project\Final\PizzaHouse\PizzaHouse\Pages\Contactus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f886fe8a35446434f055dcfb6d76c11f690ae1c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PizzaHouse.Pages.Pages_Contactus), @"mvc.1.0.razor-page", @"/Pages/Contactus.cshtml")]
namespace PizzaHouse.Pages
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
#line 1 "C:\Users\Indunil\Desktop\My Project\Final\PizzaHouse\PizzaHouse\Pages\_ViewImports.cshtml"
using PizzaHouse;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f886fe8a35446434f055dcfb6d76c11f690ae1c1", @"/Pages/Contactus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54121a252e1d6bd7f2ff3111831e93da1dfaf43a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contactus : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""container"">
    <div class=""card-group"">
        <div class=""card bg-dark text-center"" style=""margin:10px;"">
            <div class=""card-header"">
                <a href=""Pizza"">
                    <button class=""btn btn-dark font-weight-bold"" style=""border-radius:8px;"">
                        Order Now !
                    </button>
                </a>
            </div>
            <div class=""card-body"">
                <h5 class=""card-title"" style=""color:white"">
                    Dr.Pizza Pizza Cafe
                </h5>
                <p class=""font-weight-bold"" style=""color:white"">
                    6541 Hollywood Blvd <br />
                    Los Angeles, CA 90028 <br />
                    P:0766004815 <br />
                </p>
                <p style=""color:white"">
                    Business hours
                </p>
                <br />
                <p class=""font-weight-bold"" style=""color:white"">
                    Su, Mo, Tu, We, Th, Fr, ");
            WriteLiteral(@"Sa <br />
                    7:00am – 2:00am
                </p>
            </div>
            <div class=""card-footer"">
                <p style=""color:white"">
                    Contact Us
                </p>
            </div>
        </div>
        <div class=""card bg-dark text-center"" style=""margin:10px;"">
            <div class=""card-body"">
                <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3332.891748918397!2d80.57372672056827!3d6.584774274824294!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3ae3ec24479d959b%3A0xa7c625c88e971f93!2sP%20%26%20S%20Kahawatte!5e0!3m2!1sen!2slk!4v1668032541671!5m2!1sen!2slk"" style=""border:0;height:100%;width:100%;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 1790, "\"", 1808, 0);
            EndWriteAttribute();
            WriteLiteral(@" loading=""lazy"" referrerpolicy=""no-referrer-when-downgrade""></iframe>
            </div>
        </div>
        <div class=""card bg-dark text-left"" style=""margin:10px;"">
            <div class=""card-body"">
                <h5 class=""card-title font-weight-bold"" style=""color:peru"">
                    Talk Us
                </h5>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f886fe8a35446434f055dcfb6d76c11f690ae1c16030", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-sm-12 col-sm-6 col-lg-6 col-xl-6"" style=""color:white"">
                            First Name:
                            <br />
                            <input type=""text"" name=""fname""");
                BeginWriteAttribute("value", " value=\"", 2469, "\"", 2477, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""First name"" style=""width:100%"" />
                        </div>
                        <div class=""col-sm-12 col-sm-6 col-lg-6 col-xl-6"" style=""color:white"">
                            Last Name:
                            <br />
                            <input type=""text"" name=""lname""");
                BeginWriteAttribute("value", " value=\"", 2790, "\"", 2798, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Last name"" style=""width:100%"" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-12 col-sm-6 col-lg-6 col-xl-6"" style=""color:white"">
                            Last Name:
                            <br />
                            <input type=""email"" name=""email""");
                BeginWriteAttribute("value", " value=\"", 3178, "\"", 3186, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Email"" style=""width:100%"" />
                        </div>
                        <div class=""col-sm-12 col-sm-6 col-lg-6 col-xl-6"" style=""color:white"" >
                            Last Name:
                            <br />
                            <input type=""tel"" name=""pno""");
                BeginWriteAttribute("value", " value=\"", 3492, "\"", 3500, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Pno"" pattern=""[0-9]{10}"" style=""width:100%"" />
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""container"" style=""color:white"">
                            Questions or Comments:
                            <br />
                            <textarea name=""massage"" rows=""5"" cols=""20"" style=""width:100%""></textarea>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""container"">
                            <br />
                            <button type=""submit"" class=""btn btn-dark"" style=""width:100%"">
                                Submit
                            </button>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaHouse.Pages.ContactusModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzaHouse.Pages.ContactusModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzaHouse.Pages.ContactusModel>)PageContext?.ViewData;
        public PizzaHouse.Pages.ContactusModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591