using My_Portfolio_DEPI.Models;

namespace My_Portfolio_DEPI.ViewModels
{
    public class TestimonialViewModel
    {
        private Testimonial _testimonialInfo = new Testimonial
        {
         teamMembers = 3,
         completeProjects = 6,
         filesDownloaded = 33,
         linesOfCode = "5k",
        };
        public Testimonial TestimonialInfo => _testimonialInfo;
    }
}
