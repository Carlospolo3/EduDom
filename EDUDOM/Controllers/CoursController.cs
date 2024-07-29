using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDUDOM.Controllers
{
    public class CoursController : Controller
    {
        // GET: CorseController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CorseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CorseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CorseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CorseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CorseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CorseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CorseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
