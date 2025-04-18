using Microsoft.AspNetCore.Mvc;
using My_Portfolio_DEPI.ViewModels;

namespace My_Portfolio_DEPI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            AboutViewModel AboutVM = new AboutViewModel();
            return View(AboutVM);
        }
    }
}
