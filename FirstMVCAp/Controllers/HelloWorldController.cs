using Microsoft.AspNetCore.Mvc;
using FirstMVCAp.Models;

namespace FirstMVCAp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModule> dogs = new List<DogViewModule>();

        public IActionResult Index()
        {

            return View(dogs);
        }

        public IActionResult Create()
        {
            var dogvm = new DogViewModule();
             
            return View(dogvm);
        }
        public IActionResult CreateDog(DogViewModule  dogViewModule)

        {
            /* return View("Index");*/
            dogs.Add(dogViewModule);
            return RedirectToAction(nameof (Index));
        }
 
         


         
    }
}
