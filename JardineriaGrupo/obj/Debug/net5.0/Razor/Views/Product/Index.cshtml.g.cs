#pragma checksum "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11f97770eef1c08a793db14b6f51767b5934609e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\_ViewImports.cshtml"
using JardineriaGrupo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\_ViewImports.cshtml"
using JardineriaGrupo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11f97770eef1c08a793db14b6f51767b5934609e", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6afd45fdcd76e02a0cd792a8e98491923a671a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<JardineriaGrupo.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 7 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Productos</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f97770eef1c08a793db14b6f51767b5934609e6376", async() => {
                WriteLiteral("Crear nuevo producto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f97770eef1c08a793db14b6f51767b5934609e7547", async() => {
                WriteLiteral("\n        <div>\n            <p>\n                Buscar por Nombre: <input type=\"text\" name=\"buscado\"");
                BeginWriteAttribute("value", "\n                                          value=\"", 385, "\"", 463, 1);
#nullable restore
#line 17 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
WriteAttributeValue("", 435, ViewData["busqueda_actual"], 435, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                <input type=\"submit\" value=\"Buscar\" /> |\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f97770eef1c08a793db14b6f51767b5934609e8469", async() => {
                    WriteLiteral("Limpiar búsqueda");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            </p>\n        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 29 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 32 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().Dimensiones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 35 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().Proveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 38 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 41 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().CantidadEnStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 44 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().PrecioVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 47 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().PrecioProveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 50 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().GamaNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 56 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 60 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 63 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Dimensiones));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 66 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Proveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 69 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 72 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.CantidadEnStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 75 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.PrecioVenta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 78 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.PrecioProveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 81 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.GamaNavigation.Gama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f97770eef1c08a793db14b6f51767b5934609e17145", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
                               WriteLiteral(item.CodigoProducto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f97770eef1c08a793db14b6f51767b5934609e19354", async() => {
                WriteLiteral("Detalles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
                                  WriteLiteral(item.CodigoProducto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f97770eef1c08a793db14b6f51767b5934609e21568", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
                                 WriteLiteral(item.CodigoProducto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 88 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
#nullable restore
#line 91 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
Write(Html.PagedListPager(Model
    , nueva_pagina => Url.Action("Index", "Product"
        , new { nueva_pagina, buscado = (string)null, busqueda_actual = ViewData["busqueda_actual"] })
    , new PagedListRenderOptions
    {
        LiElementClasses = new string[] { "page-item" },
        PageClasses = new string[] { "page-link" }
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 99 "E:\DAW\USB\DSW\TareaEVAGD\ProyectoGrupo\NUEVO_FINAL\JardineriaGrupoActualizado-main\JardineriaGrupo\Views\Product\Index.cshtml"
Write(Html.ActionLink("Volver a inicio", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<JardineriaGrupo.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591