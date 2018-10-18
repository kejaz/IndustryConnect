using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleTestApp
{
    public static class CustomeHelper  
    {
        public static IHtmlString Image(this HtmlHelper html, string src, string alt)
        {
            TagBuilder tb = new TagBuilder("img");
            tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute(src));
            tb.Attributes.Add("alt", alt);
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }
        public static IHtmlString MyButton(this HtmlHelper html, string val)
        {
            TagBuilder tb = new TagBuilder("button");
            tb.Attributes.Add("class", "btn btn-info");
            tb.InnerHtml = val;
            return new MvcHtmlString(tb.ToString(TagRenderMode.Normal));
        }
        public static IHtmlString MyTextBox(this HtmlHelper html)
        {
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("style", "backgroundcolor:gray;color:red");
            return new MvcHtmlString(tb.ToString(TagRenderMode.Normal));
        }
    }
}