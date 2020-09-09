using BackstageMusic.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BackstageMusic.Controllers
{
    public class LabelController : Controller
    {
        private BackstageMusicDB db = new BackstageMusicDB();

        // GET: Label
        public ActionResult Index()
        {
            var labels = db.Labels.Include(l => l.User);
            return View(labels.ToList());
        }

        // GET: Label/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Label label = db.Labels.Find(id);
            if (label == null)
            {
                return HttpNotFound();
            }
            return View(label);
        }

        // GET: Label/Create
        public ActionResult Create()
        {
            ViewBag.id_user = new SelectList(db.Users, "id_user", "username");
            return View();
        }

        // POST: Label/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_label,name,id_user,active,created_at,updated_at")] Label label)
        {
            if (ModelState.IsValid)
            {
                db.Labels.Add(label);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_user = new SelectList(db.Users, "id_user", "username", label.id_user);
            return View(label);
        }

        // GET: Label/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Label label = db.Labels.Find(id);
            if (label == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_user = new SelectList(db.Users, "id_user", "username", label.id_user);
            return View(label);
        }

        // POST: Label/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_label,name,id_user,active,created_at,updated_at")] Label label)
        {
            if (ModelState.IsValid)
            {
                db.Entry(label).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_user = new SelectList(db.Users, "id_user", "username", label.id_user);
            return View(label);
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
