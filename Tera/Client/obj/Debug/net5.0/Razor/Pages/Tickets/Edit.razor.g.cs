#pragma checksum "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5c61f832124c72a46a0745e555c911ebd22b62c"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Edit.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tickets/edit/{Id:guid}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Edit Ticket</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Edit.razor"
                 Ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Edit.razor"
                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "shadow-sm p-3 mt-3 ml-3 mr-3 mb-3 bg-white rounded-lg mx-auto");
                __builder2.AddAttribute(9, "style", "width:75%");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "card-body mx-auto");
                __builder2.AddAttribute(12, "style", "width:72%; min-width:55%");
                __builder2.AddMarkupContent(13, "<h3 class=\"card-title\">Edit ticket details</h3>\r\n            ");
                __builder2.AddMarkupContent(14, "<h6 class=\"card-subtitle mb-2 text-muted\">Modify values of a ticket</h6>\r\n            <br>\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "<label class=\"control-label\">Ticket Name</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Edit.razor"
                                        Ticket.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Ticket.Name = __value, Ticket.Name))));
                __builder2.AddAttribute(22, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Ticket.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __Blazor.Tera.Client.Pages.Tickets.Edit.TypeInference.CreateValidationMessage_0(__builder2, 24, 25, 
#nullable restore
#line 23 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Edit.razor"
                                          () => Ticket.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "<label class=\"control-label\">Ticket Description</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Edit.razor"
                                        Ticket.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Ticket.Description = __value, Ticket.Description))));
                __builder2.AddAttribute(34, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Ticket.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                ");
                __Blazor.Tera.Client.Pages.Tickets.Edit.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 29 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Edit.razor"
                                          () => Ticket.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "<label for=\"statusInput\">Status</label>\r\n                ");
                __Blazor.Tera.Client.Pages.Tickets.Edit.TypeInference.CreateInputSelect_2(__builder2, 42, 43, "form-control", 44, "statusInput", 45, 
#nullable restore
#line 34 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Edit.razor"
                                                                                Ticket.TicketStatus

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Ticket.TicketStatus = __value, Ticket.TicketStatus)), 47, () => Ticket.TicketStatus, 48, (__builder3) => {
                    __builder3.AddMarkupContent(49, "<option disabled value=\"Select\">Select status</option>\r\n                        ");
                    __builder3.AddMarkupContent(50, "<option value=\"Open\">Open</option>\r\n                        ");
                    __builder3.AddMarkupContent(51, "<option value=\"In Progress\">In Progress</option>\r\n                        ");
                    __builder3.AddMarkupContent(52, "<option value=\"Testing\">Testing</option>\r\n                        ");
                    __builder3.AddMarkupContent(53, "<option value=\"Closed\">Closed</option>");
#nullable restore
#line 42 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Edit.razor"


                        if (Ticket.TicketStatus == "Closed")
                        {
                            Ticket.ClosedDate = DateTime.Today;
                        }
                        else
                        {
                            Ticket.ClosedDate = null;
                        }

                    

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n            ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "<label class=\"control-label\">Created on</label>\r\n                ");
                __Blazor.Tera.Client.Pages.Tickets.Edit.TypeInference.CreateInputDate_3(__builder2, 58, 59, "form-control", 60, 
#nullable restore
#line 59 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Edit.razor"
                                        Ticket.TicketCreatedDate

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Ticket.TicketCreatedDate = __value, Ticket.TicketCreatedDate)), 62, () => Ticket.TicketCreatedDate);
                __builder2.AddMarkupContent(63, "\r\n                ");
                __Blazor.Tera.Client.Pages.Tickets.Edit.TypeInference.CreateValidationMessage_4(__builder2, 64, 65, 
#nullable restore
#line 60 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Edit.razor"
                                          () => Ticket.TicketCreatedDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n\r\n            ");
                __builder2.AddMarkupContent(67, "<a class=\"btn btn-secondary ml-2\" href=\"/Tickets\">Back</a>\r\n\r\n            ");
                __builder2.AddMarkupContent(68, "<button type=\"submit\" class=\"btn btn-primary\">\r\n                Update ticket\r\n            </button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\vasko\Desktop\Upload GitHub\EAD\Cw2_w1740051_VasilDzhakov\Tera\Client\Pages\Tickets\Edit.razor"
       
    [Parameter]
    public Guid Id { get; set; }

    private Ticket Ticket { get; set; } = new Ticket();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Ticket = await Http.GetFromJsonAsync<Ticket>($"/api/Tickets/{Id}");
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
            var response = await Http.PutAsJsonAsync($"/api/Tickets/{Ticket.Id}", Ticket);
            response.EnsureSuccessStatusCode();
            Navigation.NavigateTo("/tickets");
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Tera.Client.Pages.Tickets.Edit
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
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
