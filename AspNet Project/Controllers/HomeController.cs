using Microsoft.AspNetCore.Mvc;
using System;
using AspNet_Project.Models;
using System.Linq;

namespace AspNet_Project
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;

            if (hour < 5)
            {
                ViewBag.Greeting = "Good Night!";
                return View("Myview");
            }
            else if(hour >=5 & hour <=10)
            {
                ViewBag.Greeting = "Good Morning!";
                return View("Myview");
            }
            else if (hour >= 11 & hour <= 17)
            {
                ViewBag.Greeting = "Good Day!";
                return View("Myview");
            }
            else
            {
                ViewBag.Greeting = "Good Evening!";
                return View("Myview");
            }
        } 

        [HttpGet] // Атрибут, указывающий, что данный метод должен применяться только для запросов GET
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost] // Атрибут, указывающий что данный метод будет применяться только для запросов POST
        public ViewResult RsvpForm(GuestResponse questResponse)
        {
            // Что сделать: сохранить ответ от гостя
            if (ModelState.IsValid)
            {
                Repository.AddResponce(questResponse);
                return View("Thanks", questResponse);
            }
            else
            {
                //Обнаружена ошибка проверки достоверности
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(x => x.WillAttend == true)); //Возвращает ответы, которые true
        }
    }
}