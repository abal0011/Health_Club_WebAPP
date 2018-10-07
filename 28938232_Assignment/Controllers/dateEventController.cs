using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _28938232_Assignment.Controllers
{
    public class dateEventController : Controller
    {
        // GET: dateEvent
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetDateEvents()
        {
            using (Database1Entities dc = new Database1Entities())
            {
                var eventsTable = dc.EventsTables.ToList();
                return new JsonResult {Data = eventsTable, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
            }
        }
        [HttpPost]
        public JsonResult SaveEvent(EventsTable e)
        {
            var status = false;
            using (Database1Entities dc = new Database1Entities())
            {
                if (e.EventID > 0)
                {
                    //update the event
                    var v = dc.EventsTables.Where(a => a.EventID == e.EventID).FirstOrDefault();
                    if (v != null)
                    {
                        v.Subject = e.Subject;
                        v.Start = e.Start;
                        v.End = e.End;
                        v.Description = e.Description;
                        v.IsFullDay = e.IsFullDay;
                        v.ThemeColor = e.ThemeColor;

                    }
                }
                else
                {
                    dc.EventsTables.Add(e);
                }

                dc.SaveChanges();
                status = true;
            }

            return new JsonResult() { Data = new { status = status } };
        }

        [HttpPost]
        public JsonResult DeleteEvent(int eventID)
        {
            var status = false;
            using (Database1Entities dc = new Database1Entities())
            {
                var v = dc.EventsTables.Where(a => a.EventID == eventID).FirstOrDefault();
                if (v != null)
                {
                    dc.EventsTables.Remove(v);
                    dc.SaveChanges();
                    status = true;
                }
            }
                return new JsonResult{Data = new { status = status}};
        }
    }
}