using SemnanFlix.Common.Models;
using SemnanFlix.Managers.Interfaces;
using SemnanFlix.ViewModels.Department;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SemnanFlix.Web.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private IDepartmentManager _departmentManager;

        public DepartmentController(IDepartmentManager departmentManager)
        {
            _departmentManager = departmentManager;
        }

        public ActionResult Index(string sortOrder, string search, int? pageIndex, int? pageSize)
        {
            var request = new DataTableRequest(this, sortOrder, search, pageIndex, pageSize);

            var vms = _departmentManager.GetAllByRequest(request);

            return View(vms);
        }

        public ActionResult Edit(int? id)
        {
            var vm = _departmentManager.Get(id);

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DepartmentViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _departmentManager.Save(vm);
                return RedirectToAction("Index");
            }

            return View(vm);
        }

        public ActionResult Delete(int id)
        {
            var vm = _departmentManager.Get(id);

            return View(vm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _departmentManager.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
