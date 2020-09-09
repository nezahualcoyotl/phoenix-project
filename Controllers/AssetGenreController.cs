using BackstageMusic.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BackstageMusic.Controllers
{
    public class AssetGenreController : Controller
    {
        private BackstageMusicDB db = new BackstageMusicDB();

        // GET: AssetGenre
        public ActionResult Index()
        {
            var assetGenres = db.AssetGenres.Include(a => a.Asset).Include(a => a.Genre);
            return View(assetGenres.ToList());
        }

        // GET: AssetGenre/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssetGenre assetGenre = db.AssetGenres.Find(id);
            if (assetGenre == null)
            {
                return HttpNotFound();
            }
            return View(assetGenre);
        }

        // GET: AssetGenre/Create
        public ActionResult Create()
        {
            ViewBag.id_asset = new SelectList(db.Assets, "id_asset", "name");
            ViewBag.id_genre = new SelectList(db.Genres, "id_genre", "name");
            return View();
        }

        // POST: AssetGenre/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_assetgenre,id_asset,id_genre,active,created_at,updated_at")] AssetGenre assetGenre)
        {
            if (ModelState.IsValid)
            {
                db.AssetGenres.Add(assetGenre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_asset = new SelectList(db.Assets, "id_asset", "name", assetGenre.id_asset);
            ViewBag.id_genre = new SelectList(db.Genres, "id_genre", "name", assetGenre.id_genre);
            return View(assetGenre);
        }

        // GET: AssetGenre/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssetGenre assetGenre = db.AssetGenres.Find(id);
            if (assetGenre == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_asset = new SelectList(db.Assets, "id_asset", "name", assetGenre.id_asset);
            ViewBag.id_genre = new SelectList(db.Genres, "id_genre", "name", assetGenre.id_genre);
            return View(assetGenre);
        }

        // POST: AssetGenre/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_assetgenre,id_asset,id_genre,active,created_at,updated_at")] AssetGenre assetGenre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assetGenre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_asset = new SelectList(db.Assets, "id_asset", "name", assetGenre.id_asset);
            ViewBag.id_genre = new SelectList(db.Genres, "id_genre", "name", assetGenre.id_genre);
            return View(assetGenre);
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
