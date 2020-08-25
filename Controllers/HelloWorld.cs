using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldMVC.Controllers
{
    public class HelloWorld : Controller
    {
        // GET: /<controller>/
        public ActionResult Index()
        {
            return View();
        }
        /*public String Index()
        {
            //return View();
            return "Hello WorldWeb this is a default page";
        }*/
        /* direct responding to client without using view 
         * public String Welcome()
        {
            return "Hello World this is my first ASP.Net MVC Web Application.....";
        }*/
        //using view
        public IActionResult Welcome(String name = "Vishal", int numOfTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["Repeat"] = numOfTimes;
            return View();
        }
        public String Display(String name="Vishal", int id = 1)
        {
            //using interpolation string
            return HtmlEncoder.Default.Encode($"Hello! {name}, & ID is: {id}");
        }
        public IActionResult ImageGallery()
        {
            return View();
        }
        public IActionResult BlankTube()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
