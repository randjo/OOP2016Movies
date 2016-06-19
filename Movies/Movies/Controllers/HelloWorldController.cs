using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            //return View();
            return "Hello World!"; 
        }

        public string Welcome(string name, int numTimes = 0, int age = 18)
        {
            return String.Format("Welcome {0} !!! {1}. My age is {2}.", name, numTimes, age);
        }
    }
}