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


namespace u21448567_HW06.Views.products
{
    public class ordersController : Controller
    {
        private BikeStoresEntities db = new BikeStoresEntities();

        // GET: Order
        public ActionResult Index(string currentFilter, string searchString, int? page)
        {

            var products = db.order_items.Include(p => p.product).Include(p => p.order).ToList();

            int pageSize = 10;
            int pageNumber = (page ?? 1);

            return View(products.ToList().ToPagedList(pageNumber, pageSize));
        }
    }
}