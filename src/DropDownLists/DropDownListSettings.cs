using System;
using System.Web;
using System.Web.Mvc;

namespace MvcExtensions.DropDowns
{
    public class DropDownListSettings : IModelMetadataAdditionalSetting
    {
        public Func<HtmlHelper, IHtmlString> Action { get; set; }
    }
}