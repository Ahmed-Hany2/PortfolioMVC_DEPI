using Microsoft.AspNetCore.Mvc;
using My_Portfolio_DEPI.ViewModels;

namespace My_Portfolio_DEPI.Controllers
{
    public class TestimonialController : Controller
    {
        public IActionResult Index()
        {
            TestimonialViewModel testimonialVM = new TestimonialViewModel();
            return View(testimonialVM);
        }
    }
}
