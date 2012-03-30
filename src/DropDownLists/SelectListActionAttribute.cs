using System.Web.Mvc;

namespace MvcExtensions.DropDowns
{
    public class SelectListActionAttribute : ActionFilterAttribute
    {
        private const string DefaultSelectedArgumentName = "selected";

        public string SelectedArgumentName { get; set; }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var result = (ViewResultBase) context.Result;
            CopyViewDataProperties(context.ParentActionViewContext.ViewData, result.ViewData);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.ActionParameters[SelectedArgumentName ?? DefaultSelectedArgumentName] = GetSelectedValue(context);
        }

        private static void CopyViewDataProperties(ViewDataDictionary source, ViewDataDictionary destination)
        {
            destination.ModelMetadata = source.ModelMetadata;
            destination.TemplateInfo.FormattedModelValue = source.TemplateInfo.FormattedModelValue;
            destination.TemplateInfo.HtmlFieldPrefix = source.TemplateInfo.HtmlFieldPrefix;
        }

        private static object GetAttemptedValue(ViewDataDictionary viewData)
        {
            ModelState modelState;
            if (viewData.ModelState.TryGetValue(viewData.ModelMetadata.PropertyName, out modelState) && modelState.Value != null)
                return modelState.Value.ConvertTo(viewData.ModelMetadata.ModelType, null);

            return null;
        }

        private static object GetSelectedValue(ControllerContext context)
        {
            var viewData = context.ParentActionViewContext.ViewData;
            return GetAttemptedValue(viewData) ?? viewData.Model;
        }
    }
}
