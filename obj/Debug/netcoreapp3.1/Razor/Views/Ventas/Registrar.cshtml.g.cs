#pragma checksum "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adb60c3563e4199ec343cd8a1874381b4b5d5817"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ventas_Registrar), @"mvc.1.0.view", @"/Views/Ventas/Registrar.cshtml")]
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
#line 1 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\_ViewImports.cshtml"
using web_admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\_ViewImports.cshtml"
using web_admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adb60c3563e4199ec343cd8a1874381b4b5d5817", @"/Views/Ventas/Registrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f41aeeca6c0e2e834f45995d46dc994aba869be", @"/Views/_ViewImports.cshtml")]
    public class Views_Ventas_Registrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "idprod", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("min", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Cantidad"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ventas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Productos"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Eliminar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>

<main class=""main col"">
                <div class=""row"">
                    <div class=""columna col-lg-6"">
                        <div class=""widget nueva_entrada"">
                            <h3 class=""titulo"">Centro de Ventas - Luz y Luna</h3>

                        </div>

                        <div class=""columna col-lg-7"">
                            <button type=""button"" class=""btn btn-info"" data-toggle=""collapse"" data-target=""#demo"">Consultar catálogo</button>
                            <div id=""demo"" class=""collapse"">
                                <br>
                            <input type=""text"" class=""form-control"" placeholder=""Escriba el Producto"" name=""cantidad""  id=""search"">
<br>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adb60c3563e4199ec343cd8a1874381b4b5d58178432", async() => {
                WriteLiteral(@"
                                            
                                                <table id=""table"" class=""table table-sm table-hover table-bordered table-responsive-lg table-active"" >
                                                <thead>
                                                    <tr>
                                                    <th></th>
                                                    <th >tipo</th>
                                                    <th >nombre</th>
                                                    <th >precio</th>
                                                    

                                                    </tr>
                                                </thead>
                                                <tbody>
");
#nullable restore
#line 32 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                                                     foreach (var item in (List<Producto>)ViewBag.Prod)
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <tr>  \r\n                                                        <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "adb60c3563e4199ec343cd8a1874381b4b5d58179981", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 35 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.idprod);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                                                                                                          WriteLiteral(item.idprod);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td> \r\n                                                        <td>");
#nullable restore
#line 36 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                                                       Write(item.tipo);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                                        <td>");
#nullable restore
#line 37 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                                                       Write(item.nom);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 38 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                                                       Write(item.precio);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 40 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                    
                                                
                                                </tbody>
                                                </table>
                                                <div class=""row"">
                                                    <div class=""col-md-8"">
                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "adb60c3563e4199ec343cd8a1874381b4b5d581714334", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 47 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.cantidad);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "adb60c3563e4199ec343cd8a1874381b4b5d581716344", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                                                                        WriteLiteral(ViewBag.num);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 48 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.numhab);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "adb60c3563e4199ec343cd8a1874381b4b5d581718796", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                                                                        WriteLiteral(ViewBag.cli);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 49 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.codcli);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                    </div>
                                                    <div class=""col-md-4"">
                                                
                                                    <button class=""btn btn-primary"">Agregar</button>
                                                    </div>
                                                </div>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            
                         
                        </div>
                    </div>



                    <div class=""columna col-lg-5"">
                        <div class=""card"">
                            <div class=""card-header"">
                                Datos de Habitación
                                
                            </div>
                            <div class=""card-body"">
                                <div class=""row mb-3"">
                                    <div class=""col-6"">
                                        <span class=""input-group-text"">N° de Habitación</span>
                                    </div>
                                    <div class=""col-6"">
                                        <input type=""text""");
            BeginWriteAttribute("name", " name=\"", 4554, "\"", 4561, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 4562, "\"", 4567, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"");
            BeginWriteAttribute("value", "  value=\"", 4589, "\"", 4610, 1);
#nullable restore
#line 77 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
WriteAttributeValue("", 4598, ViewBag.num, 4598, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled>
                                    </div>
                                </div>
                                <div class=""row mb-3"">
                                    <div class=""col-6"">
                                        <span class=""input-group-text"">Hora del Pedido</span>
                                    </div>
                                    <div class=""col-6"">
                                        <input type=""text""");
            BeginWriteAttribute("name", " name=\"", 5074, "\"", 5081, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 5082, "\"", 5087, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 5109, "\"", 5130, 1);
