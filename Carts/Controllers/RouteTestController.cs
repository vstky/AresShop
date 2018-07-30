﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carts.Controllers
{
    public class RouteTestController : Controller
    {
        // GET: RouteTest
        public ActionResult Index()
        {
            //取得所有商品，放入result
            var result = Models.RouteTest.TempProducts.getAllproducts();

            //將result(所有商品)傳送給View
            return View(result);
        }
    }
}