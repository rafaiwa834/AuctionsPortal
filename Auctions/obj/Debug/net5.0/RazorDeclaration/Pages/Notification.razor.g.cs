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
#line 6 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

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
#line 11 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Notification.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Notification.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/notifications/{id:int}")]
    public partial class Notification : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Notification.razor"
       
    [Parameter]
    public int id { get; set; }
    [CascadingParameter]
    public Task<AuthenticationState> authenticationState { get; set; }
    ClaimsPrincipal user;
    int userId = 0;
    string message;
    bool notificationSendMessage = true;

    protected override async Task OnInitializedAsync()
    {
        user = (await authenticationState).User;
        if (user.Identity.IsAuthenticated)
        {
            var claims = user.Claims.ToList();
            var Id = claims[0].Value;
            userId = int.Parse(Id);
            messagesService.GetConversation(id,userId);

        }
        else
        {
            messagesService.GetConversation(id, 1011);
        }
    }


    async Task SendMessage()
    {
        notificationSendMessage = false;
        messagesService.SendMessage(userId, message);
        message = "";
        await Task.Delay(1500);
        notificationSendMessage = true;
        messagesService.GetConversation(id, userId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessagesService messagesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591