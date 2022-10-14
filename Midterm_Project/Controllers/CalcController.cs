using Midterm_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Midterm_Project.Controllers
{
    public class CalcController : Controller
    {
        //By John Patrick Haguimit SBIT3Q
        // GET: Calc
        public ActionResult Index()
        {
            return View(new calc());
        }

        [HttpPost]

        //Dito yung mga math 
        public ActionResult Index(calc c,string calculate)
        {
            if(calculate == "circle") 
            {
                
                c.total = Math.PI * c.no1 * c.no1;
            }
            else if (calculate == "triangle")
            {
                c.triangleTotal = (c.triangle1 * c.triangle2) / 2;
            }
            else if (calculate == "square")
            {
                c.squareTotal = c.square1 * c.square1;
            }
            else
            {
                c.rectangleTotal = c.rectangle1 * c.rectangle2;
            }
            return View(c);
        }   

    }
}