using MiniPhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniPhoneBook.Controllers
{
    public class HomeController : Controller
    {
        string constr = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(ASPNetUsers collection)
        {
            try
            {
                // Do not initialize this variable here. 
                AspNetUser obj = new AspNetUser();
                obj.PasswordHash = collection.Password;
                obj.UserName = collection.UserName;
                obj.Id = collection.UserID;
                obj.Email = collection.EmailID;
                PhoneBookDbEntities db = new PhoneBookDbEntities();
                db.AspNetUsers.Add(obj);
                return RedirectToAction("Index");

            }
            catch(Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "collection", "Create"));
            }

        }
        public ActionResult Enter(string FirstName)
        {
            try
            {
                // Do not initialize this variable here. 
                AspNetUser obj = new AspNetUser();
               // obj.PasswordHash = collection.Password;
                obj.UserName = FirstName;
               // obj.Id = collection.UserID;
                //obj.Email = collection.EmailID;
                PhoneBookDbEntities db = new PhoneBookDbEntities();
                db.AspNetUsers.Add(obj);
                db.SaveChanges();

                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "collection", "Create"));
            }

        }
        public ActionResult DashBoard()
        {
            return View();

        }

        public ActionResult Person()
        {
            return View();
        }

    }
}