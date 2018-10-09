using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniPhoneBook.Controllers
{
    public class PhonebookController : Controller
    {
        // GET: Phonebook
        public ActionResult Index()
        {
            return View();
        }

        // GET: Phonebook/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Phonebook/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Phonebook/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Phonebook/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Phonebook/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Phonebook/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Phonebook/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
