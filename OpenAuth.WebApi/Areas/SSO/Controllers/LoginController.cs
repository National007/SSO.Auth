using System;
using Microsoft.AspNetCore.Mvc;
using OpenAuth.App.SSO;

namespace OpenAuth.WebApi.Areas.SSO.Controllers
{
    [Area("sso")]
    /// <summary>
    ///  SSO自带的登录处理
    /// <para>第三方网站如果自己不开发登录界面，可直接跳转到本界面进行登录</para>
    /// </summary>
    public class LoginController : Controller
    {
        private AppInfoService _appInfoService;

        private LoginParse _loginParse;

        public LoginController(AppInfoService appInfoService,LoginParse loginParse)
        {
            _appInfoService = appInfoService;
            _loginParse = loginParse;
        }

        private const string AppInfo = "AppInfo";

        //加载登录界面
        public ActionResult Index(string appKey = "", string username = "")
        {
            TempData[AppInfo] = _appInfoService.Get(appKey);

            var viewModel = new PassportLoginRequest
            {
                AppKey = appKey,
                Account = username,
            };

            return View(viewModel);
        }

        //授权登录
        [HttpPost]
        public ActionResult Index(PassportLoginRequest model)
        {
            var result = _loginParse.Do(model);

            if (result.Code ==200)
            {
                //var redirectUrl = string.Format("{0}?token={1}&sessionusername={2}", result.ReturnUrl, result.Token, model.Account);
                var redirectUrl = result.ReturnUrl;
                Response.Headers.Add("token","23323");
                HttpContext.Request.Headers.Add("request", "2323");
                HttpContext.Response.Cookies.Append("cookie","2332322");
                return Redirect(redirectUrl);
            }

            TempData[AppInfo] = _appInfoService.Get(model.AppKey);
            return View(model);
        }
    }
}