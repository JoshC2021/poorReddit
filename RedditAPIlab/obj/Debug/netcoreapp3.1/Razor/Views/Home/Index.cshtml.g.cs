#pragma checksum "C:\Users\Josh\source\repos\RedditAPIlab\RedditAPIlab\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a657155e84ac463fcb362e68c2b8fdd83143017"
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
#line 1 "C:\Users\Josh\source\repos\RedditAPIlab\RedditAPIlab\Views\_ViewImports.cshtml"
using RedditAPIlab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Josh\source\repos\RedditAPIlab\RedditAPIlab\Views\_ViewImports.cshtml"
using RedditAPIlab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a657155e84ac463fcb362e68c2b8fdd83143017", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bc040556c046fbb84aefec5248edac720a476ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TrimmedPoorSub>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Josh\source\repos\RedditAPIlab\RedditAPIlab\Views\Home\Index.cshtml"
   
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Josh\source\repos\RedditAPIlab\RedditAPIlab\Views\Home\Index.cshtml"
 foreach(TrimmedPoorSub tp in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Title:  ");
#nullable restore
#line 8 "C:\Users\Josh\source\repos\RedditAPIlab\RedditAPIlab\Views\Home\Index.cshtml"
           Write(tp.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 140, "\"", 158, 1);
#nullable restore
#line 9 "C:\Users\Josh\source\repos\RedditAPIlab\RedditAPIlab\Views\Home\Index.cshtml"
WriteAttributeValue("", 146, tp.ImageUrl, 146, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"No Img\" width=\"100\" height=\"100\"/>\r\n    <br/>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 218, "\"", 233, 1);
#nullable restore
#line 11 "C:\Users\Josh\source\repos\RedditAPIlab\RedditAPIlab\Views\Home\Index.cshtml"
WriteAttributeValue("", 225, tp.Link, 225, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Link</a>\r\n    <br/><br/>\r\n");
#nullable restore
#line 13 "C:\Users\Josh\source\repos\RedditAPIlab\RedditAPIlab\Views\Home\Index.cshtml"
    count++;
    if(count >= 10)
    {
        break;
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TrimmedPoorSub>> Html { get; private set; }
    }
}
#pragma warning restore 1591