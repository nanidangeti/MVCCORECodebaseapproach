using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MVCCORECodebaseapproach.Data;

namespace MVCCORECodebaseapproach.Controllers
{
    public class EmployeeController1 : Controller
    {
        private ApplicationContext _applicationContext;
        public EmployeeController1(ApplicationContext applicationContext) 
        {  
            _applicationContext = applicationContext; 
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetListofEmployees()
        {
            var result = _applicationContext.Employees.ToList();
            if(result.Count <= 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(result);
            }
            
        }
    }
}
