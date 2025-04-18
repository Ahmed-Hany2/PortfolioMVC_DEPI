using My_Portfolio_DEPI.Models;

namespace My_Portfolio_DEPI.ViewModels
{
    public class AboutViewModel
    {
        private About _aboutInfo = new About
        {
            Summary = "Front End Developer with experience in developing and designing applications and systems using modern technologies. I have the ability to work in all aspects of front end development. I use technologies such as React, Redux, TailwindCSS to provide distinct technical solutions that ensure high performance and efficiency at work.",
            Name = "Ahmed Hany",
            JobTitle = "Full Stack .NET Developer",
            Age = 22,
            Location = "El-Mahalla El-Kubra, Egypt",
            Freelance = "Available",
            Email = "ahmedhanypro2@gmail.com",
        };
        public About AboutInfo => _aboutInfo;
    }
}
