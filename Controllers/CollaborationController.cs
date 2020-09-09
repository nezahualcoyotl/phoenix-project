using BackstageMusic.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BackstageMusic.Controllers
{
    public class CollaborationController : Controller
    {
        private BackstageMusicDB db = new BackstageMusicDB();

        // GET: Collaboration
        public ActionResult Index()
        {
            var collaborations = db.Collaborations.Include(c => c.CollaboratorType).Include(c => c.Track);
            return View(collaborations.ToList());
        }

        // GET: Collaboration/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Collaboration collaboration = db.Collaborations.Find(id);
            if (collaboration == null)
            {
                return HttpNotFound();
            }
            return View(collaboration);
        }

        // GET: Collaboration/Create
        public ActionResult Create()
        {
            ViewBag.id_collaboratortype = new SelectList(db.CollaboratorTypes, "id_collaboratortype", "name");
            ViewBag.id_track = new SelectList(db.Tracks, "id_track", "name");
            return View();
        }

        // POST: Collaboration/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_collaboration,id_track,id_collaboratortype,name,active,created_at,updated_at")] Collaboration collaboration)
        {
            if (ModelState.IsValid)
            {
                db.Collaborations.Add(collaboration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_collaboratortype = new SelectList(db.CollaboratorTypes, "id_collaboratortype", "name", collaboration.id_collaboratortype);
            ViewBag.id_track = new SelectList(db.Tracks, "id_track", "name", collaboration.id_track);
            return View(collaboration);
        }

        // GET: Collaboration/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Collaboration collaboration = db.Collaborations.Find(id);
            if (collaboration == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_collaboratortype = new SelectList(db.CollaboratorTypes, "id_collaboratortype", "name", collaboration.id_collaboratortype);
            ViewBag.id_track = new SelectList(db.Tracks, "id_track", "name", collaboration.id_track);
            return View(collaboration);
        }

        // POST: Collaboration/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_collaboration,id_track,id_collaboratortype,name,active,created_at,updated_at")] Collaboration collaboration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(collaboration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_collaboratortype = new SelectList(db.CollaboratorTypes, "id_collaboratortype", "name", collaboration.id_collaboratortype);
            ViewBag.id_track = new SelectList(db.Tracks, "id_track", "name", collaboration.id_track);
            return View(collaboration);
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
