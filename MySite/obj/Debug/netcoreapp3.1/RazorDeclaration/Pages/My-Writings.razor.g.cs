// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MySite.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/_Imports.razor"
using MySite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/_Imports.razor"
using MySite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/Pages/My-Writings.razor"
using MySite.Pages.LandingPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/Pages/My-Writings.razor"
using MySite.Pages.LandingPages.Swipers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/Pages/My-Writings.razor"
using MySite.Pages.LandingPages.Listings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/Pages/My-Writings.razor"
using MySite.AppData;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/My-Writings")]
    public partial class My_Writings : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "/System/Volumes/Data/Previous Content/Data/KhizoOo/Projects/Untitled/Portfolio/MySite/Pages/My-Writings.razor"
       


    MyWritings ArtsOBJ = new MyWritings();

    List<Writing> MyAllWritings = new List<Writing>();


    protected override void OnInitialized()
    {
        this.MyAllWritings = ArtsOBJ.GetMyWritings(100);
    }

    private void Navigate()
    {
        NavigationManager.NavigateTo("/My-Writings/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591