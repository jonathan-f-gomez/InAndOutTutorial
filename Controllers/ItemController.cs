using Microsoft.AspNetCore.Mvc;
using InAndOutTutorial.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InAndOutTutorial.Models;

namespace InAndOutTutorial.Controllers
{
    public class ItemController : Controller
    {

        private readonly ApplicationDBContext _db;

        public ItemController(ApplicationDBContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }

        //Get-Create Funtion
        public IActionResult Create()
        {
            return View();
        }
        
        //Post-Create Funtion
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
