using Mstest.Demo.DAL;
using MsTest.Demo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsTest.Demo.Controllers
{
    public class ManageStockController : Controller
    {
        // GET: ManageStock

        private ManageStockService _stockService;
        public ManageStockController()
        {
            this._stockService = new ManageStockService();
        }
        public ActionResult Index()
        {
            var list=_stockService.GetAllStocks();
            return View(list);
        }

        // GET: ManageStock/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManageStock/Create
        public ActionResult Create()
        {
            var model = new Stock();
            return View(model);
        }

        // POST: ManageStock/Create
        [HttpPost]
        public ActionResult Create(Stock stock)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _stockService.AddStock(stock);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ManageStock/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManageStock/Edit/5
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

        // GET: ManageStock/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManageStock/Delete/5
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
