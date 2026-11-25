using Microsoft.AspNetCore.Mvc;
using MVC01.Models;

namespace MVC01.Controllers
{
    [Route("John/[Controller]/[Action]")]
    public class ProductsController : Controller
    {
        //// BaseULR/Products/GetProductById
        [HttpGet]
        public Product GetProductById(int id)
        {
            return new Product()
            {
                Id = 1,
                Name = "Iphone 15 Pro Max",
                Price = 10000
            };

        }



        ////BaseURL/Products/GetAllProducts 
        //[HttpGet]
        //public List<Product> GetAllProducts()
        //{
        //    return new List<Product>()
        //    {
        //        new Product() { Id = 1, Name = "P1", Price = 1000 },
        //        new Product() { Id = 2, Name = "P2", Price = 2000 },
        //        new Product() { Id = 3, Name = "P3", Price = 3000 },
        //    };
        //}



        // Action Results : Built-in Datatype Used As Return Type For Actions


        //BASEURL/Products/GetProduct
        [HttpGet]
        public JsonResult GetProduct()
        {
            return new JsonResult (new List<Product>()
            {
                new Product() { Id = 1, Name = "P1", Price = 1000 },
                new Product() { Id = 2, Name = "P2", Price = 2000 },
                new Product() { Id = 3, Name = "P3", Price = 3000 },
            });
        }




        // BaseURL/Products/Index
        [HttpGet]
        public ViewResult Index()
        {
            return new ViewResult(); // HTML Pages
        }




        [HttpGet] // BASEURL/Products/DownloadFile
        public FileContentResult DownloadFile()
        {

            var bytes = System.IO.File.ReadAllBytes("wwwroot/Files/notes.txt");
            return new FileContentResult(bytes, "application/txt");

        }




        [HttpGet] // BASEURL/Products/RedirectToUrl
        public RedirectResult RedirectToUrl()
        {
            return  Redirect("https://www.google.com");
        }



        [HttpGet] // BASEURL/Products/RedirectToAction
        public RedirectToActionResult RedirectToAction()
        {
            return RedirectToAction("RedirectToUrl", "Products", null);

        }




        public IActionResult Test(int id)
        {
            if (id == 1)
                return View();
            else if (id == 2)
                return Json(new Product() { Id = 1, Name = "Iphone 15 Pro Max", Price = 20 });
            else if (id == 3)
                return Redirect("https://www.facebook.com");
            else
                return View();

        }




    }
}
