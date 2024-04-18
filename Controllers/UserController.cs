using Microsoft.AspNetCore.Mvc;
using CP2___MVC.Data;


namespace CP2___MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly DataContext _dataContext;

        public UsersController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Login()
        {
            return View();
        }

    }
}