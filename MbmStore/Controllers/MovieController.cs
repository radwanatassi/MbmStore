using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

            // create a new Movie object with instance name jungleBook
            var jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg","JungleBookDirectorName");
            var gladiator = new Movie("Gladiator", 171.50m, "gladiator.jpg","gladiatorDirectorName");
            var forrestGump = new Movie("Forrest Gump", 140.20m, "forrest-gump.jpg","ForrestGumpDirectorName");

            // assign a ViewBag property to the new Movie object
            ViewBag.JungleBook = jungleBook;
            ViewBag.Gladiator = gladiator;
            ViewBag.ForrestGump = forrestGump;

            // return the default view
            return View();
        }
    }
}