using SVGCodingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SVGCodingTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() //change graph.
        {
            int[] twentyEighteen = new int[] { 200, 100, 150, 40, 11 }; //this data can be loaded from database.
            ViewBag.twentyEighteen = twentyEighteen;

            int[] twentyNinteen = new int[] { 220, 94, 168, 55, 14 }; //this data can be loaded from database.
            ViewBag.twentyNinteen = twentyNinteen;

            string[] categories = new string[] { "Bicycle", "Car", "Truck", "Motorcycle", "Jet" }; //this data can be loaded from database.
            ViewBag.categories = categories;

            return View();
        }
        public ActionResult MarketShare()
        {
            List<ValuesModel> lstModel = new List<ValuesModel>(); //we can populate this list by db collection.
            lstModel.Add(new ValuesModel() {  Name = "Bicycle", Y = 61.41M } );
            lstModel.Add(new ValuesModel() {  Name = "Car", Y = 11.84M } );
            lstModel.Add(new ValuesModel() {  Name = "Truck", Y = 10.85M } );
            lstModel.Add(new ValuesModel() {  Name = "Motorcycle", Y = 4.67M } );
            lstModel.Add(new ValuesModel() {  Name = "Jet", Y = 4.18M } );
            return View(lstModel);
        }

       
    }

   
}