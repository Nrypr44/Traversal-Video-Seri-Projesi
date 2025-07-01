using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]

    public class DestinationController : Controller
    {
       

        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

        public IActionResult GetCitiesSearchByName(string searchString)
        {

            if (!string.IsNullOrEmpty(searchString))
            {
                ViewData["CurrentFilter"] = searchString.ToLower();
                searchString = searchString.ToLower(); 
                var values = from x in destinationManager.TGetList() select x;

               
                values = values.Where(y => y.City.ToLower().Contains(searchString));

                return View(values.ToList());
            }
            else
            {
                
                var values = from x in destinationManager.TGetList() select x;
                return View(values.ToList());
            }
        }
    }
}
