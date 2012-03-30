using System.Web.Mvc;

namespace MvcExtensions.DropDowns
{
    public static class ModelMetadataRenderPartialSettings
    {
        public static RenderPartialSettings RenderPartialSettings(this ModelMetadata modelMetadata)
        {
            var extendedModelMetadata = modelMetadata as ExtendedModelMetadata;
            if (extendedModelMetadata == null)
                return new RenderPartialSettings();

            return extendedModelMetadata.Metadata.GetAdditionalSettingOrCreateNew<RenderPartialSettings>();
        }

        public static RenderPartialSettings RenderPartialSettings(this ViewDataDictionary viewData)
        {
            return RenderPartialSettings(viewData.ModelMetadata);
        }
    }
}
