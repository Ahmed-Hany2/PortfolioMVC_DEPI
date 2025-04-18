using Microsoft.AspNetCore.Mvc;
using My_Portfolio_DEPI.ViewModels;

namespace My_Portfolio_DEPI.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            ServicesViewModel servicesVM = new ServicesViewModel();
            return View(servicesVM);
        }
    }
}
