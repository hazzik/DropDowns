using System.Linq;
using System.Web.Mvc;
using MvcExtensions.DropDowns;
using SampleApplication.Movies.ViewModels;

namespace SampleApplication.Movies
{
    public class ListController : Controller
    {
        [ChildActionOnly, DropDownListAction]
        public ActionResult Genres(int? key)
        {
            var genres = new[]
                             {
                                 new Genre {Id = 1, DisplayName = "Comedy"},
                                 new Genre {Id = 2, DisplayName = "Horror"},
                                 new Genre {Id = 3, DisplayName = "Documentary"}
                             };

            var model = new SelectList(genres, "Id", "DisplayName", key);

            return PartialView("DropDownList", model);
        }

        [ChildActionOnly, DropDownListAction]
        public ActionResult Years(int? key)
        {
            var model = new SelectList(Enumerable.Range(1990, 20).Select(y => new {Value = y}),
                                       "Value", "Value", key);

            return PartialView("DropDownList", model);
        }
    }
}
