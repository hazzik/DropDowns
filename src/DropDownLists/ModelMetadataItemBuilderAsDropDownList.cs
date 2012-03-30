using System;
using System.Web;
using System.Web.Mvc;

namespace MvcExtensions.DropDowns
{
    public static class ModelMetadataItemBuilderAsDropDownList
    {
        public static ModelMetadataItemBuilder<TModel> AsDropDownList<TModel>(this ModelMetadataItemBuilder<TModel> builder, Func<HtmlHelper, IHtmlString> action)
        {
            builder.Template("DropDownList");

            var settings = builder.Item.GetAdditionalSettingOrCreateNew<DropDownListSettings>();
            settings.Action = action;

            return builder;
        }
    }
}
