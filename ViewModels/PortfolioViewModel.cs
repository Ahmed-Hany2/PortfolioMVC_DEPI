using My_Portfolio_DEPI.Models;

namespace My_Portfolio_DEPI.ViewModels
{
    public class PortfolioViewModel
    {
        private List<PortfolioItem> _portfolioItems = new List<PortfolioItem>
        {
            new PortfolioItem
            {
                imgURL = "./images/portfolio/1.jpg",
                iconCode = "fa fa-file-image",
            },

            new PortfolioItem
            {
                imgURL = "./images/portfolio/2.jpg",
                iconCode = "fa fa-link",
            },

            new PortfolioItem
            {
                imgURL = "./images/portfolio/3.jpg",
                iconCode = "fa fa-file-video",
            },

            new PortfolioItem
            {
                imgURL = "./images/portfolio/4.jpg",
                iconCode = "fa fa-file-image",
            },

            new PortfolioItem
            {
                imgURL = "./images/portfolio/5.jpg",
                iconCode = "fa fa-link",
            },

            new PortfolioItem
            {
                imgURL = "./images/portfolio/6.jpg",
                iconCode = "fa fa-file-video",
            },
        };
        public List<PortfolioItem> PortfolioItems => _portfolioItems;
    }
}
