#pragma checksum "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\Pages\DeleteContact.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1786115b2cb1a7af9fb5c01fef0471fce01a0df9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\_Imports.razor"
using BlazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\_Imports.razor"
using BlazorCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\_Imports.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\Pages\DeleteContact.razor"
using BlazorCRUD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deletecontact/{CurrentID}")]
    public partial class DeleteContact : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DeleteContact</h3>\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h4>\r\n    Are you sure you want to delete this?\r\n</h4>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-4");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "class", "btn btn-danger");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\Pages\DeleteContact.razor"
                                                                   DeleteContacts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "value", "Yes");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\Pages\DeleteContact.razor"
                                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "value", "No");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\Pages\DeleteContact.razor"
       
    Contact objContact = new Contact();
    [Parameter]
    public Guid CurrentID { get; set; }

    protected override async Task OnInitializedAsync()
    {
        objContact = await Task.Run(() => objContactLists.GetContactsById(CurrentID));
    }

    protected void DeleteContacts()
    {
        objContactLists.DeleteContact(objContact);
        NavigationManager.NavigateTo("Contacts");

    }

    void Cancel()
    {
        NavigationManager.NavigateTo("Contacts");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactLists objContactLists { get; set; }
    }
}
#pragma warning restore 1591
