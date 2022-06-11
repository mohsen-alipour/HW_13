using Microsoft.AspNetCore.Mvc;
using WebApp_HW_13.infrastructure.DataAccess;
using WebApp_HW_13.Models.Entity;

namespace WebApp_HW_13.Controllers
{
    public class LibararyController : Controller
    {
        private EF_Repository O_EF_Repository;
        public LibararyController()
        {
          
            O_EF_Repository = new EF_Repository();
        }
        public IActionResult Index()
        {
            var List_M = O_EF_Repository.GetAllInfoLibarary();
            return View(List_M);
          
        }
        public IActionResult Detail(int id)
        {
            var List_B = O_EF_Repository.Getdatail(id);
            return View(List_B);

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var x = O_EF_Repository.Getdatail(id);
            return View(x);
        }
        [HttpPost]
        public IActionResult Edit(Book item)
        {
            O_EF_Repository.Edit(item);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var x = O_EF_Repository.Getdatail(id);
            O_EF_Repository.Delete(x);
            return RedirectToAction("Index");
        }

        public IActionResult amanat()
        {
            var List_M = O_EF_Repository.GetAllAmanat();
            return View(List_M);
        }
        [HttpGet]
        public IActionResult Addamanat()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addamanat(Amanat item)
        {
            O_EF_Repository.AddAmanat(item);
            return RedirectToAction("amanat");
        }


    }
}
