#pragma checksum "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Users\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "568c7ad0b1e47241a687a050fc290f8d8847c022"
// <auto-generated/>
#pragma warning disable 1591
namespace Tera.Client.Pages.Users
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
#line 12 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\_Imports.razor"
using Tera.Shared;

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
#line 3 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Users\Delete.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Users/delete/{Id:guid}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Users\Delete.razor"
                 User

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Users\Delete.razor"
                                       HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "shadow-sm p-3 mt-3 ml-3 mr-3 mb-3 bg-white rounded-lg mx-auto");
                __builder2.AddAttribute(8, "style", "width:45%");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "card-body mx-auto");
                __builder2.AddAttribute(11, "style", "width:67%; min-width:80%");
                __builder2.AddMarkupContent(12, "<h3>Please confirm you want to delete the following user?</h3>\r\n            <br>\r\n            ");
                __builder2.OpenElement(13, "ul");
                __builder2.AddAttribute(14, "class", "list-group");
                __builder2.OpenElement(15, "li");
                __builder2.AddAttribute(16, "class", "list-group-item d-flex justify-content-between align-items-center");
                __builder2.AddMarkupContent(17, "<h5 class=\"mb-1\">\r\n                        First Name\r\n                    </h5>\r\n\r\n                    ");
                __builder2.OpenElement(18, "h5");
                __builder2.AddAttribute(19, "class", "mb-1");
#nullable restore
#line 26 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Users\Delete.razor"
__builder2.AddContent(20, User.FirstName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\r\n                ");
                __builder2.OpenElement(22, "li");
                __builder2.AddAttribute(23, "class", "list-group-item d-flex justify-content-between align-items-center");
                __builder2.AddMarkupContent(24, "<h5 class=\"mb-1\">\r\n                        Last Name\r\n                    </h5>\r\n\r\n                    ");
                __builder2.OpenElement(25, "h5");
                __builder2.AddAttribute(26, "class", "mb-1");
#nullable restore
#line 36 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Users\Delete.razor"
__builder2.AddContent(27, User.LastName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.OpenElement(29, "li");
                __builder2.AddAttribute(30, "class", "list-group-item d-flex justify-content-between align-items-center");
                __builder2.OpenElement(31, "h5");
                __builder2.AddAttribute(32, "class", "mb-1");
                __builder2.AddMarkupContent(33, "\r\n                        User Email <br>\r\n                        ");
#nullable restore
#line 42 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Users\Delete.razor"
__builder2.AddContent(34, User.Email);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n            <br>\r\n\r\n            ");
                __builder2.AddMarkupContent(36, "<a class=\"btn btn-secondary ml-2\" href=\"/Users\">Back</a>\r\n\r\n            ");
                __builder2.AddMarkupContent(37, "<button type=\"submit\" class=\"btn btn-danger\">\r\n                Delete User\r\n            </button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Users\Delete.razor"
       
    [Parameter]
    public Guid Id { get; set; }

    private User User { get; set; } = new User();

    protected override async Task OnInitializedAsync()
    {
        try
        {

            User = await Http.GetFromJsonAsync<User>($"/api/Users/{Id}");
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

    private async void HandleValidSubmit()
    {
        try
        {
            await Http.DeleteAsync($"/api/Users/{Id}");

            var response = await Http.PutAsJsonAsync($"/api/Users/{Id}", User);
            response.EnsureSuccessStatusCode();

        }

        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }

        catch (Exception e)
        {
            Console.WriteLine("Ticket index page exception caught: " + e);
        }

        Navigation.NavigateTo("/Users"); //after action go back to index page

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
