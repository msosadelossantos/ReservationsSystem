#pragma checksum "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\Pages\Auth\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a8352ebc4138a0a30eb7e11da3d4def37429325"
// <auto-generated/>
#pragma warning disable 1591
namespace Reservations.Client.Pages.Auth
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\_Imports.razor"
using Reservations.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\_Imports.razor"
using Reservations.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\Pages\Auth\Login.razor"
using Reservations.Client.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\Pages\Auth\Login.razor"
using Reservations.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\Pages\Auth\Login.razor"
                 userInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\Pages\Auth\Login.razor"
                                          LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-field");
                __builder2.AddMarkupContent(9, "<label>Name:</label>\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "Class", "form-control");
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\Pages\Auth\Login.razor"
                                                          userInfo.UserCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userInfo.UserCode = __value, userInfo.UserCode))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userInfo.UserCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __Blazor.Reservations.Client.Pages.Auth.Login.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 18 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\Pages\Auth\Login.razor"
                                      () => userInfo.UserCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-field");
                __builder2.AddMarkupContent(22, "<label>Password:</label>\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.OpenComponent<Reservations.Client.Shared.InputPassword>(24);
                __builder2.AddAttribute(25, "Class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\Pages\Auth\Login.razor"
                                                              userInfo.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userInfo.Password = __value, userInfo.Password))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userInfo.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __Blazor.Reservations.Client.Pages.Auth.Login.TypeInference.CreateValidationMessage_1(__builder2, 30, 31, 
#nullable restore
#line 25 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\Pages\Auth\Login.razor"
                                      () => userInfo.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n   \r\n    ");
                __builder2.AddMarkupContent(33, "<button type=\"submit\" class=\"btn btn-primary\">Login</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.AddMarkupContent(35, "<a href=\"Register\" class=\"nav-link btn btn-link\">Registera new account</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\Pages\Auth\Login.razor"
       
    private UserInfo userInfo = new UserInfo();

    private async Task LoginUser()
    {
        var result = await http.PostJsonAsync<UserToken>("api/auth/login", userInfo);
        await loginService.Login(result.Token);
        uriHelper.NavigateTo("index");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.Reservations.Client.Pages.Auth.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
