#pragma checksum "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "001671da9b5148c39a7127cf558d946f7360b081"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_Details), @"mvc.1.0.view", @"/Templates/ViewGenerator/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"001671da9b5148c39a7127cf558d946f7360b081", @"/Templates/ViewGenerator/Details.cshtml")]
    public class Templates_ViewGenerator_Details : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@model ");
#nullable restore
#line 5 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
   Write(Model.ViewDataTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
  
    if (Model.IsPartialView)
    {
    }
    else if (Model.IsLayoutPageSelected)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@{\r\n    ");
            WriteLiteral("ViewData[\"Title\"] = \"");
#nullable restore
#line 14 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
                      Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 15 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 17 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
           Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 18 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<h1>");
#nullable restore
#line 21 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
 Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 23 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@{\r\n    ");
            WriteLiteral("Layout = null;\r\n");
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<html>\r\n");
            WriteLiteral("<head>\r\n    ");
            WriteLiteral("<meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
            WriteLiteral("<title>");
#nullable restore
#line 35 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
        Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
            WriteLiteral("</head>\r\n");
            WriteLiteral("<body>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 39 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
        //    PushIndent("    ");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h4>");
#nullable restore
#line 43 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
   Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
#nullable restore
#line 46 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
  
    Dictionary<string, IPropertyMetadata> propertyLookup = ((IModelMetadata)Model.ModelMetadata).Properties.ToDictionary(x => x.PropertyName, x => x);
    Dictionary<string, INavigationMetadata> navigationLookup = ((IModelMetadata)Model.ModelMetadata).Navigations.ToDictionary(x => x.AssociationPropertyName, x => x);

    foreach (var item in Model.ModelMetadata.ModelType.GetProperties())
    {
        if (propertyLookup.TryGetValue(item.Name, out IPropertyMetadata property)
            && property.Scaffold && !property.IsForeignKey && !property.IsPrimaryKey)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 56 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
                                            Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            WriteLiteral("@Html.DisplayFor(model => model.");
#nullable restore
#line 59 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
                                        Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dd>\r\n");
#nullable restore
#line 61 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
        }
        else if (navigationLookup.TryGetValue(item.Name, out INavigationMetadata navigation))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 65 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
                                            Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            WriteLiteral("@Html.DisplayFor(model => model.");
#nullable restore
#line 68 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
                                        Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 68 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
                                                                        Write(navigation.DisplayPropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dd>\r\n");
#nullable restore
#line 70 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 75 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
  
    string pkName = GetPrimaryKeyName();
    if (pkName != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("<a asp-action=\"Edit\" asp-route-id=\"");
            WriteLiteral("@Model.");
#nullable restore
#line 79 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
                                            Write(pkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Edit</a> |\r\n    ");
            WriteLiteral("<a asp-action=\"Index\">Back to List</a>\r\n");
#nullable restore
#line 81 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("@Html.ActionLink(\"Edit\", \"Edit\", new { /* id = Model.PrimaryKey */ }) |\r\n    ");
            WriteLiteral("<a asp-action=\"Index\">Back to List</a>\r\n");
#nullable restore
#line 86 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 88 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
  
    if (!Model.IsPartialView && !Model.IsLayoutPageSelected)
    {
        //ClearIndent();

#line default
#line hidden
#nullable disable
            WriteLiteral("</body>\r\n");
            WriteLiteral("</html>\r\n");
#nullable restore
#line 94 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "/home/sartur/Documentos/Estudo de C#/Web API/UserApi/Templates/ViewGenerator/Details.cshtml"
 
    string GetPrimaryKeyName()
    {
        return (Model.ModelMetadata.PrimaryKeys != null && Model.ModelMetadata.PrimaryKeys.Length == 1)
        ? Model.ModelMetadata.PrimaryKeys[0].PropertyName
        : null;
    }

    string GetValueExpression(IPropertyMetadata property)
    {
        return property.PropertyName;
    }

    string GetValueExpression(INavigationMetadata navigation)
    {
        return navigation.AssociationPropertyName;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
