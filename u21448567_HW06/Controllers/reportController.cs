using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21448567_HW06.Models;
using System.Web.UI.DataVisualization.Charting;
using System.IO;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using u21448567_HW06.Models;
using PagedList.Mvc;
using PagedList;


namespace u21448567_HW06.Controllers
{
    public class reportController : Controller
    {
        private BikeStoresEntities db = new BikeStoresEntities();
        // GET: Report
        public async Task<ActionResult> Index()
        {
            var order = db.orders.Include(o => o.customer).Include(o => o.staff).Include(o => o.store);
            return View(await order.ToListAsync());
        }
    }
}