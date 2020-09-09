using BackstageMusic.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BackstageMusic.Controllers
{
    public class AssetPlatformController : Controller
    {
        private BackstageMusicDB db = new BackstageMusicDB();

        // GET: AssetPlatform
        public ActionResult Index()
        {
            var assetPlatforms = db.AssetPlatforms.Include(a => a.Asset).Include(a => a.Platform);
            return View(assetPlatforms.ToList());
        }

        // GET: AssetPlatform/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssetPlatform assetPlatform = db.AssetPlatforms.Find(id);
            if (assetPlatform == null)
            {
                return HttpNotFound();
            }
            return View(assetPlatform);
        }

        // GET: AssetPlatform/Create
        public ActionResult Create()
        {
            ViewBag.id_asset = new SelectList(db.Assets, "id_asset", "name");
            ViewBag.id_genre = new SelectList(db.Platforms, "id_platform", "name");
            return View();
        }

        // POST: AssetPlatform/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_assetplatform,id_asset,id_genre,active,created_at,updated_at")] AssetPlatform assetPlatform)
        {
            if (ModelState.IsValid)
            {
                db.AssetPlatforms.Add(assetPlatform);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_asset = new SelectList(db.Assets, "id_asset", "name", assetPlatform.id_asset);
            ViewBag.id_genre = new SelectList(db.Platforms, "id_platform", "name", assetPlatform.id_genre);
            return View(assetPlatform);
        }

        // GET: AssetPlatform/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssetPlatform assetPlatform = db.AssetPlatforms.Find(id);
            if (assetPlatform == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_asset = new SelectList(db.Assets, "id_asset", "name", assetPlatform.id_asset);
            ViewBag.id_genre = new SelectList(db.Platforms, "id_platform", "name", assetPlatform.id_genre);
            return View(assetPlatform);
        }

        // POST: AssetPlatform/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_assetplatform,id_asset,id_genre,active,created_at,updated_at")] AssetPlatform assetPlatform)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assetPlatform).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_asset = new SelectList(db.Assets, "id_asset", "name", assetPlatform.id_asset);
            ViewBag.id_genre = new SelectList(db.Platforms, "id_platform", "name", assetPlatform.id_genre);
            return View(assetPlatform);
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
