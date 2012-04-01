using System.Web.Mvc.Html;
using MvcExtensions;

namespace SampleApplication.Movies.ViewModels.Metadata
{
    using System;

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

            Configure(x => x.Text)
                .DisplayName("Please enter \"PRG\" into this field to test Post-Redirect-Get scenario")
                .Validate(x => !string.Equals(x, "PRG", StringComparison.OrdinalIgnoreCase), "As you can see values in the select elements are sucessfuly restored after redirect.");
        }
    }
}