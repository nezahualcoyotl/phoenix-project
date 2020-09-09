using BackstageMusic.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BackstageMusic.Controllers
{
    public class CollaboratorTypeController : Controller
    {
        private BackstageMusicDB db = new BackstageMusicDB();

        // GET: CollaboratorType
        public ActionResult Index()
        {
            return View(db.CollaboratorTypes.ToList());
        }

        // GET: CollaboratorType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CollaboratorType collaboratorType = db.CollaboratorTypes.Find(id);
            if (collaboratorType == null)
            {
                return HttpNotFound();
            }
            return View(collaboratorType);
        }

        // GET: CollaboratorType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CollaboratorType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_collaboratortype,name,active,created_at,updated_at")] CollaboratorType collaboratorType)
        {
            if (ModelState.IsValid)
            {
                db.CollaboratorTypes.Add(collaboratorType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(collaboratorType);
        }

        // GET: CollaboratorType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CollaboratorType collaboratorType = db.CollaboratorTypes.Find(id);
            if (collaboratorType == null)
            {
                return HttpNotFound();
            }
            return View(collaboratorType);
        }

        // POST: CollaboratorType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_collaboratortype,name,active,created_at,updated_at")] CollaboratorType collaboratorType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(collaboratorType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(collaboratorType);
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
