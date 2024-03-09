using Microsoft.AspNetCore.Mvc;
using Registration_and_login_forms.Models;

namespace Registration_and_login_forms.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessLogin(UserModel userModel)
        {   
            if (userModel.Username == "BillGates" && userModel.Password == "bigbucks")
            { 
                return View("LoginSuccess", userModel);
            }else
            {
                return View("LoginFailure", userModel);
            }
        }  


    }
}
