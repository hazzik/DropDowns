﻿namespace SampleApplication.Movies
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Web.Mvc;
    using MvcExtensions;
    using ViewModels;

    public class MovieController : Controller
    {
        private static readonly IDictionary<int, Movie> Movies = new Dictionary<int, Movie>();
        private static int UniqueKey;

        [HttpGet]
        [ImportViewDataFromTempData]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                ExportViewDataToTempData();
                return RedirectToAction("Create");
            }

            var id = Save(movie);

            return RedirectToAction("Details", new {id});
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View("Create", Get(id));
        }

        private static Movie Get(int key)
        {
            Movie movie;
            Movies.TryGetValue(key, out movie);
            return movie;
        }

        private static int Save(Movie movie)
        {
            Interlocked.Increment(ref UniqueKey);
            Movies.Add(UniqueKey, movie);
            return UniqueKey;
        }

        private void ExportViewDataToTempData()
        {
            TempData[ViewDataTempDataTransferAttribute.DefaultKey] = new ViewDataDictionary(ViewData);
        }
    }
}