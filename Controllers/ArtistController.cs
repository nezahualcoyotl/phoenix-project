using BackstageMusic.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BackstageMusic.Controllers
{
    public class ArtistController : Controller
    {
        private BackstageMusicDB db = new BackstageMusicDB();

        // GET: Artist
        public ActionResult Index()
        {
            var artists = db.Artists.Include(a => a.Manager).Include(a => a.User);
            return View(artists.ToList());
        }

        // GET: Artist/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // GET: Artist/Create
        public ActionResult Create()
        {
            ViewBag.id_manager = new SelectList(db.Managers, "id_manager", "name");
            ViewBag.id_user = new SelectList(db.Users, "id_user", "username");
            return View();
        }

        // POST: Artist/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_artist,name,id_user,id_manager,active,created_at,updated_at")] Artist artist)
        {
            if (ModelState.IsValid)
            {
                db.Artists.Add(artist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_manager = new SelectList(db.Managers, "id_manager", "name", artist.id_manager);
            ViewBag.id_user = new SelectList(db.Users, "id_user", "username", artist.id_user);
            return View(artist);
        }

        // GET: Artist/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_manager = new SelectList(db.Managers, "id_manager", "name", artist.id_manager);
            ViewBag.id_user = new SelectList(db.Users, "id_user", "username", artist.id_user);
            return View(artist);
        }

        // POST: Artist/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_artist,name,id_user,id_manager,active,created_at,updated_at")] Artist artist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_manager = new SelectList(db.Managers, "id_manager", "name", artist.id_manager);
            ViewBag.id_user = new SelectList(db.Users, "id_user", "username", artist.id_user);
            return View(artist);
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
