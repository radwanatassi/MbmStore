﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Infrastructure;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {


            ViewBag.Movies = Repository.Products.OfType<Movie>().ToList<Movie>();

            return View();
        }
    }
}