using Microsoft.AspNetCore.Mvc;
using CP2___MVC.Data;


namespace CP2___MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly ILogger<UsersController> _logger;

        public UsersController(DataContext dataContext, ILogger<UsersController> logger)
        {
            _dataContext = dataContext;
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

    }
}