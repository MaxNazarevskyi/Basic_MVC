#pragma checksum "D:\Projects\NG_NazarevskyiMax_2022\.Net Basic MVC\Basic_MVC\Basic_MVC\Views\Login\Check.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce731db48846c263267fc17f662ae076024ee9eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Check), @"mvc.1.0.view", @"/Views/Login/Check.cshtml")]
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
#line 1 "D:\Projects\NG_NazarevskyiMax_2022\.Net Basic MVC\Basic_MVC\Basic_MVC\Views\_ViewImports.cshtml"
using Basic_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\NG_NazarevskyiMax_2022\.Net Basic MVC\Basic_MVC\Basic_MVC\Views\_ViewImports.cshtml"
using Basic_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce731db48846c263267fc17f662ae076024ee9eb", @"/Views/Login/Check.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3284a3540b4bb36e520d427b08aaeb33abcf0d81", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Login_Check : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Basic_MVC.Models.LoginModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\NG_NazarevskyiMax_2022\.Net Basic MVC\Basic_MVC\Basic_MVC\Views\Login\Check.cshtml"
  
	ViewData["title"] = "Check";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n\t<h1 class=\"display-4\">Welcome ");
#nullable restore
#line 9 "D:\Projects\NG_NazarevskyiMax_2022\.Net Basic MVC\Basic_MVC\Basic_MVC\Views\Login\Check.cshtml"
                             Write(Model.login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 10 "D:\Projects\NG_NazarevskyiMax_2022\.Net Basic MVC\Basic_MVC\Basic_MVC\Views\Login\Check.cshtml"
     if (@Model.admin)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<p>You are admin</p>\r\n");
#nullable restore
#line 13 "D:\Projects\NG_NazarevskyiMax_2022\.Net Basic MVC\Basic_MVC\Basic_MVC\Views\Login\Check.cshtml"
	}
	else
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<p>You are user</p>\r\n");
#nullable restore
#line 17 "D:\Projects\NG_NazarevskyiMax_2022\.Net Basic MVC\Basic_MVC\Basic_MVC\Views\Login\Check.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Basic_MVC.Models.LoginModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