#nullable restore
#line 85 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
WriteAttributeValue("", 5117, ViewBag.hora, 5117, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled>
                                    </div>
                                </div>
                                <div class=""row mb-3"">
                                    <div class=""col-6"">
                                        <span class=""input-group-text"">Nombre del Cliente</span>
                                    </div>
                                    <div class=""col-6"">
                                        <input type=""text""");
            BeginWriteAttribute("name", " name=\"", 5597, "\"", 5604, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 5605, "\"", 5610, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 5632, "\"", 5652, 1);
#nullable restore
#line 93 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
WriteAttributeValue("", 5640, ViewBag.nom, 5640, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled>
                                    </div>
                                </div>
                                <div class=""row mb-3"">
                                    <div class=""col-6"">
                                        <span class=""input-group-text"">Importe a Pagar</span>
                                    </div>
                                    <div class=""col-6"">
                                        <input type=""text""");
            BeginWriteAttribute("name", " name=\"", 6116, "\"", 6123, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 6124, "\"", 6129, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 6151, "\"", 6173, 1);
#nullable restore
#line 101 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
WriteAttributeValue("", 6159, ViewBag.monto, 6159, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" disabled>
                                    </div>
                                </div>

                                <div class=""row"">
                                    <p>Estado del Pago:</p>

                                </div>
                                <div class=""row"">
                                    <div class=""form-check"">
                                        <label class=""form-check-label"">
										<input type=""radio"" name=""EstadoPago"" id=""falta"" value=""falta""> Falta Pagar
									</label>
                                    </div>
                                    <div class=""form-check"">
                                        <label class=""form-check-label"">
										<input type=""radio"" name=""EstadoPago"" id=""cancelado"" value=""cancelado""> Cancelado
									</label>
                                    </div>
                                </div>

                            </div>
                            <div class=""row"">
                  ");
            WriteLiteral("              <div class=\"col-md-3\">\r\n                                \r\n                                </div>\r\n                                <div class=\"col-md-6\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adb60c3563e4199ec343cd8a1874381b4b5d581729391", async() => {
                WriteLiteral("<button class=\"btn btn-primary\" >Grabar</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                </div>
                                <div class=""col-md-3"">
                                
                                </div>
                            </div>
                            
                        </div>


                    </div>




                </div>


                <div class=""row mt-5"">
                    <div class=""columna col-lg-8"">
                        <table class=""table table-sm table-hover table-bordered table-responsive-lg table-active"">
                            <div class=""row mb-3"">


                            </div>

");
#nullable restore
#line 155 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                         if(ViewBag.Pedido!=null){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <thead>

                                <tr>
                                    <th>Tipo</th>
                                    <th>Nombre</th>
                                    <th>Cantidad</th>
                                    <th>Precio Venta</th>
                                    <th>Sub Total</th>
                            
                                    <th>Eliminar</th>
                                </tr>
                            </thead>
");
#nullable restore
#line 169 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                             foreach (var item in (List<Pedido>)ViewBag.Pedido)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("class", " class=\"", 8854, "\"", 8862, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 172 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                               Write(item.tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 173 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                               Write(item.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 174 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                               Write(item.cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 175 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                               Write(item.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 176 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                               Write(item.subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adb60c3563e4199ec343cd8a1874381b4b5d581734095", async() => {
                WriteLiteral("<i class=\"icon-logout\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idd", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 177 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                                                                                         WriteLiteral(item.iddetve);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idd"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idd", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idd"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                \r\n                            </tr>    \r\n");
#nullable restore
#line 180 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 180 "D:\Escritorio\HotelLuzyLuna\web_admin\Views\Ventas\Registrar.cshtml"
                             
                            
                        
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </table>
                    </div>
                </div>
            </main>
            <script type=""text/javascript"">
                                        $(""#search"").keyup(function() {
                                _this = this;
                                // Show only matching TR, hide rest of them
                                $.each($(""#table tbody tr""), function() {
                                    if ($(this).text().toLowerCase().indexOf($(_this).val().toLowerCase()) === -1)
                                    $(this).hide();
                                    else
                                    $(this).show();
                                });
                                });
                                    </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pedido> Html { get; private set; }
    }
}
#pragma warning restore 1591