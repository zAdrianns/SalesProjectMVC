using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        private static List<Department> list = new List<Department>
        {
            new Department { Id = 1, Name = "Eletronics" },
            new Department { Id = 2, Name = "Fashion" }
        };
        public IActionResult Index()
        {
            return View(list);
        }

        public IActionResult Delete(int id)
        {
            list.RemoveAll(p => p.Id == id);
            return RedirectToAction("Index");
        }
    }
}