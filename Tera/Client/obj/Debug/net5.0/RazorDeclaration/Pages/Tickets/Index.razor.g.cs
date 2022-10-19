// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tera.Client.Pages.Tickets
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using Tera.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using Tera.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Index.razor"
using Tera.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tickets")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Index.razor"
       
    private List<Ticket> Tickets = new List<Ticket>();
    private List<User> Users = new List<User>();

    private User User { get; set; } = new User();
    private Ticket Ticket { get; set; } = new Ticket();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Tickets = await Http.GetFromJsonAsync<List<Ticket>>("/api/Tickets");
            Users = await Http.GetFromJsonAsync<List<User>>("/api/Users");

            User = await Http.GetFromJsonAsync<User>($"/api/Users/{Ticket.UserId}");
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
        catch (Exception e)
        {
            Console.WriteLine("Ticket index page exception caught: " + e);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
