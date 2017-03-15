    namespace Sitecore.Client.LicenseOptions.Controllers
    {
    using Security.Accounts;
    using Sitecore;
    using Sitecore.Text;
    using Sitecore.Web;
    using Sitecore.Web.Authentication;
    using System.Web.Mvc;

    public class BoostUsersInvalidatorController : Controller
        {
            [HttpGet]
            public ActionResult Invalidate()
            {
                Boost.Invalidate();
                UrlString str = new UrlString(WebUtil.GetFullUrl(new StartUrlManager().GetStartUrl(Context.User)));
                base.Response.Redirect(str.ToString());
                return base.Content("Boost cache is cleaned up");
            }
        }
    }
