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
    public class SymbolPriceController : Controller
    {
        // GET: SymbolPriceController
        public async Task<ActionResult> Index()
        {

            List<SymbolPrice> arrayOfSymbolPrice = new List<SymbolPrice>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44318/api/values"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    arrayOfSymbolPrice = JsonConvert.DeserializeObject<List<SymbolPrice>>(apiResponse);
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

        // GET: SymbolPriceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SymbolPriceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SymbolPriceController/Create
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

        // GET: SymbolPriceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SymbolPriceController/Edit/5
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

        // GET: SymbolPriceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SymbolPriceController/Delete/5
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
