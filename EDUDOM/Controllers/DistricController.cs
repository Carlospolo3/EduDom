using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDUDOM.Controllers
{
    public class DistricController : Controller
    {
        // GET: DistricController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DistricController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DistricController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DistricController/Create
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

        // GET: DistricController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DistricController/Edit/5
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

        // GET: DistricController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DistricController/Delete/5
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
