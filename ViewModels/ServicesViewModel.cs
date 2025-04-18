using My_Portfolio_DEPI.Models;
namespace My_Portfolio_DEPI.ViewModels
{
    public class ServicesViewModel
    {
        private List<Service> _services = new List<Service>
        {
            new Service
            {
                serviceName = "UI/UX DESIGN",
                serviceDescription = "have a strong grasp of UI/UX design principles and consistently create user-centered interfaces.",
                iconCode = "fa-solid fa-pen-ruler",
            },
            new Service
            {
                serviceName = "FRONT END DEVELOPMENT",
                serviceDescription = "capable of building responsive, efficient, and scalable websites and web applications",
                iconCode = "fa-solid fa-laptop-code",
            },
            new Service
            {
                serviceName = "BACK END DEVELOPMENT",
                serviceDescription = "proficient in designing and implementing scalable, high-performance server-side architectures.",
                iconCode = "fa-solid fa-gears",
            },
             new Service
            {
                serviceName = "PRODUCT MAINTENANCE",
                serviceDescription = "proficient in web maintenance, ensuring websites remain secure, up-to-date, and fully functional.",
                iconCode = "fa-solid fa-chart-line",
            },

        };
        public List<Service> Services => _services;
    }
}
