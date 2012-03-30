using System;
using System.Web;
using System.Web.Mvc;

namespace MvcExtensions.DropDowns
{
    public class RenderPartialSettings : IModelMetadataAdditionalSetting
    {
        public Func<HtmlHelper, IHtmlString> Action { get; set; }
    }
}