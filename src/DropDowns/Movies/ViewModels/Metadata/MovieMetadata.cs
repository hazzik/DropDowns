using System.Web.Mvc.Html;
using MvcExtensions;

namespace SampleApplication.Movies.ViewModels.Metadata
{
    public class MovieMetadata : ModelMetadataConfiguration<Movie>
    {
        public MovieMetadata()
        {
            Configure(x => x.GenreId)
                .DisplayName("Genre")
                .RenderAction(html => html.Action("Genres", "List"))
                .NullDisplayText("---Please Select---")
                .Required();

            Configure(x => x.Years)
                .RenderAction(html => html.Action("Years", "List"))
                .DisplayName("Year")
                .NullDisplayText("---Please Select---")
                .Required();
        }
    }
}