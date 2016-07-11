using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HelpersPersonalizados.Extensions.Helpers
{
    public static class ImageActionLinkHelpers
    {
        public static MvcHtmlString ImageActionLink(
                 this HtmlHelper helper, string action, string imagePath, string altText)
        {
            return ImageActionLink(helper, action, null, null, imagePath, altText);
        }

        public static MvcHtmlString ImageActionLink(
                 this HtmlHelper helper, string action, string controller,
                 object parameters, string imagePath, string altText)
        {

            TagBuilder image = new TagBuilder("img");

            string imgPath = UrlHelper.GenerateContentUrl(imagePath,
                                                  helper.ViewContext.HttpContext);
            image.MergeAttribute("src", imgPath);
            image.MergeAttribute("alt", altText);

            string url = UrlHelper.GenerateUrl(null, action, controller,
                                     new RouteValueDictionary(parameters),
                                     helper.RouteCollection,
                                     helper.ViewContext.RequestContext, true);

            TagBuilder link = new TagBuilder("a");
            link.MergeAttribute("href", url);

            link.InnerHtml = image.ToString(TagRenderMode.SelfClosing);

            return MvcHtmlString.Create(link.ToString());
        }
    }
}