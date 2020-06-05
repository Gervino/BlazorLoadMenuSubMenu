#pragma checksum "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d7b69e4e33916aadae00bd5ce64eec16ee91ef2"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorLoadMenuSubMenu.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\_Imports.razor"
using BlazorLoadMenuSubMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\_Imports.razor"
using BlazorLoadMenuSubMenu.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
using BlazorLoadMenuSubMenu.Data;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>BlazorLoadMenuSubMenu</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 11 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n\r\n");
#nullable restore
#line 30 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
     if(menuList == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "        ");
            __builder.AddMarkupContent(15, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 33 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "        ");
            __builder.OpenElement(17, "ul");
            __builder.AddAttribute(18, "class", "nav flex-column");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 37 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
             foreach(var mn in menuList)
             {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                 if(mn.ParentMenuId == 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                        ");
            __builder.OpenElement(21, "li");
            __builder.AddAttribute(22, "class", "nav-item px-3");
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "nav-link");
            __builder.AddAttribute(26, "href", 
#nullable restore
#line 42 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                                             mn.PageName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                                                                    ()=>GetIsClicked(mn)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(29, "\r\n                                ");
                __builder2.OpenElement(30, "span");
                __builder2.AddAttribute(31, "class", 
#nullable restore
#line 43 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                              mn.IconName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(32, "aria-hidden", "true");
                __builder2.CloseElement();
                __builder2.AddContent(33, " ");
                __builder2.AddContent(34, 
#nullable restore
#line 43 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                                                                       mn.MenuName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "ul");
            __builder.AddAttribute(38, "class", "nav flex-column");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 46 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                 foreach(var mn1 in menuList)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                     if(mn.MenuId == mn1.ParentMenuId)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                         if(expandSubNav && mn.MenuId == clickedMenu)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                                            ");
            __builder.OpenElement(41, "li");
            __builder.AddAttribute(42, "class", "nav-item px-3");
            __builder.AddMarkupContent(43, "\r\n                                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
            __builder.AddAttribute(45, "class", "nav-link");
            __builder.AddAttribute(46, "href", 
#nullable restore
#line 53 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                                                                 mn1.PageName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                                                                                         ()=>GetIsClicked(mn1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(49, "\r\n                                                    ");
                __builder2.OpenElement(50, "span");
                __builder2.AddAttribute(51, "class", 
#nullable restore
#line 54 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                                                  mn1.IconName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(52, "aria-hidden", "true");
                __builder2.CloseElement();
                __builder2.AddContent(53, " ");
                __builder2.AddContent(54, 
#nullable restore
#line 54 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                                                                                            mn1.MenuName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(55, "\r\n                                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 57 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                         
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                                     
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 62 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
                 
             }

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 65 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\kouge\source\repos\Blazor\BlazorLoadMenuSubMenu\BlazorLoadMenuSubMenu\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;
    private bool expandSubNav;
    private int clickedMenu = 0;
    private bool hasPageName = true;
    private int prevClickedMenu = 0;

    public IEnumerable<MenuInfo> menuList;


    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        if (hasPageName)
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }

    public void GetIsClicked(MenuInfo mn)
    {
        clickedMenu = mn.MenuId;
        if(prevClickedMenu != clickedMenu)
        {
            expandSubNav = false;
            if (mn.PageName != "" || mn.MenuName == "Home")
            {
                hasPageName = true;
            }
            else
            {
                expandSubNav = !expandSubNav;
                hasPageName = false;

            }
        }
        else
        {
            expandSubNav = !expandSubNav;
        }
        prevClickedMenu = clickedMenu;
    }

    protected override async Task OnInitializedAsync()
    {
        menuList = await MenuService.GetMenuData();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MenuService MenuService { get; set; }
    }
}
#pragma warning restore 1591