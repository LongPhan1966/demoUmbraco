using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using System.Web.Mvc;

namespace DemoUmbraco.Controllers
{
    public class SiteSharedLayoutController:SurfaceController
    {
        public ActionResult RenderHeader() => PartialView("~/Views/Partials/SharedLayout/Header.cshtml");

        public ActionResult RenderFooter() => PartialView("~/Views/Partials/SharedLayout/Footer.cshtml");
    }
}