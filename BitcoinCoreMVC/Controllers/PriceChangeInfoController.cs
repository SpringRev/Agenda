using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BitcoinCoreMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BitcoinCoreMVC.Controllers
{
    public class PriceChangeInfoController : Controller
    {
        // GET: PriceChangeInfoController
        public async Task<ActionResult> Index()
        {

            List<PriceChangeInfo> arrayOfSymbolPrice = new List<PriceChangeInfo>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44318/api/values"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    arrayOfSymbolPrice = JsonConvert.DeserializeObject<List<PriceChangeInfo>>(apiResponse);
                }
            }
            return View(arrayOfSymbolPrice);

            //IEnumerable<ArrayOfSymbolPrice> arrayOfSymbolPrices = null;

            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("https://localhost:44318/api/values");
            //    //HTTP GET
            //    var responseTask = client.GetAsync("arrayOfSymbolPrice");
            //    responseTask.Wait();

            //    var result = responseTask.Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        var readTask = result.Content.ReadAsAsync<IList<ArrayOfSymbolPrice>>();
            //        readTask.Wait();

            //        arrayOfSymbolPrices = readTask.Result;
            //    }
            //    else //web api sent error response 
            //    {
            //        //log response status here..

            //        arrayOfSymbolPrices = Enumerable.Empty<ArrayOfSymbolPrice>();

            //        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            //    }
            //}
            //return View(arrayOfSymbolPrices);
        }
        // GET: PriceChangeInfoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PriceChangeInfoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PriceChangeInfoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PriceChangeInfoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PriceChangeInfoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PriceChangeInfoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PriceChangeInfoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
