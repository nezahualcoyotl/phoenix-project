using BackstageMusic.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BackstageMusic.Controllers
{
    public class ManagerController : Controller
    {
        private BackstageMusicDB db = new BackstageMusicDB();

        // GET: Manager
        public ActionResult Index()
        {
            var managers = db.Managers.Include(m => m.Label).Include(m => m.User);
            return View(managers.ToList());
        }

        // GET: Manager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manager manager = db.Managers.Find(id);
            if (manager == null)
            {
                return HttpNotFound();
            }
            return View(manager);
        }

        // GET: Manager/Create
        public ActionResult Create()
        {
            ViewBag.id_label = new SelectList(db.Labels, "id_label", "name");
            ViewBag.id_user = new SelectList(db.Users, "id_user", "username");
            return View();
        }

        // POST: Manager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_manager,name,id_user,id_label,active,created_at,updated_at")] Manager manager)
        {
            if (ModelState.IsValid)
            {
                db.Managers.Add(manager);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_label = new SelectList(db.Labels, "id_label", "name", manager.id_label);
            ViewBag.id_user = new SelectList(db.Users, "id_user", "username", manager.id_user);
            return View(manager);
        }

        // GET: Manager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manager manager = db.Managers.Find(id);
            if (manager == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_label = new SelectList(db.Labels, "id_label", "name", manager.id_label);
            ViewBag.id_user = new SelectList(db.Users, "id_user", "username", manager.id_user);
            return View(manager);
        }

        // POST: Manager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_manager,name,id_user,id_label,active,created_at,updated_at")] Manager manager)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manager).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_label = new SelectList(db.Labels, "id_label", "name", manager.id_label);
            ViewBag.id_user = new SelectList(db.Users, "id_user", "username", manager.id_user);
            return View(manager);
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
