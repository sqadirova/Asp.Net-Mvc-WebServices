using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC_WEBSERVICES.EmployeeService;

namespace ASP.NET_MVC_WEBSERVICES.Controllers
{
    public class EmployeeServiceController : Controller
    {
        public ActionResult Main()
        {
            return View();
        }

        public ActionResult getEmployee()
        {
            InputServiceClient client = new InputServiceClient();         
            List<Employee> li = client.SelectAll().ToList();
            ViewBag.List = li;

            return View();
        }

        public ActionResult insertEmployee()
        {
            return View();
            
        }

        [HttpPost]
        public ActionResult insertEmployee(Employee employee)
        {
            InputServiceClient client = new InputServiceClient();
            client.SaveEmployee(employee);
            return RedirectToAction("getEmployee");
        }

        public ActionResult updateEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult updateEmployee(Employee employee)
        {
            InputServiceClient client = new InputServiceClient();
            client.UpdateEmployee(employee);
            return RedirectToAction("getEmployee");
        }

        public ActionResult deleteEmployee(Employee employee)
        {
            InputServiceClient client = new InputServiceClient();
            client.DeleteEmployee(employee);
            return RedirectToAction("getEmployee");            
        }
    
        //[HttpPost]
        public ActionResult selectbydate(betweendate birth)
        {
            InputServiceClient client = new InputServiceClient();              
            List<Employee> li = client.Selectbydate(birth).ToList();
            ViewBag.List = li;
            return View();
            
        }

      
    }
}