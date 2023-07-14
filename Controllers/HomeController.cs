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
        //FOLDER STRUCTURE

        //1> in model folder all the objects are going to keep.that is going to use in our project.
        //2>controller the presentation logic we are going to write like button click and dropdowmn value howing
        //3>controller having action like HomeController.cs file having two action "public IActionResult Index()" that is papping 
        //with in views folder having Home subfolder there in home folder of views there is index.cshtml file is mapped similarly
        //"IActionResult Privacy()" is mapped with Privacy.cshtml,
        //instead of view pages or file name(ex-Index.cshtml), we are mentioning the controller and action.
        //shared folder in home in view is common for all controllers and all action if any file for example if 
        //index.cshtml is not founded on the in home of view folder then it will loook for shared folder so to search 
        //for index folder.

        //if its not find the index.cshtml is not found in the home of views and shared folder then its showing error.cshtml

        //_viewStart.cshtml that is helping us to serve to provide default master or layout page,role-for providing consistent of look
        //of web like header and footer is consistent for example in views in shared folder in _layout.cshtml the header part and footer part consistent but the container
        //part or renderbody part is rendering the dynamic part of the web that is changing if page changes.
        //razor is view engine for making view as dynamic and razor pages is a different style of building the website,
        //razor pages,razor(markup syntex which is help to make pages dynamic),and blazor this three combine view engine as razor.
        //.net 6 the having hot reload-
        //using scuffolding vs do generate the code.
        //whennever middleware having two section one is request part another is response part. so middleare are using
        //to intercept the request and response both or either anyone response or request.
        //evry middleware executed using Top to bottom approach



    }
}