using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Models;


namespace MyFirstProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
       
            return View();
        }

      
        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult StudentDetail()
        {
            List<StudentDetails> std = new List<StudentDetails>()
            {
                new StudentDetails(){Name="Sahil",RollNo=01,Course= "Python",Fee= 50000,Address="Srinagar"},
                new StudentDetails(){Name = "Tanveer",RollNo=02,Course= "Java",Fee= 60000,Address="Srinagar"},
                new StudentDetails(){Name ="Zara",RollNo= 03 , Course = "C#", Fee= 70000, Address="Humhama"},
                new StudentDetails(){Name = "Aman",RollNo= 04,Course= "C++",Fee= 80000,Address="Srinagar"},
                new StudentDetails(){Name = "Rohit",RollNo= 05,Course= "JavaScript",Fee= 90000,Address="Budgam"}
            };
            return View(std);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
