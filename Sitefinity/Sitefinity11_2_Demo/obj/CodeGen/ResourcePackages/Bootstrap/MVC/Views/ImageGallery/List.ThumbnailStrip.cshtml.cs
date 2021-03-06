#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.ImageGallery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    #line 10 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    
    #line 4 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using System.Web.Script.Serialization;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 5 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery;
    
    #line default
    #line hidden
    
    #line 7 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 8 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 9 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap/MVC/Views/ImageGallery/List.ThumbnailStrip.cshtml")]
    public partial class List_ThumbnailStrip : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_ThumbnailStrip()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 13 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 14 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/ImageGallery/thumbnail-strip.js"), "bottom", true));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 16 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
  
    bool hasItems = Model.Items.Count() > 0;
    bool isBackendDesignMode = SystemManager.IsDesignMode && !SystemManager.IsPreviewMode;
    dynamic firstItem = null;

    if (hasItems && isBackendDesignMode)
    {
        firstItem = Model.Items.FirstOrDefault();
    }

    ThumbnailViewModel thumbnailViewModel = (ThumbnailViewModel)firstItem;

            
            #line default
            #line hidden
WriteLiteral("\n\n<div");

WriteLiteral(" class=\"sf-Gallery sf-Gallery--strip\"");

WriteLiteral(">\n\n");

            
            #line 31 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
 if (hasItems)
{
		if (isBackendDesignMode)
		{

            
            #line default
            #line hidden
WriteLiteral("\t<h2");

WriteLiteral(" class=\"js-Gallery-title\"");

WriteLiteral(">");

            
            #line 35 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                            Write(firstItem.DataItem.Title);

            
            #line default
            #line hidden
WriteLiteral("</h2>\n");

            
            #line 36 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<p");

WriteLiteral(" class=\"js-Gallery-description\"");

WriteLiteral(">");

            
            #line 37 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                 Write(firstItem.DataItem.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");

            
            #line 38 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<div><span");

WriteLiteral(" class=\"js-Gallery-index\"");

WriteLiteral(">1</span> of ");

            
            #line 39 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                               Write(Model.Items.Count());

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 40 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<p");

WriteLiteral(" class=\"sf-Gallery-image js-Gallery-image\"");

WriteLiteral(">\n\t\t<a");

WriteLiteral(" class=\'js-Gallery-prev sf-Gallery-prev\'");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-chevron-left\"");

WriteLiteral("></span></a>\n\t\t<a");

WriteLiteral(" class=\'js-Gallery-next sf-Gallery-next\'");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-chevron-right\"");

WriteLiteral("></span></a>\n        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1516), Tuple.Create("\"", 1552)
            
            #line 44 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 1522), Tuple.Create<System.Object, System.Int32>(thumbnailViewModel.MediaUrl
            
            #line default
            #line hidden
, 1522), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 1553), Tuple.Create("\"", 1586)
            
            #line 44 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 1561), Tuple.Create<System.Object, System.Int32>(firstItem.DataItem.Title
            
            #line default
            #line hidden
, 1561), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 1587), Tuple.Create("\"", 1628)
            
            #line 44 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
         , Tuple.Create(Tuple.Create("", 1593), Tuple.Create<System.Object, System.Int32>(firstItem.DataItem.AlternativeText
            
            #line default
            #line hidden
, 1593), false)
);

WriteLiteral(" \n                  ");

            
            #line 45 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
             Write(Html.GetWidthAttributeIfExists(thumbnailViewModel.Width));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                  ");

            
            #line 46 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
             Write(Html.GetHeightAttributeIfExists(thumbnailViewModel.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\n\n\t</p>\n");

            
            #line 49 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
		}
		else
		{

            
            #line default
            #line hidden
WriteLiteral("\t<h2");

WriteLiteral(" class=\"js-Gallery-title\"");

WriteLiteral("></h2>\n");

            
            #line 53 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<p");

WriteLiteral(" class=\"js-Gallery-description\"");

WriteLiteral("></p>\n");

            
            #line 55 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<div><span");

WriteLiteral(" class=\"js-Gallery-index\"");

WriteLiteral("></span> of ");

            
            #line 56 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                              Write(Model.Items.Count());

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 57 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"


            
            #line default
            #line hidden
WriteLiteral("\t<p");

WriteLiteral(" class=\"sf-Gallery-image js-Gallery-image\"");

WriteLiteral(">\n\t\t<a");

WriteLiteral(" class=\'js-Gallery-prev sf-Gallery-prev\'");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-chevron-left\"");

WriteLiteral("></span></a>\n\t\t<a");

WriteLiteral(" class=\'js-Gallery-next sf-Gallery-next\'");

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-chevron-right\"");

WriteLiteral("></span></a>\n\t\t<img />\n\t</p>\n");

            
            #line 63 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
	}
}

            
            #line default
            #line hidden
WriteLiteral("\n\n\n\t<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container\"");

WriteLiteral(">\n\t\t<div");

WriteLiteral(" class=\"sf-Gallery-thumbs js-Gallery-thumbs\"");

WriteLiteral(">\n");

            
            #line 70 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
		
            
            #line default
            #line hidden
            
            #line 70 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
          int itemIndex = 0;
            
            #line default
            #line hidden
WriteLiteral("\n");

            
            #line 71 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
		
            
            #line default
            #line hidden
            
            #line 71 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
         foreach(var item in Model.Items)
		{
    var itemViewModel = (ThumbnailViewModel)item;
    

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<a");

WriteLiteral(" class=\"text-center\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2483), Tuple.Create("\"", 2509)
            
            #line 75 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 2491), Tuple.Create<System.Object, System.Int32>(item.Fields.Title
            
            #line default
            #line hidden
, 2491), false)
);

WriteLiteral(" data-item=\"");

            
            #line 75 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                                    Write(Html.GetSerializedImage(item));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-detail-url=\"");

            
            #line 75 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                                                                                                                     Write(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix, itemIndex));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\n        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2704), Tuple.Create("\"", 2739)
            
            #line 76 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 2710), Tuple.Create<System.Object, System.Int32>(itemViewModel.ThumbnailUrl
            
            #line default
            #line hidden
, 2710), false)
);

WriteAttribute("alt", Tuple.Create(" alt=\"", 2740), Tuple.Create("\"", 2774)
            
            #line 76 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
, Tuple.Create(Tuple.Create("", 2746), Tuple.Create<System.Object, System.Int32>(item.Fields.AlternativeText
            
            #line default
            #line hidden
, 2746), false)
);

WriteLiteral(" \n                      ");

            
            #line 77 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                 Write(Html.GetWidthAttributeIfExists(itemViewModel.Width));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                      ");

            
            #line 78 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
                 Write(Html.GetHeightAttributeIfExists(itemViewModel.Height));

            
            #line default
            #line hidden
WriteLiteral(" />\n\t\t\t</a>\n");

            
            #line 80 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
			itemIndex++;
		}

            
            #line default
            #line hidden
WriteLiteral("\t\t</div>\n\t</div>\n</div>\n");

            
            #line 85 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 87 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 92 "..\..\ResourcePackages\Bootstrap\MVC\Views\ImageGallery\List.ThumbnailStrip.cshtml"
         
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
