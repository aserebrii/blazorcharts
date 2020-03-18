#pragma checksum "F:\Code_Projects\BlazorCharts\Pages\ChartTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "203a3787b69698685501fb79a276410cf399a627"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCharts.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Code_Projects\BlazorCharts\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Code_Projects\BlazorCharts\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Code_Projects\BlazorCharts\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Code_Projects\BlazorCharts\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Code_Projects\BlazorCharts\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Code_Projects\BlazorCharts\_Imports.razor"
using BlazorCharts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Code_Projects\BlazorCharts\_Imports.razor"
using BlazorCharts.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Code_Projects\BlazorCharts\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Code_Projects\BlazorCharts\Pages\ChartTest.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Code_Projects\BlazorCharts\Pages\ChartTest.razor"
using ChartJs.Blazor.ChartJS.PieChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Code_Projects\BlazorCharts\Pages\ChartTest.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Code_Projects\BlazorCharts\Pages\ChartTest.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MyPieChart")]
    public partial class ChartTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "btn btn-primary");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "F:\Code_Projects\BlazorCharts\Pages\ChartTest.razor"
                                          NavigateToDoughnut

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "Go To Doughnut");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsPieChart>(5);
            __builder.AddAttribute(6, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.PieChart.PieConfig>(
#nullable restore
#line 9 "F:\Code_Projects\BlazorCharts\Pages\ChartTest.razor"
                                             _config

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "F:\Code_Projects\BlazorCharts\Pages\ChartTest.razor"
                                                             600

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "F:\Code_Projects\BlazorCharts\Pages\ChartTest.razor"
                                                                          300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(9, (__value) => {
#nullable restore
#line 9 "F:\Code_Projects\BlazorCharts\Pages\ChartTest.razor"
                       _pieChartJs = (ChartJs.Blazor.Charts.ChartJsPieChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "F:\Code_Projects\BlazorCharts\Pages\ChartTest.razor"
      
private PieConfig _config;
    private ChartJsPieChart _pieChartJs;

    protected override void OnInitialized()
    {
        _config = new PieConfig
        {
            Options = new PieOptions
            {
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Sample chart from Blazor"
                },
                Responsive = true,
                Animation = new ArcAnimation
                {
                    AnimateRotate = true,
                    AnimateScale = true
                }
            }
        };

        _config.Data.Labels.AddRange(new[] {"A", "B", "C", "D"});

        var pieSet = new PieDataset
        {
            BackgroundColor = new[] { ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString() },
            BorderWidth = 0,
            HoverBackgroundColor = ColorUtil.RandomColorString(),
            HoverBorderColor = ColorUtil.RandomColorString(),
            HoverBorderWidth = 1,
            BorderColor = "#ffffff",
        };

        pieSet.Data.AddRange(new double[] {4, 5, 6, 7});
        _config.Data.Datasets.Add(pieSet);
    }
    private void NavigateToDoughnut()
    {
        NavigationManager.NavigateTo("doughnut");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
