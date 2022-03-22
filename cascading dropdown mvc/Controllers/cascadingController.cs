using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cascading_dropdown_mvc.Models;

namespace cascading_dropdown_mvc.Controllers
{
    public class cascadingController : Controller
    {
        //
        // GET: /cascading/
        

        public ActionResult Index()
        {
            test3Entities1 tsentity = new test3Entities1();

            List<ddl> list = new List<Models.ddl>()
            {
                new ddl{
                id=0,
                name="Please select"
                }
            };
            usercountry ucmodel = new usercountry();
            ucmodel.countylist = new SelectList(getcountrylist(), "countryid", "countryname");
            ucmodel.statelist=new SelectList(list,"id","name");
            ucmodel.citylist = new SelectList(list, "id", "name");
            return View(ucmodel);
        }

        public List<country> getcountrylist()
        {
            test3Entities1 tsentity = new test3Entities1();
            usercountry ucmodel = new usercountry();
            var licountry = tsentity.countries.ToList();
            return licountry;
        }

        public JsonResult GetStatesByCountryId(int countryid)
        {
            using (test3Entities1 db = new test3Entities1())
            {
                List<state> lstStates = new List<state>();
                lstStates = db.states.Where(x => x.countryid == countryid).ToList();
                usercountry uc = new usercountry();
                uc.statelist = new SelectList(lstStates, "stateid", "statename");
                return Json(uc.statelist, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult GetcityByStateId(int stateid)
        {
            using (test3Entities1 db = new test3Entities1())
            {
                List<city> lstCities = new List<city>();
                lstCities = db.cities.Where(x => x.stateid == stateid).ToList();
                usercountry uc = new usercountry();
                uc.citylist = new SelectList(lstCities, "cityid", "cityname");
                return Json(uc.citylist, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
