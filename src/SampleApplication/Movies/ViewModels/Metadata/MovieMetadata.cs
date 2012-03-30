using System.Web.Mvc.Html;
using MvcExtensions;
using MvcExtensions.DropDowns;

namespace SampleApplication.Movies.ViewModels.Metadata
{
    public class MovieMetadata : ModelMetadataConfiguration<Movie>
    {
        public MovieMetadata()
        {
            Configure(x => x.GenreId)
                .DisplayName("Genre")
                .RenderPartial(html => html.Action("Genres", "List"))
                .NullDisplayText("---Please Select---")
                .Required();

            Configure(x => x.Years)
                .RenderPartial(html => html.Action("Years", "List"))
                .DisplayName("Year")
                .NullDisplayText("---Please Select---")
                .Required();
        }
    }
}