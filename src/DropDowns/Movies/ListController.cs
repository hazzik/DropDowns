using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcExtensions;
using SampleApplication.Movies.ViewModels;

namespace SampleApplication.Movies
{
    public class ListController : Controller
    {
        [ChildActionOnly, SelectListAction]
        public ActionResult Genres(int? selected)
        {
            var genres = new[]
                             {
                                 new Genre {Id = 1, DisplayName = "Comedy"},
                                 new Genre {Id = 2, DisplayName = "Horror"},
                                 new Genre {Id = 3, DisplayName = "Documentary"}
                             };

            var model = new SelectList(genres, "Id", "DisplayName", selected);

            return PartialView("DropDownList", model);
        }

        [ChildActionOnly, SelectListAction]
        public ActionResult Years(IEnumerable<int> selected)
        {
            var model = new MultiSelectList(Enumerable.Range(1990, 20), selected);

            return PartialView("ListBox", model);
        }
    }
}
