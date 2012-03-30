using System;
using System.Web;
using System.Web.Mvc;

namespace MvcExtensions.DropDowns
{
    public static class ModelMetadataItemBuilderRenderPartial
    {
        public static ModelMetadataItemBuilder<TModel> RenderPartial<TModel>(this ModelMetadataItemBuilder<TModel> builder, Func<HtmlHelper, IHtmlString> action)
        {
            builder.Template("RenderPartial");

            var settings = builder.Item.GetAdditionalSettingOrCreateNew<RenderPartialSettings>();
            settings.Action = action;

            return builder;
        }
    }
}
