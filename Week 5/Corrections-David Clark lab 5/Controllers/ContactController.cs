using Microsoft.AspNetCore.Mvc;

//namespace David_s_Extreme_Gear.Views.Contact
namespace David_s_Extreme_Gear.Models
{
    public class ContactController : Controller
    {


        [HttpGet]
        public IActionResult Index()
        {
           // ViewBag.FV = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
           // ViewBag.FV = model.ContactModel();
            return View(model);
        }


    }
}