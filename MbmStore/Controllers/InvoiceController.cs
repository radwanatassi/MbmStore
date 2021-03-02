using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;


namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var invoices = Repository.Invoices;
            ViewBag.Invoices = invoices;

            return View();
        }
    }
}
