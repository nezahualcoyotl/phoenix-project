using BackstageMusic.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BackstageMusic.Controllers
{
    public class AssetController : Controller
    {
        private BackstageMusicDB db = new BackstageMusicDB();

        // GET: Asset
        public ActionResult Index()
        {
            var assets = db.Assets.Include(a => a.Artist).Include(a => a.AssetType).Include(a => a.Language).Include(a => a.OrderDetail).Include(a => a.Status);
            return View(assets.ToList());
        }

        // GET: Asset/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asset asset = db.Assets.Find(id);
            if (asset == null)
            {
                return HttpNotFound();
            }
            return View(asset);
        }

        // GET: Asset/Create
        public ActionResult Create()
        {
            ViewBag.id_artist = new SelectList(db.Artists, "id_artist", "name");
            ViewBag.id_assettype = new SelectList(db.AssetTypes, "id_assettype", "name");
            ViewBag.id_language = new SelectList(db.Languages, "id_language", "name");
            ViewBag.id_orderdetail = new SelectList(db.OrderDetails, "id_orderdetail", "id_orderdetail");
            ViewBag.id_status = new SelectList(db.Status, "id_status", "name");
            ViewBag.id_label = new SelectList(db.Labels, "id_label", "name");
            return View();
        }

        // POST: Asset/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_asset,id_artist,id_assettype,id_language,id_status,id_orderdetail,asset_guid,name,copy_holder,copy_year,image_version,upc,is_explicit,is_debut,price,received_on,approved_on,released_on,rejected_on,active,created_at,updated_at")] Asset asset)
        {
            if (ModelState.IsValid)
            {
                db.Assets.Add(asset);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_artist = new SelectList(db.Artists, "id_artist", "name", asset.id_artist);
            ViewBag.id_assettype = new SelectList(db.AssetTypes, "id_assettype", "name", asset.id_assettype);
            ViewBag.id_language = new SelectList(db.Languages, "id_language", "name", asset.id_language);
            ViewBag.id_orderdetail = new SelectList(db.OrderDetails, "id_orderdetail", "id_orderdetail", asset.id_orderdetail);
            ViewBag.id_status = new SelectList(db.Status, "id_status", "name", asset.id_status);
            return View(asset);
        }

        // GET: Asset/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Asset asset = db.Assets.Find(id);
            if (asset == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_artist = new SelectList(db.Artists, "id_artist", "name", asset.id_artist);
            ViewBag.id_assettype = new SelectList(db.AssetTypes, "id_assettype", "name", asset.id_assettype);
            ViewBag.id_language = new SelectList(db.Languages, "id_language", "name", asset.id_language);
            ViewBag.id_orderdetail = new SelectList(db.OrderDetails, "id_orderdetail", "id_orderdetail", asset.id_orderdetail);
            ViewBag.id_status = new SelectList(db.Status, "id_status", "name", asset.id_status);
            return View(asset);
        }

        // POST: Asset/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_asset,id_artist,id_assettype,id_language,id_status,id_orderdetail,asset_guid,name,copy_holder,copy_year,image_version,upc,is_explicit,is_debut,price,received_on,approved_on,released_on,rejected_on,active,created_at,updated_at")] Asset asset)
        {
            if (ModelState.IsValid)
            {
                db.Entry(asset).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_artist = new SelectList(db.Artists, "id_artist", "name", asset.id_artist);
            ViewBag.id_assettype = new SelectList(db.AssetTypes, "id_assettype", "name", asset.id_assettype);
            ViewBag.id_language = new SelectList(db.Languages, "id_language", "name", asset.id_language);
            ViewBag.id_orderdetail = new SelectList(db.OrderDetails, "id_orderdetail", "id_orderdetail", asset.id_orderdetail);
            ViewBag.id_status = new SelectList(db.Status, "id_status", "name", asset.id_status);
            return View(asset);
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
