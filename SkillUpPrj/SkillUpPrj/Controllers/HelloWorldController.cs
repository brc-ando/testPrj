using System.Web.Mvc;

namespace SkillUpPrj.Controllers
{	
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }

		//
		// GET: /HelloWorld/Welcome

		public string Welcome(string name, int numTimes = 1)
		{
			return "Welcome " + name + ". 訪問回数 " + numTimes + " 回目";
		}

		//
        // GET: /HelloWorld/Details/5

		public string Details(int id)
        {
            return "Hello World Details ";
        }

        //
        // GET: /HelloWorld/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /HelloWorld/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /HelloWorld/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /HelloWorld/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /HelloWorld/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /HelloWorld/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
