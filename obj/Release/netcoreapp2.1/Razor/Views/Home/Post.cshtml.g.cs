#pragma checksum "F:\програм\fin\Fin\Fin\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c55f0633fc592fd02269b9171429fdbcfb1e68c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Post.cshtml", typeof(AspNetCore.Views_Home_Post))]
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
#line 1 "F:\програм\fin\Fin\Fin\Views\_ViewImports.cshtml"
using Fin.Models;

#line default
#line hidden
#line 2 "F:\програм\fin\Fin\Fin\Views\_ViewImports.cshtml"
using Fin.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c55f0633fc592fd02269b9171429fdbcfb1e68c2", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b88597ab4dbe15dae56e075924c637c2410d222f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\програм\fin\Fin\Fin\Views\Home\Post.cshtml"
  
    var base_path = Context.Request.PathBase;

#line default
#line hidden
            BeginContext(69, 119, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"indexcontainer rounded\" style=\"width:100%;\">\r\n    <div class=\"post rounded\"  style=\"width:100%;\">\r\n");
            EndContext();
#line 12 "F:\програм\fin\Fin\Fin\Views\Home\Post.cshtml"
         if (!String.IsNullOrEmpty(Model.Image))
        {

            var image_path = $"{base_path}/Image/{Model.Image}";
        

#line default
#line hidden
            BeginContext(327, 53, true);
            WriteLiteral("            <img class=\"rounded\"  style=\"width:100%;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 380, "\"", 397, 1);
#line 17 "F:\програм\fin\Fin\Fin\Views\Home\Post.cshtml"
WriteAttributeValue("", 386, image_path, 386, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(398, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
            BeginContext(413, 32, true);
            WriteLiteral("            <span class=\"title\">");
            EndContext();
            BeginContext(446, 11, false);
#line 19 "F:\програм\fin\Fin\Fin\Views\Home\Post.cshtml"
                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(457, 10, true);
            WriteLiteral(" </span>\r\n");
            EndContext();
#line 20 "F:\програм\fin\Fin\Fin\Views\Home\Post.cshtml"

        }

#line default
#line hidden
            BeginContext(480, 69, true);
            WriteLiteral("    </div>\r\n    <div class=\"card-body\" style=\"width:100%;\">\r\n        ");
            EndContext();
            BeginContext(550, 20, false);
#line 24 "F:\програм\fin\Fin\Fin\Views\Home\Post.cshtml"
   Write(Html.Raw(Model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(570, 22, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
