using ASP.NET_Core_Lesson_7_Homework.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.NET_Core_Lesson_7_Homework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(FormData formData)
        {
            Debug.WriteLine("Данные поля First: " + formData.First);
            Debug.WriteLine("Данные поля Second: " + formData.Second);
            Debug.WriteLine("Данные поля Count: " + formData.Count);
            return View();
        }
    }
}