using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirdSpotters.Models;
using Newtonsoft.Json;

namespace BirdSpotters.Controllers
{
    public class ObservationsController : Controller
    {
        [Route("/observation")]
        public IActionResult Index()
        {
             
            var JsonStr = System.IO.File.ReadAllText("birds.json");
            var JsonObj = JsonConvert.DeserializeObject<IEnumerable<ObservationsModel>>(JsonStr);
            return View(JsonObj); 
        }


        [Route("/observation/fagel")]
        public IActionResult AddSecond()
        {

            return View();
        }

        [Route("/observation/fagel")]
        [HttpPost]
        public IActionResult AddSecond(ObservationsModel model)  
        {
            if (ModelState.IsValid)
            {        
                var JsonStr = System.IO.File.ReadAllText("birds.json");
                var JsonObj = JsonConvert.DeserializeObject<List<ObservationsModel>>(JsonStr);
                JsonObj.Add(model);
                System.IO.File.WriteAllText("birds.json", JsonConvert.SerializeObject(JsonObj, Formatting.Indented));

                ViewBag.form = "Du har lagt till en observation!"; 
                ModelState.Clear();
            }           

            return View();
        }


    }
}
