using BackstageMusic.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace BackstageMusic.Controllers
{
    public class InvitationController : Controller
    {
        private BackstageMusicDB db = new BackstageMusicDB();

        // GET: Invitation
        public ActionResult Index()
        {
            var invitations = db.Invitations.Include(i => i.Invitee).Include(i => i.Inviter);
            return View(invitations.ToList());
        }

        // GET: Invitation/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invitation invitation = db.Invitations.Find(id);
            if (invitation == null)
            {
                return HttpNotFound();
            }
            return View(invitation);
        }

        // GET: Invitation/Create
        public ActionResult Create()
        {
            ViewBag.id_invitee = new SelectList(db.Users, "id_user", "username");
            ViewBag.id_inviter = new SelectList(db.Users, "id_user", "username");
            return View();
        }

        // POST: Invitation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_invitation,id_inviter,id_invitee,accepted_on,active,created_at,updated_at")] Invitation invitation)
        {
            if (ModelState.IsValid)
            {
                db.Invitations.Add(invitation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_invitee = new SelectList(db.Users, "id_user", "username", invitation.id_invitee);
            ViewBag.id_inviter = new SelectList(db.Users, "id_user", "username", invitation.id_inviter);
            return View(invitation);
        }

        // GET: Invitation/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Invitation invitation = db.Invitations.Find(id);
            if (invitation == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_invitee = new SelectList(db.Users, "id_user", "username", invitation.id_invitee);
            ViewBag.id_inviter = new SelectList(db.Users, "id_user", "username", invitation.id_inviter);
            return View(invitation);
        }

        // POST: Invitation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_invitation,id_inviter,id_invitee,accepted_on,active,created_at,updated_at")] Invitation invitation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(invitation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_invitee = new SelectList(db.Users, "id_user", "username", invitation.id_invitee);
            ViewBag.id_inviter = new SelectList(db.Users, "id_user", "username", invitation.id_inviter);
            return View(invitation);
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
