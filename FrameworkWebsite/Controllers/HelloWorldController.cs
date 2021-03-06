﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FrameworkWebsite.Controllers
{
    public class HelloWorldController : Controller
    {
		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();
		}

		// GET: /HelloWorld/Welcome/ 
		// Requires using System.Text.Encodings.Web;
		public string Welcome(string name, int ID = 1)
		{
			return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
		}

		// GET: /HelloWorld/Test/ 
		public string Test(string name, int ID = 25)
		{
			return HtmlEncoder.Default.Encode($"Hallo {name} leuk dat je er weer bent, ID: {ID}");
		}
    }
}
