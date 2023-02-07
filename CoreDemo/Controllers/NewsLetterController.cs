using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFreamwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        NewLetterManager _newLetterManager = new NewLetterManager(new EfNewsLetterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(NewLetter newLetter)
        {
            newLetter.MailStatus = true;
            _newLetterManager.NewLetterAdd(newLetter);
            return PartialView();
        }
    }
}
