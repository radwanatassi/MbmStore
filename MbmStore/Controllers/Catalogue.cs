using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Models;
using MbmStore.Infrastructure;
using System.Linq;

namespace MbmStore.Controllers
{
    public class Catalogue : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var books = Repository.Products.OfType<Book>().ToList();

            ViewBag.Books = books;

            var albums = Repository.Products.OfType<MusicCD>().ToList();


            ViewBag.Albums = albums;

            var movies = Repository.Products.OfType<Movie>().ToList();

            ViewBag.Movies = movies;
            return View();
        }
    }
}
