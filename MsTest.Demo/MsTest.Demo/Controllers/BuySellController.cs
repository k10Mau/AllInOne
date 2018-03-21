using Microsoft.AspNet.Identity;
using Mstest.Demo.DAL;
using MsTest.Demo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsTest.Demo.Controllers
{
   [Authorize]
    public class BuySellController : Controller
    {
        // GET: BuySell
        private ManageStockService _stockService;
        public BuySellController()
        {
            this._stockService = new ManageStockService();
        }
       public ActionResult Buy()
       {
           ViewBag.StockList = _stockService.GetAllStocks();
            var model = new TrandingTransactionHistory();
            return View(model);
        }
        [HttpPost]
        public ActionResult Buy(TrandingTransactionHistory buyInfo)
        {
            buyInfo.UserId=User.Identity.GetUserId();
            buyInfo.TransactionType = "Buy";
            _stockService.AddTransaction(buyInfo);
            return RedirectToAction("Buy");
        }
    }
}