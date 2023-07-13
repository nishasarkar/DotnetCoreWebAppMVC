using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            return View();// acess by  https://localhost:7178/
        }
        public string Hello(string name)
        {
            // return "my name is niha sarkar";// acess by https://localhost:7178/Home/Hello

            return "my name is niha sarkar" + name;// acess by https://localhost:7178/Home/hello?name=piu
        }

        public string HelloMultiple(string name,string address)
        {
           

            return "my name is niha sarkar" + name+address;// acess by https://localhost:7178/Home/hellomultiple?name=piu&address=kolkata
        }

        public string Admission(Student student)// query string data pass
        {
            return "Name"+student.Name + "Address "+student.Address+"Email"+student.Email+"fathers"+student.FathersName;
            // acess by the url - https://localhost:7178/Home/Admission?Name=nisha&Address=kolkata&Email=@gmail.com&FathersName=Upendra 


        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}