using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdSpotters.Controllers
{
    public class SpeciesController : Controller
    {
        [Route("/arter")]
        public IActionResult Index()
        {
            string session1 = "Du är vår favorit! Tack för att du är med och kollar vilka fågelarter som finns i Sverige!";
            HttpContext.Session.SetString("sess1", session1); 

            return View();
        }

        [Route("/arter/favorit")]
        public IActionResult Favourite()
        {

            string session2 = HttpContext.Session.GetString("sess1");

            if (session2 == null) {
                ViewBag.favourite = "Ojdå, det verkar som du kommit till denna sida från icke avsedd länk."; 
            } else
            {
                ViewBag.favourite = session2; 
            }

            return View();
        }
    }
}
