#pragma checksum "F:\Code_Projects\BlazorCharts\Pages\DougnutTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e10d7a010f92218fc3a3bee9ff555b9f0710ec25"
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
#line 2 "F:\Code_Projects\BlazorCharts\Pages\DougnutTest.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Code_Projects\BlazorCharts\Pages\DougnutTest.razor"
using ChartJs.Blazor.ChartJS.PieChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Code_Projects\BlazorCharts\Pages\DougnutTest.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Code_Projects\BlazorCharts\Pages\DougnutTest.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/doughnut")]
    public partial class DougnutTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Doughnut Chart</h1>\r\n\r\n");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsPieChart>(1);
            __builder.AddAttribute(2, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.PieChart.PieConfig>(
#nullable restore
#line 9 "F:\Code_Projects\BlazorCharts\Pages\DougnutTest.razor"
                                                  _config

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "F:\Code_Projects\BlazorCharts\Pages\DougnutTest.razor"
                                                                  600

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "F:\Code_Projects\BlazorCharts\Pages\DougnutTest.razor"
                                                                               300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 9 "F:\Code_Projects\BlazorCharts\Pages\DougnutTest.razor"
                       _doughnutChartJs = (ChartJs.Blazor.Charts.ChartJsPieChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "F:\Code_Projects\BlazorCharts\Pages\DougnutTest.razor"
       
    private PieConfig _config;
    private ChartJsPieChart _doughnutChartJs;

    protected override void OnInitialized()
    {
        _config = new PieConfig
        {
            Options = new PieOptions(true)
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

        _config.Data.Labels.AddRange(new[] { "A", "B", "C", "D" });

        var doughnutSet = new PieDataset
        {
            BackgroundColor = new[] { ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString(), ColorUtil.RandomColorString() },
            BorderWidth = 0,
            HoverBackgroundColor = ColorUtil.RandomColorString(),
            HoverBorderColor = ColorUtil.RandomColorString(),
            HoverBorderWidth = 1,
            BorderColor = "#ffffff"
        };

        doughnutSet.Data.AddRange(new double[] { 4, 5, 6, 7 });
        _config.Data.Datasets.Add(doughnutSet);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
