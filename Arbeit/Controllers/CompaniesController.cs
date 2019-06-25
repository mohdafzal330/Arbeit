using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arbeit.Controllers
{
    public class CompaniesController : Controller
    {
        // GET: Companies
        public ActionResult profile(int? CompanyId)
        {
            if (!CompanyId.HasValue)
            {
                //redirect to not found
            }
            return View();
        }
        public ActionResult UserProfile()
        {
            return View();
        }
    }
}