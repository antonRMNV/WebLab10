using Microsoft.AspNetCore.Mvc;

namespace WebApplication15.Models
{
    public class MarkErrors : ViewComponent
    {
        public IViewComponentResult? Invoke(Consultation consultation)
        {
            if (consultation == null)
                return View("Valid");
            if (consultation.Errors.Count == 0)
                return View("Valid");
            return View(consultation.Errors);
        }
    }
}

