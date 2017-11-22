using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);
        }

        //Action methods render view pages.
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRepository.getComicBook((int)id);

            //Creates a ViewResult object that renders a view to the response.
            return View(comicBook);

        }

    }
}