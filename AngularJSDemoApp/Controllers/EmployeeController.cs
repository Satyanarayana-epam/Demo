using AngularJSDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularJSDemoApp.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetAllEmployees()
        {
            var employees = new List<Employee>()
            {
                new Employee() { FirstName = "FN1", LastName = "LN1", Age = "25", City = "Hyderabad", State = "TS" },
                new Employee() { FirstName = "FN2", LastName = "LN2", Age = "30", City = "Vijayawada", State = "AP" },
                new Employee() { FirstName = "FN3", LastName = "LN3", Age = "35", City = "Bangalore", State = "KA" },
                new Employee() { FirstName = "FN4", LastName = "LN4", Age = "40", City = "Chennai", State = "TN" }
            };

            return Json(employees, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllStates()
        {
            var states = new List<State>()
            {
                new State(){Id="1", StateName="TS" },
                new State(){Id="2", StateName="AP" },
                new State(){Id="3", StateName="KA" },
                new State(){Id="4", StateName="TN" },
            };
            return Json(states, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllCities()
        {
            var cities = new List<City>()
            {
                new City(){Id="1", StateId = "1", CityName="Hyderabad" },
                new City(){Id="2", StateId = "2", CityName="Vijayawada" },
                new City(){Id="3", StateId = "3", CityName="Bangalore" },
                new City(){Id="4", StateId = "4", CityName="Chennai" },
            };
            return Json(cities, JsonRequestBehavior.AllowGet);
        }
    }
}