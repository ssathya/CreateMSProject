using MSProject.Models;
using System.Linq;
using System.Web.Mvc;

namespace MSProject.Controllers
{
    public class SelectProjectController : Controller
    {
        private readonly IProjectContext _db;

        public SelectProjectController(IProjectContext projectContext)
        {
            _db = projectContext;
        }

        // GET: SelectProject
        public ActionResult Index()
        {
            return View(_db.Projects.ToList());
        }

        [HttpPost]
        public ActionResult Index(int projectId)
        {
            var pId = projectId;
            //int.TryParse(projectId, out pId);

            if (pId == 0) return View(_db.Projects.ToList());
            var project = _db.Projects.FirstOrDefault(p => p.Id == pId);
            if (project != null)
                ViewBag.SelectedProject = project.Name;
            return View(_db.Projects.ToList());
        }
    }
}