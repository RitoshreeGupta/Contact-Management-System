// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\Pages\AddContact.razor"
using BlazorCRUD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddContact")]
    public partial class AddContact : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Ritos\Desktop\GitHub\Contact-Management-System\CMS\BlazorCRUD\Pages\AddContact.razor"
           
        Contact objContact = new Contact();


        protected void CreateContact()
        {
            objContactLists.Create(objContact);
            NavigationManager.NavigateTo("Contacts");

        }

        void Cancel()
        {
            NavigationManager.NavigateTo("Contacts");
        }

        private void HandleValidSubmit()
        {
            CreateContact();

        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ContactLists objContactLists { get; set; }
    }
}
#pragma warning restore 1591
