﻿using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Api.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult GetSignaturesByCategoryId(string categoryId) {
            var products = Product.GetByCategoryId(categoryId);
            var signatures = products.Select(p => ProductSignature.Create(p));
            return new Api.Models.JsonResult(signatures);
        }
    }
}
