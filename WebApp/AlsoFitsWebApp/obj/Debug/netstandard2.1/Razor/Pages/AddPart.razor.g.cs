#pragma checksum "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "319439aeab15d21aa7d84427e43f7233ab453552"
// <auto-generated/>
#pragma warning disable 1591
namespace AlsoFitsWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/_Imports.razor"
using AlsoFitsWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/_Imports.razor"
using AlsoFitsWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
using AlsoFits.core.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
using AlsoFits.core.Tools;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addpart")]
    public partial class AddPart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Add a part that fits multiple vehicles</h1>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                  AddPartFormModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                                    HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n");
                __builder2.OpenComponent<Radzen.Blazor.RadzenAutoComplete>(6);
                __builder2.AddAttribute(7, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 13 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                          allParts

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "TextProperty", "FullName");
                __builder2.AddAttribute(9, "Placeholder", "name a part...");
                __builder2.AddAttribute(10, "FilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.StringFilterOperator>(
#nullable restore
#line 13 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                                                                                        StringFilterOperator.Contains

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 13 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                                                                                                                                              FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Style", "margin-bottom: 20px");
                __builder2.AddAttribute(13, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 14 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                                                 args => OnPartCategoryAutocompleteChange(args, "AutoCompletePart")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n\n\n");
                __builder2.OpenComponent<Radzen.Blazor.RadzenAutoComplete>(15);
                __builder2.AddAttribute(16, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 17 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                          allModels

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "Name", "AutoCompleteSourceModel");
                __builder2.AddAttribute(18, "TextProperty", "CompoundName");
                __builder2.AddAttribute(19, "Placeholder", "for a...");
                __builder2.AddAttribute(20, "FilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.StringFilterOperator>(
#nullable restore
#line 17 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                                                                                                                      StringFilterOperator.Contains

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 17 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                                                                                                                                                                            FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "Style", "margin-bottom: 20px");
                __builder2.AddAttribute(23, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 18 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                                                 args => OnSourceModelAutocompleteChange(args, "AutoCompleteSourceModel")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\n\n");
                __builder2.AddMarkupContent(25, "<p>also fits a</p>\n\n");
                __builder2.OpenComponent<Radzen.Blazor.RadzenAutoComplete>(26);
                __builder2.AddAttribute(27, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.IEnumerable>(
#nullable restore
#line 22 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                          allModels

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "Name", "AutoCompleteDestinationModel");
                __builder2.AddAttribute(29, "TextProperty", "CompoundName");
                __builder2.AddAttribute(30, "Placeholder", "find a model");
                __builder2.AddAttribute(31, "FilterOperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.StringFilterOperator>(
#nullable restore
#line 22 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                                                                                                                               StringFilterOperator.Contains

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 22 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                                                                                                                                                                                     FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Style", "margin-bottom: 20px");
                __builder2.AddAttribute(34, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 23 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                                                 args => OnDestinationModelAutocompleteChange(args, "AutoCompleteDestinationModel")

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\n\n<br>\n");
                __builder2.OpenElement(36, "label");
                __builder2.AddMarkupContent(37, "any helpful additional notes we can use?\n");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "id", "description");
                __builder2.AddAttribute(40, "placeholder", "description");
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                         AddPartFormModel.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddPartFormModel.Description = __value, AddPartFormModel.Description))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AddPartFormModel.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\n<br>\n");
                __builder2.OpenElement(46, "label");
                __builder2.AddMarkupContent(47, "Part number 1\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "id", "partnumber1");
                __builder2.AddAttribute(50, "placeholder", "e.g 219-323-00-91A");
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                             AddPartFormModel.PartNumber1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddPartFormModel.PartNumber1 = __value, AddPartFormModel.PartNumber1))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AddPartFormModel.PartNumber1));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\n\n<br>\n");
                __builder2.OpenElement(56, "label");
                __builder2.AddMarkupContent(57, "Part number 2 (optional)\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "id", "partnumber2");
                __builder2.AddAttribute(60, "placeholder", "e.g 219-323-00-91A");
                __builder2.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                             AddPartFormModel.PartNumber2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddPartFormModel.PartNumber2 = __value, AddPartFormModel.PartNumber2))));
                __builder2.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AddPartFormModel.PartNumber2));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\n\n<br>\n");
                __builder2.OpenElement(66, "label");
                __builder2.AddMarkupContent(67, "Part number 3 (optional)\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(68);
                __builder2.AddAttribute(69, "id", "partnumber3");
                __builder2.AddAttribute(70, "placeholder", "e.g 219-323-00-91A");
                __builder2.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                             AddPartFormModel.PartNumber3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddPartFormModel.PartNumber3 = __value, AddPartFormModel.PartNumber3))));
                __builder2.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AddPartFormModel.PartNumber3));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\n\n\n<br>\n");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(76);
                __builder2.AddAttribute(77, "id", "pdpurl");
                __builder2.AddAttribute(78, "placeholder", "link to part");
                __builder2.AddAttribute(79, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                    AddPartFormModel.PdpUrl

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddPartFormModel.PdpUrl = __value, AddPartFormModel.PdpUrl))));
                __builder2.AddAttribute(81, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AddPartFormModel.PdpUrl));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\n\n\n<br>\n");
                __builder2.OpenElement(83, "label");
                __builder2.AddMarkupContent(84, "Currency\n    ");
                __Blazor.AlsoFitsWebApp.Pages.AddPart.TypeInference.CreateInputSelect_0(__builder2, 85, 86, 
#nullable restore
#line 54 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                              AddPartFormModel.CurrencySymbol

#line default
#line hidden
#nullable disable
                , 87, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddPartFormModel.CurrencySymbol = __value, AddPartFormModel.CurrencySymbol)), 88, () => AddPartFormModel.CurrencySymbol, 89, (__builder3) => {
                    __builder3.AddMarkupContent(90, "\n                ");
                    __builder3.AddMarkupContent(91, "<option value=\"£\">£</option>\n                ");
                    __builder3.AddMarkupContent(92, "<option value=\"$\">$</option>\n                ");
                    __builder3.AddMarkupContent(93, "<option value=\"€\">€</option>\n            ");
                }
                );
                __builder2.AddMarkupContent(94, "\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\n\n");
                __builder2.OpenElement(96, "label");
                __builder2.AddMarkupContent(97, "Typical price\n");
                __Blazor.AlsoFitsWebApp.Pages.AddPart.TypeInference.CreateInputNumber_1(__builder2, 98, 99, "price", 100, "9.99", 101, 
#nullable restore
#line 63 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                     AddPartFormModel.Price

#line default
#line hidden
#nullable disable
                , 102, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AddPartFormModel.Price = __value, AddPartFormModel.Price)), 103, () => AddPartFormModel.Price);
                __builder2.AddMarkupContent(104, "\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\n\n<br>\n");
                __builder2.OpenElement(106, "button");
                __builder2.AddAttribute(107, "type", "submit");
                __builder2.AddAttribute(108, "class", "btn btn-primary");
                __builder2.AddAttribute(109, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
                                                        SaveAlsofits

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(110, "Save");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\n\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "/home/phil/Dev/alsofits/WebApp/AlsoFitsWebApp/Pages/AddPart.razor"
       
    private PartCategoryChild[] allParts;
    private Model[] allModels;

    public AddPartFormModel AddPartFormModel { get; set; } = new AddPartFormModel();

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine($"Connecting to {Configuration["apiHostUri"]}");
        
        
        //load all parts
        allParts = await Http.GetFromJsonAsync<PartCategoryChild[]>($"{Configuration["apiHostUri"]}/PartsCategory/all");


        //load all models
        allModels = await Http.GetFromJsonAsync<Model[]>($"{Configuration["apiHostUri"]}/Model/all");
    }

    public void OnPartCategoryAutocompleteChange(object value, string name)
    {
        Console.WriteLine(value);
        AddPartFormModel.PartCategory = value.ToString();
    }


    public void OnSourceModelAutocompleteChange(object value, string name)
    {
        AddPartFormModel.SourceModel = value.ToString();
    }

    public void OnDestinationModelAutocompleteChange(object value, string name)
    {
        AddPartFormModel.DestinationModel = value.ToString();
        
    }
    public void SaveAlsofits()
    {
        var debugModel = AddPartFormModel.PropertyList();

        Console.WriteLine(debugModel);
    }

    public void HandleValidSubmit()
    {

    }






#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration Configuration { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.AlsoFitsWebApp.Pages.AddPart
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
