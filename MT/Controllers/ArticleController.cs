using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using MT.Models;

namespace MT.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/
        public ActionResult Index()
        {
            IEnumerable<ArticleMvcModel> ArticleList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Article").Result;
            ArticleList = response.Content.ReadAsAsync<IEnumerable<ArticleMvcModel>>().Result;
            return View(ArticleList);
        }
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new ArticleMvcModel());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Article/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<ArticleMvcModel>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(ArticleMvcModel article)
        {
            if (article.ARTID == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Article", article).Result;
                TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Article/" + article.ARTID, article).Result;
                TempData["SuccessMessage"] = "Updated Successfully";
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Article/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
   
    }
}
