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
#line 2 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Auction.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Auction.razor"
using BlazorApp.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Auction.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Auction.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/auctions/{id:int}")]
    public partial class Auction : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 302 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Auction.razor"
       
    [CascadingParameter]
    public Task<AuthenticationState> authenticationState { get; set; }
    ClaimsPrincipal user;
    int userId;
    string navi = "/login";
    bool showImages = false;
    bool showConfirmAuction = false;
    bool showConfirmBuyNow = false;
    int price = 0;
    bool firstRender = true;
    bool notificationFollow = true;
    bool notificationUnFollow = true;
    bool userInfo = true;
    bool message = true;
    [Parameter]
    public int id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        user = (await authenticationState).User;
        if (user.Identity.IsAuthenticated)
        {
            var claims = user.Claims.ToList();
            var Id = claims[0].Value;
            userId = int.Parse(Id);
            service.GetData(id, userId);
        }
        else
        {
            service.GetData(id);
        }
        auctionService.GetTransactions(id);

        if (auctionService.transactions != null)
        {
            price = auctionService.transactions.Price + 1;
        }
        else
        {
            price = service.auction.StartPrice + 1;
        }
    }

    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JsRuntime.InvokeAsync<object>("initializeCarousel");
            firstRender = false;
        }

    }

    void Transaction(int auctionId, int userId, int price, bool type)
    {
        auctionService.AddTransaction(auctionId, userId, price, type);
        if (type == true)
        {
            service.FollowAuction(auctionId, userId, true);
        }
        showConfirmAuction = false;
        showConfirmBuyNow = false;
    }

    private async Task Notification(bool follow)
    {
        if (follow == true)
        {
            notificationFollow = !notificationFollow;
        }
        else
        {
            notificationUnFollow = !notificationUnFollow;
        }
        await Task.Delay(1000);
        notificationFollow = true;
        notificationUnFollow = true;
    }

    async Task Follow(int auctionId, int userId, bool follow) //follow okresla czy followujemy czy unfollowujemy zmieniamy wtedy tresc komunikatu
    {
        service.FollowAuction(auctionId, userId);
        await Notification(follow);

    }

    private void AskAboutProduct(int senderId, int recipientId, int auctionId)
    {
        messageService.AskAboutProduct(senderId,recipientId,auctionId);
        message = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuctionService auctionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DisplayAuctionService service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessagesService messageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
