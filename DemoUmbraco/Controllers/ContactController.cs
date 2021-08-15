using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using DemoUmbraco.Models;

namespace DemoUmbraco.Controllers
{
    public class ContactController : SurfaceController
    {
        public const string Partial_View_Path = "~/Views/Partials/SharedLayout/";
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RenderContact()
        {
            return PartialView(string.Format("{0}_ContactPartial.cshtml", Partial_View_Path));
        }

        public ActionResult SubmitForm(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                var message = Services.ContentService.Create(String.Format("{0}", model.UserName), CurrentPage.Id, "contactList");

                message.SetValue("userName", model.UserName);
                message.SetValue("phone", model.Phone);
                message.SetValue("email", model.Email);
                message.SetValue("option", model.Option);
                message.SetValue("message", model.Message);

                Services.ContentService.SaveAndPublish(message);
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();

        }
    }
}