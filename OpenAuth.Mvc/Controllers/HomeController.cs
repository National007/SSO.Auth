using Microsoft.AspNetCore.Mvc;
using OpenAuth.App.Interface;
using OpenAuth.App.SSO;

namespace OpenAuth.Mvc.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var re = Request;
            var header = Response.Headers["token"];
            return View();
        }

        public ActionResult Main()
        {
            return View();
        }
       
       
        
        public ActionResult Git()
        {
            return View();
        }


        public HomeController(IAuth authUtil) : base(authUtil)
        {
        }
    }
}