// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 7 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\Pages\Auth\Register.razor"
using Reservations.Client.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\Pages\Auth\Register.razor"
using Reservations.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\msosa\source\repos\ReservationsSystem\Src\Reservations\Client\Pages\Auth\Register.razor"
       
    private UserInfo userInfo = new UserInfo();

    private async Task CreateUser()
    {
        var result = await http.PostJsonAsync<UserToken>("api/auth/createUser", userInfo);
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
#pragma warning restore 1591
