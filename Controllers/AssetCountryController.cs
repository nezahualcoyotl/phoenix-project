using BackstageMusic.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BackstageMusic.Controllers
{
    public class AssetCountryController : Controller
    {
        private BackstageMusicDB db = new BackstageMusicDB();

        // GET: AssetCountry
        public ActionResult Index()
        {
            var assetCountries = db.AssetCountries.Include(a => a.Asset).Include(a => a.Country);
            return View(assetCountries.ToList());
        }

        // GET: AssetCountry/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssetCountry assetCountry = db.AssetCountries.Find(id);
            if (assetCountry == null)
            {
                return HttpNotFound();
            }
            return View(assetCountry);
        }

        // GET: AssetCountry/Create
        public ActionResult Create()
        {
            ViewBag.id_asset = new SelectList(db.Assets, "id_asset", "name");
            ViewBag.id_country = new SelectList(db.Countries, "id_country", "name");
            return View();
        }

        // POST: AssetCountry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_assetcountry,id_asset,id_country,active,created_at,updated_at")] AssetCountry assetCountry)
        {
            if (ModelState.IsValid)
            {
                db.AssetCountries.Add(assetCountry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_asset = new SelectList(db.Assets, "id_asset", "name", assetCountry.id_asset);
            ViewBag.id_country = new SelectList(db.Countries, "id_country", "name", assetCountry.id_country);
            return View(assetCountry);
        }

        // GET: AssetCountry/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AssetCountry assetCountry = db.AssetCountries.Find(id);
            if (assetCountry == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_asset = new SelectList(db.Assets, "id_asset", "name", assetCountry.id_asset);
            ViewBag.id_country = new SelectList(db.Countries, "id_country", "name", assetCountry.id_country);
            return View(assetCountry);
        }

        // POST: AssetCountry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_assetcountry,id_asset,id_country,active,created_at,updated_at")] AssetCountry assetCountry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assetCountry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_asset = new SelectList(db.Assets, "id_asset", "name", assetCountry.id_asset);
            ViewBag.id_country = new SelectList(db.Countries, "id_country", "name", assetCountry.id_country);
            return View(assetCountry);
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
