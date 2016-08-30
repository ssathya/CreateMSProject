using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MSProject.Models;
using Models.AppModel;

namespace MSProject.Controllers
{
    public class ProjectResourcesController : Controller
    {
        private ProjectContext db = new ProjectContext();

        // GET: ProjectResources
        public async Task<ActionResult> Index()
        {
            var projectResources = db.ProjectResources.Include(p => p.Resource).Include(p => p.Task);
            return View(await projectResources.ToListAsync());
        }

        // GET: ProjectResources/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectResources projectResources = await db.ProjectResources.FindAsync(id);
            if (projectResources == null)
            {
                return HttpNotFound();
            }
            return View(projectResources);
        }

        // GET: ProjectResources/Create
        public ActionResult Create()
        {
            ViewBag.ResourceId = new SelectList(db.Resources, "Id", "Name");
            ViewBag.ProjectTaskId = new SelectList(db.ProjectTasks, "Id", "Name");
            return View();
        }

        // POST: ProjectResources/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,ProjectTaskId,ResourceId")] ProjectResources projectResources)
        {
            if (ModelState.IsValid)
            {
                db.ProjectResources.Add(projectResources);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ResourceId = new SelectList(db.Resources, "Id", "Name", projectResources.ResourceId);
            ViewBag.ProjectTaskId = new SelectList(db.ProjectTasks, "Id", "Name", projectResources.ProjectTaskId);
            return View(projectResources);
        }

        // GET: ProjectResources/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectResources projectResources = await db.ProjectResources.FindAsync(id);
            if (projectResources == null)
            {
                return HttpNotFound();
            }
            ViewBag.ResourceId = new SelectList(db.Resources, "Id", "Name", projectResources.ResourceId);
            ViewBag.ProjectTaskId = new SelectList(db.ProjectTasks, "Id", "Name", projectResources.ProjectTaskId);
            return View(projectResources);
        }

        // POST: ProjectResources/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,ProjectTaskId,ResourceId")] ProjectResources projectResources)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectResources).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ResourceId = new SelectList(db.Resources, "Id", "Name", projectResources.ResourceId);
            ViewBag.ProjectTaskId = new SelectList(db.ProjectTasks, "Id", "Name", projectResources.ProjectTaskId);
            return View(projectResources);
        }

        // GET: ProjectResources/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProjectResources projectResources = await db.ProjectResources.FindAsync(id);
            if (projectResources == null)
            {
                return HttpNotFound();
            }
            return View(projectResources);
        }

        // POST: ProjectResources/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ProjectResources projectResources = await db.ProjectResources.FindAsync(id);
            db.ProjectResources.Remove(projectResources);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
