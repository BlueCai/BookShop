﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QB.BookShop.Admin.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}