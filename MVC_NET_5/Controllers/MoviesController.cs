using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace MVC_NET_5.Controllers
{
    // Any Controller MUST HAVE THE WORD CONTROLLER IN ITS NAME
    // Must inherit the Class Controller
    public class MoviesController : Controller
    {
        // The function must be non-static and public
        // non static = object member

        #region Action Parameter Binding
        // Action Parameter Binding "In order are"
        // The Id from the next Action will come from where
        // 1. Form "html form"
        // 2. Segment
        // 3. Query String
        // 4. File

        // For option 3 and 4 you should have clearly described the Id in the route templte
        #endregion

        // To send the query string https://localhost:44395/movies/getmovie?id=10&name=abc
        public IActionResult GetMovie(int id, string name)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"The Movie with Id = {Id}";
            //return result;

            return Content($"The Movie with Id = {id}");
        }


        // Action have to return a special data types
        // They all implement the interface IActionResult
        public /*ContentResult*/ IActionResult Index()
        {
            /*
            // For explanation only
            ContentResult result = new ContentResult();
            result.Content = "Hello from Index";
            result.ContentType = "text/html"; // Default
            // result.ContentType = "object/pdf"; // will download a pdf file
            return result;
            */

            // You don't have to create an object from the special datatype
            // like the previous text
            // just use the helper method directly
            // return Content ("Hello From Index"); // Default
            return Content("Hello From Index", "text/html"); // overload

        }

        public /*RedirectResult*/ IActionResult Test()
        {
            //RedirectResult result = new RedirectResult("https://www.google.com");
            //// You can redirect to another action also
            ////RedirectResult result = new RedirectResult("https://localhost:44395/movies/index");
            //return result;

            // instead of writing the url, you will create a dynamic redirect
            //return RedirectToAction("Index"); // to direct to an Action but may cause typo error
            // return RedirectToAction(nameof(Index)); // to avoid typo errors

            return RedirectToRoute(new {controller = "Movies", action ="Index" });
        }
    }
}
