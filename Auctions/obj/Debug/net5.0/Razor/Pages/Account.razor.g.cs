#pragma checksum "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7dc2f3562daeeb1369362c4d762578b0bfbaad2"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
using BlazorApp.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/account")]
    public partial class Account : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, @"<div class=""card-header""><ul class=""nav nav-tabs card-header-tabs""><li class=""nav-item"" style=""color:black""><a class=""nav-link active"" href=""/account"" style=""color:black"">Konto</a></li>
            <li class=""nav-item"" style=""color:black""><a class=""nav-link"" href=""/account/myauctions"" style=""color:black"">Moje Aukcje</a></li>
            <li class=""nav-item"" style=""color:black""><a class=""nav-link"" href=""/account/purchasestory"" style=""color:black"">Historia zakupów</a></li></ul></div>");
#nullable restore
#line 26 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
     if (this.show)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "mb-3 row");
            __builder.AddMarkupContent(7, "<label for=\"staticEmail\" class=\"col-form-label\" style=\"width:150px; text-align:left\">E-mail</label>\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-sm-5");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "id", "staticEmail");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 33 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                                             infoUser.Email

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "readonly");
            __builder.AddAttribute(16, "disabled");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "mb-3 row");
            __builder.AddMarkupContent(20, "<label for=\"staticEmail\" class=\"col-form-label\" style=\"width:150px; text-align:left\">Imie</label>\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-sm-5");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "text");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "id", "staticEmail");
            __builder.AddAttribute(27, "value", 
#nullable restore
#line 40 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                                             infoUser.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "readonly");
            __builder.AddAttribute(29, "disabled");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "mb-3 row");
            __builder.AddMarkupContent(33, "<label for=\"staticEmail\" class=\"col-form-label\" style=\"width:150px; text-align:left\">Nazwisko</label>\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-sm-5");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "id", "staticEmail");
            __builder.AddAttribute(40, "value", 
#nullable restore
#line 47 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                                             infoUser.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "readonly");
            __builder.AddAttribute(42, "disabled");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "mb-3 row");
            __builder.AddMarkupContent(46, "<label for=\"staticEmail\" class=\"col-form-label\" style=\"width:150px; text-align:left\">Data Urodzenia</label>\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-sm-5");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "text");
            __builder.AddAttribute(51, "class", "form-control");
            __builder.AddAttribute(52, "id", "staticEmail");
            __builder.AddAttribute(53, "value", 
#nullable restore
#line 54 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                                             infoUser.DateofBirth.Value.ToString("d")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(54, "readonly");
            __builder.AddAttribute(55, "disabled");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "form-group col-md-6");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "class", "col-sm-3 btn btn-dark");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                            e=>this.show=!this.show

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "style", "margin-top:10px;");
            __builder.AddContent(63, "Edytuj");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(64);
            __builder.AddAttribute(65, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 65 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                 user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 65 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                      Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(68);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(70);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "card-body");
                __builder2.AddMarkupContent(74, "<h5>Edytuj swoje konto</h5>\r\n\r\n        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "mb-3 row");
                __builder2.AddMarkupContent(77, "<label for=\"staticEmail\" class=\"col-form-label\" style=\"width:150px; text-align:left\">E-mail</label>\r\n            ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "col-sm-5");
                __builder2.OpenElement(80, "input");
                __builder2.AddAttribute(81, "type", "text");
                __builder2.AddAttribute(82, "class", "form-control");
                __builder2.AddAttribute(83, "id", "staticEmail");
                __builder2.AddAttribute(84, "placeholder", 
#nullable restore
#line 75 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                                                                                cloneUser.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(85, "readonly");
                __builder2.AddAttribute(86, "disabled");
                __builder2.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                                                 cloneUser.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cloneUser.Email = __value, cloneUser.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n\r\n        ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "mb-3 row");
                __builder2.AddMarkupContent(92, "<label for=\"staticEmail\" class=\"col-form-label\" style=\"width:150px; text-align:left\">Imie</label>\r\n            ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "col-sm-5");
                __builder2.OpenElement(95, "input");
                __builder2.AddAttribute(96, "type", "text");
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "id", "staticEmail");
                __builder2.AddAttribute(99, "placeholder", 
#nullable restore
#line 82 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                                                                                    cloneUser.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(100, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 82 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                                                 cloneUser.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cloneUser.FirstName = __value, cloneUser.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n\r\n        ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "mb-3 row");
                __builder2.AddMarkupContent(105, "<label for=\"staticEmail\" class=\"col-form-label\" style=\"width:150px; text-align:left\">Nazwisko</label>\r\n            ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "col-sm-5");
                __builder2.OpenElement(108, "input");
                __builder2.AddAttribute(109, "type", "text");
                __builder2.AddAttribute(110, "class", "form-control");
                __builder2.AddAttribute(111, "id", "staticEmail");
                __builder2.AddAttribute(112, "placeholder", 
#nullable restore
#line 89 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                                                                                   cloneUser.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(113, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                                                 cloneUser.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cloneUser.LastName = __value, cloneUser.LastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n\r\n        ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "mb-3 row");
                __builder2.AddMarkupContent(118, "<label for=\"staticEmail\" class=\"col-form-label\" style=\"width:150px; text-align:left\">Data Urodzenia</label>\r\n            ");
                __builder2.OpenElement(119, "div");
                __builder2.AddAttribute(120, "class", "col-sm-5");
                __builder2.OpenElement(121, "input");
                __builder2.AddAttribute(122, "type", "text");
                __builder2.AddAttribute(123, "class", "form-control");
                __builder2.AddAttribute(124, "id", "staticEmail");
                __builder2.AddAttribute(125, "placeholder", 
#nullable restore
#line 96 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                                                                                      cloneUser.DateofBirth.Value.ToString("d")

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(126, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 96 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                                                 cloneUser.DateofBirth

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(127, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cloneUser.DateofBirth = __value, cloneUser.DateofBirth));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n\r\n    ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "form-group col-md-6");
                __builder2.OpenElement(131, "button");
                __builder2.AddAttribute(132, "class", "col-sm-3 btn btn-dark");
                __builder2.AddAttribute(133, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 103 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                         Edit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(134, "style", "margin-top:10px; float:left");
                __builder2.AddContent(135, "Zapisz");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(136, "\r\n        ");
            __builder.OpenElement(137, "div");
            __builder.AddAttribute(138, "class", "form-group col-md-6");
            __builder.OpenElement(139, "button");
            __builder.AddAttribute(140, "class", "col-sm-3 btn btn-dark");
            __builder.AddAttribute(141, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 108 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
                                                            CancelEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(142, "style", "margin-top:10px;");
            __builder.AddContent(143, "Anuluj");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 110 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "D:\.Net projekty\Blazor-Portal_Aukcyjny\BlazorAppStaticImages\Pages\Account.razor"
       
    [CascadingParameter]
    public Task<AuthenticationState> authenticationState { get; set; }
    ClaimsPrincipal user;
    User infoUser;
    User cloneUser;

    bool show = true;
    int uID;

    protected override async Task OnInitializedAsync()
    {
        infoUser = new User();
        cloneUser = new User();
        show = true;
        user = (await authenticationState).User;
        if (user.Identity.IsAuthenticated)
        {
            var claims = user.Claims.ToList();
            var Id = claims[0].Value;
            uID = int.Parse(Id);
            infoUser = auctionsDbContext.Users.FirstOrDefault(p => p.Id == int.Parse(Id));
            ChangeValue(infoUser, cloneUser);
        }
    }

    public void Edit()
    {
        ChangeValue(cloneUser, infoUser);
        auctionsDbContext.Update(infoUser);
        auctionsDbContext.SaveChanges();
        show = !show;
    }

    public void CancelEdit()
    {
        ChangeValue(infoUser, cloneUser);
        show = !show;
    }

    public void ChangeValue(User from, User to)
    {
        to.Email = from.Email;
        to.FirstName = from.FirstName;
        to.DateofBirth = from.DateofBirth;
        to.LastName = from.LastName;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuctionsDbContext auctionsDbContext { get; set; }
    }
}
#pragma warning restore 1591
