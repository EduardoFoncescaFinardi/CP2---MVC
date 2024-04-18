using CP2___MVC.Data;
using CP2___MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;



namespace CP2___MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _dataContext;

        public HomeController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _dataContext = dataContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Register(User resquest)
        {
            var user = _dataContext.MVC_Usuarios.FirstOrDefault(x => x.Email == resquest.Email);
            if (user != null)
            {
                return BadRequest("Usuário ja existe");
            }
            User newUser = new User
            {
                Id = resquest.Id,
                Email = resquest.Email,
                Password = resquest.Password,
            };
            _dataContext.Add(newUser);
            _dataContext.SaveChanges();
            return View();
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