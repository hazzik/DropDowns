using System.Web.Mvc;

namespace MvcExtensions.DropDowns
{
    public static class ModelMetadataDropDownSettings
    {
        public static DropDownListSettings DropDownSettings(this ModelMetadata modelMetadata)
        {
            var extendedModelMetadata = modelMetadata as ExtendedModelMetadata;
            if (extendedModelMetadata == null)
                return new DropDownListSettings();

            return extendedModelMetadata.Metadata.GetAdditionalSettingOrCreateNew<DropDownListSettings>();
        }

        public static DropDownListSettings DropDownSettings(this ViewDataDictionary viewData)
        {
            return DropDownSettings(viewData.ModelMetadata);
        }
    }
}
