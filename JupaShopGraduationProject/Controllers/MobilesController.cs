using JupaShopGraduationProject.BL.Interface;
using JupaShopGraduationProject.DAL.Entities;
using JupaShopGraduationProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JupaShopGraduationProject.Controllers
{
    public class MobilesController : Controller
    {
        private readonly IMobilesRep mobile;

        public MobilesController(IMobilesRep mob)
        {
            mobile = mob;
        }
        public IActionResult Index()
        {
            var data = mobile.Get();

            return View(data);
        }

        // Create Data
        // Defult [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MobilesVM mob)
        {
            try
            {
                // check data validation
                if (ModelState.IsValid)
                {
                    mobile.Add(mob);
                    return RedirectToAction("Index", "Mobiles");
                }
                return View(mob);

            }
            catch (Exception /*ex*/)
            {
                //// using System.Diagnostics;
                //// this error mean i can't use EventLog on macOS just windows
                //EventLog log = new EventLog();
                //log.Source = "Mobiles Page";
                //log.WriteEntry(ex.Message, EventLogEntryType.Error);


                return View(mob); // return with data
            }

        }

        // Edit Data
        public IActionResult Edit(int id)
        {
            var data = mobile.GetById(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(MobilesVM mob)
        {
            try
            {
                // check data validation
                if (ModelState.IsValid)
                {
                    mobile.Edit(mob);
                    return RedirectToAction("Index", "Mobiles");
                }
                else
                {
                    return View(mob);
                }

            }
            catch (Exception /*ex*/)
            {
                //// using System.Diagnostics;
                //// this error mean i can't use EventLog on macOS just windows
                //EventLog log = new EventLog();
                //log.Source = "Mobiles Page";
                //log.WriteEntry(ex.Message, EventLogEntryType.Error);


                return View(mob); // return with data

            }
        }

        // Delete Data
        public IActionResult Delete(int id)
        {
            var data = mobile.GetById(id);
            return View(data);
        }

        [HttpPost]
        [ActionName("Delete")] // run time name
        public IActionResult ConfirmDelete(int id) // compile time name
        {
            try
            {
                // check data validation
                mobile.Delete(id);
                return RedirectToAction("Index", "Mobiles");
            }
            catch (Exception /*ex*/)
            {
                //// using System.Diagnostics;
                //// this error mean i can't use EventLog on macOS just windows
                //EventLog log = new EventLog();
                //log.Source = "Mobiles Page";
                //log.WriteEntry(ex.Message, EventLogEntryType.Error);


                return View(); // return with data

            }
        }

    }
}
