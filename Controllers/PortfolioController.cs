using Microsoft.AspNetCore.Mvc;
using My_Portfolio_DEPI.ViewModels;

namespace My_Portfolio_DEPI.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            PortfolioViewModel portfolioVM = new PortfolioViewModel();
            return View(portfolioVM);
        }
    }
}
