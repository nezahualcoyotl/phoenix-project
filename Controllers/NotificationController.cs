using BackstageMusic.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BackstageMusic.Controllers
{
    public class NotificationController : Controller
    {
        private BackstageMusicDB db = new BackstageMusicDB();

        // GET: Notification
        public ActionResult Index()
        {
            var notifications = db.Notifications.Include(n => n.Receiver).Include(n => n.Sender);
            return View(notifications.ToList());
        }

        // GET: Notification/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notification notification = db.Notifications.Find(id);
            if (notification == null)
            {
                return HttpNotFound();
            }
            return View(notification);
        }

        // GET: Notification/Create
        public ActionResult Create()
        {
            ViewBag.id_receiver = new SelectList(db.Users, "id_user", "username");
            ViewBag.id_sender = new SelectList(db.Users, "id_user", "username");
            return View();
        }

        // POST: Notification/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_notification,id_sender,id_receiver,message,is_seen,active,created_at,updated_at")] Notification notification)
        {
            if (ModelState.IsValid)
            {
                db.Notifications.Add(notification);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_receiver = new SelectList(db.Users, "id_user", "username", notification.id_receiver);
            ViewBag.id_sender = new SelectList(db.Users, "id_user", "username", notification.id_sender);
            return View(notification);
        }

        // GET: Notification/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notification notification = db.Notifications.Find(id);
            if (notification == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_receiver = new SelectList(db.Users, "id_user", "username", notification.id_receiver);
            ViewBag.id_sender = new SelectList(db.Users, "id_user", "username", notification.id_sender);
            return View(notification);
        }

        // POST: Notification/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_notification,id_sender,id_receiver,message,is_seen,active,created_at,updated_at")] Notification notification)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notification).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_receiver = new SelectList(db.Users, "id_user", "username", notification.id_receiver);
            ViewBag.id_sender = new SelectList(db.Users, "id_user", "username", notification.id_sender);
            return View(notification);
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
