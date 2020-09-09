using BackstageMusic.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;

namespace BackstageMusic.Controllers
{
    public class UserController : Controller
    {
        private BackstageMusicDB db = new BackstageMusicDB();

        public ActionResult Login()
        {
            if (Session["username"] == null)
            {
                return View();
            }
            else
                return RedirectToAction("Index", "Home", null);
        }
        public ActionResult Logout()
        {
            Session["username"] = null;
            return Json(new { status = true, message = "Logout Successfull!" });

        }

        public ActionResult Validate(User user)
        {
            User _user = db.Users.Where(s => s.username == user.username).SingleOrDefault();

            if (_user != null)
            {
                Session["type"] = _user.UserType.name;
                HashAlgorithm algorithm = SHA256.Create();
                if (VerifyPassword(algorithm, user.password, _user.password))
                {
                    Session["username"] = user.username;
                    if (_user.UserType.name == "Admin")
                    {
                        Session["menu"] = "~/Views/Shared/_MenuAdmin.cshtml";
                    }
                    else
                    {
                        Session["menu"] = "~/Views/Shared/_MenuUser.cshtml";
                    }
                    return Json(new { status = true, message = "Inicio de sesión exitoso" });
                }
                else
                {
                    return Json(new { status = false, message = "Contraseña invalida" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Correo electrónico invalido" });
            }
        }

        // GET: User
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.Country).Include(u => u.UserType);
            return View(users.ToList());
        }

        // GET: User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            ViewBag.id_country = new SelectList(db.Countries, "id_country", "name");
            ViewBag.id_usertype = new SelectList(db.UserTypes, "id_usertype", "name");
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.id_country = new SelectList(db.Countries, "id_country", "name");
            ViewBag.id_usertype = new SelectList(db.UserTypes, "id_usertype", "name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserRequest request)
        {
            User user = request.getUser();

            if (db.Users.Where(s => s.username == user.username).SingleOrDefault() == null)
            {
                if (ModelState.IsValid)
                {
                    using (SHA256 sha256Hash = SHA256.Create())
                    {
                        user.password = GetHash(sha256Hash, user.password);
                    }
                    db.Users.Add(user);
                    db.SaveChanges();
                    switch (user.id_usertype)
                    {
                        case 2: //Usertype is Artist
                            Artist artist = new Artist();
                            artist.id_user = user.id_user;
                            artist.name = user.username;
                            db.Artists.Add(artist);
                            break;
                        case 3: //Usertype is Manager
                            Manager manager = new Manager();
                            manager.id_user = user.id_user;
                            manager.name = user.username;
                            db.Managers.Add(manager);
                            break;
                        case 4: //Usertype is Label
                            Label label = new Label();
                            label.id_user = user.id_user;
                            label.name = user.username;
                            db.Labels.Add(label);
                            break;
                    }
                    db.SaveChanges();
                    TempData["UserCreated"] = true;
                    return RedirectToAction("Login");
                }
            }
            else
            {
                ViewBag.id_country = new SelectList(db.Countries, "id_country", "name");
                ViewBag.id_usertype = new SelectList(db.UserTypes, "id_usertype", "name");
                ModelState.AddModelError("username", "El nombre de usuario ya existía");
                return View("Register");
            }

            ViewBag.id_country = new SelectList(db.Countries, "id_country", "name", user.id_country);
            ViewBag.id_usertype = new SelectList(db.UserTypes, "id_usertype", "name", user.id_usertype);
            return View("Create");
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        private static bool VerifyPassword(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            var hashOfInput = GetHash(hashAlgorithm, input);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }

        // GET: User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_country = new SelectList(db.Countries, "id_country", "name", user.id_country);
            ViewBag.id_usertype = new SelectList(db.UserTypes, "id_usertype", "name", user.id_usertype);
            return View(user);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_user,name,password,email,id_usertype,is_suscribed,is_confirmed,primary_address,secondary_address,city,zipcode,id_country,voucher,active,created_at,updated_at")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_country = new SelectList(db.Countries, "id_country", "name", user.id_country);
            ViewBag.id_usertype = new SelectList(db.UserTypes, "id_usertype", "name", user.id_usertype);
            return View(user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public class UserRequest
        {
            public User getUser()
            {
                User user = new User();
                user.password = password;
                user.username = username;
                user.id_country = id_country;
                user.id_usertype = id_usertype;
                return user;
            }
            public string password { get; set; }
            public string username { get; set; }
            public int id_country { get; set; }
            public int id_usertype { get; set; }
        }
    }
}
