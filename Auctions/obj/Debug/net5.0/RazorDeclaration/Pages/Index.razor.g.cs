// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Index.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Index.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Index.razor"
using BlazorApp.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Index.razor"
      
    Filters filters = new Filters();

    public void UpdateFilters(MouseEventArgs e)
    {
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuctionsDbContext auctionsDbContext { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Hosting.IWebHostEnvironment env { get; set; }
    }
}
#pragma warning restore 1591
