using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using DemoUmbraco.Models;

namespace DemoUmbraco.Controllers
{
    public class TestDriverController : SurfaceController
    {
    public const string RegisterTest_View = "~/Views/Partials/SharedLayout/";
    // GET: TestDriver
    public ActionResult Index()
        {
            return View();
        }

        public ActionResult RenderRegisterTestDriver()
        {
            return PartialView(string.Format("{0}_RegisterTestDriver.cshtml", RegisterTest_View));
        }

        public ActionResult RegisterForm(RegisterTestDriverModel model)
        {
            if (ModelState.IsValid)
            {
                var register = Services.ContentService.Create(String.Format("{0}", model.RegisterName), CurrentPage.Id, "testDriverList");

                register.SetValue("registerName", model.RegisterName);
                register.SetValue("registerPhone", model.RegisterPhone);
                register.SetValue("area", model.Area);
                register.SetValue("showroom", model.Showroom);

                Services.ContentService.SaveAndPublish(register);
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();
        }
    }
}