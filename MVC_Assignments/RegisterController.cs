using MVCRegistrationForm1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MVCRegistrationForm1.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Index()
        {
            RegisterEntities db = new RegisterEntities();
            return View(db.Register_details.ToList());
        }
       
        public ActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(Register_details obj)
        {
            if (ModelState.IsValid)
            {
                using (RegisterEntities db = new RegisterEntities())
                { 
                    db.Register_details.Add(obj);
                    obj.Created_at = DateTime.Now;
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = obj.FirstName + " ,successfully saved the details";
                return View();
            }

            return View(obj);
        }
        public ActionResult Delete(int id)
        {
            using (RegisterEntities db = new RegisterEntities())
            {
                return View(db.Register_details.Where(X => X.RegisterId == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Delete(int id, Register_details obj)
        {
            using (RegisterEntities db = new RegisterEntities())
            {
                Register_details detail = db.Register_details.Where(x => x.RegisterId == id).FirstOrDefault();
                db.Register_details.Remove(detail);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            using (RegisterEntities db = new RegisterEntities())
            {
                return View(db.Register_details.Where(X => X.RegisterId == id).FirstOrDefault());
            }

        }
        [HttpPost]
        public ActionResult Edit(int id,Register_details obj)
        {
            using (RegisterEntities db = new RegisterEntities())
            {
                obj.Created_at = DateTime.Now;
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();
            }
            ViewBag.EditMessage = obj.FirstName + " ,successfully edited the details";
            return RedirectToAction("Index");

        }


    }
}