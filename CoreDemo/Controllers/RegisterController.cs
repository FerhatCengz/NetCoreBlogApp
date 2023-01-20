using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccsessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager _writerManager = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(Writer writer, string WriterRepeatPassword)
        {
            WriterValidatior rulesWv = new WriterValidatior();

            ValidationResult result = rulesWv.Validate(writer);
            if (result.IsValid)
            {
                writer.WriterBool = true;
                writer.WriterAbout = "Deneme Test";
                if (writer.WriterPassword == WriterRepeatPassword) { _writerManager.InsertWriter(writer); ViewBag.PasswordNotEquals = "Kayıt İşlemi Başarılı ( Hoş Geldin )"; }
                else ViewBag.PasswordNotEquals = "Şireler Uyuşmuyor";
                return View();
            }
            else
            {
                foreach (var validationItem in result.Errors)
                {
                    ModelState.AddModelError(validationItem.PropertyName, validationItem.ErrorMessage);
                }
                return View();
            }
        }


        /*
            //Apiyi çağırıp tüm şehir plaklarını getir.
           public async Task<List<TurkeyCityList>> GetDataApi()
           {
               using (HttpClient httpClient = new HttpClient())
               {
                   var response = await httpClient.GetAsync("https://localhost:44320/api/city.json");
                   //response.EnsureSuccessStatusCode();
                   var json = await response.Content.ReadAsStringAsync();
                   var jsonList = JsonConvert.DeserializeObject<List<TurkeyCityList>>(json);
                   return jsonList;
               }
           }

           public string DataSerilazeToJson()
           {
               CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
               var jsonSerilaze = JsonConvert.SerializeObject(categoryManager.CategoryGetList());
               return jsonSerilaze;
           }
        
         */
    }
}
