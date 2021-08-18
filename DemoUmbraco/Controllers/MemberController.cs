using System;
using System.Web.Security;
using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;
using DemoUmbraco.Models;

namespace DemoUmbraco.Controllers
{
    public class MemberController : SurfaceController
    {
        // GET: Member
       
        public ActionResult MemberLogin() => PartialView("MemberLogin", new LoginModel());
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitLogin(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if(Membership.ValidateUser(model.Username, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Username, false);
                    UrlHelper urlHelper = new UrlHelper(HttpContext.Request.RequestContext);

                    if (urlHelper.IsLocalUrl(returnUrl)) 
                        return Redirect(returnUrl);
                    else
                        return Redirect("/login/");
                }
                else
                {
                    ModelState.AddModelError("", "The username or password is invalid");
                }
            }
            return CurrentUmbracoPage();
        }

        public ActionResult RenderLogout() => PartialView("MemberLogout", null);

        public ActionResult SubmitLogout()
        {
            TempData.Clear();
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToCurrentUmbracoPage();
        }
    }
}