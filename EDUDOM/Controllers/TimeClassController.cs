using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDUDOM.Controllers
{
    public class TimeClassController : Controller
    {
        // GET: TimeClassController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: TimeClassController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TimeClassController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeClassController1/Create
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

        // GET: TimeClassController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TimeClassController1/Edit/5
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

        // GET: TimeClassController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TimeClassController1/Delete/5
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
