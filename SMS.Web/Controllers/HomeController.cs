using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;
using System;//I had to add this in to get DateTime to show no error(don't really know why)

namespace SMS.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {   
        var LongTime = DateTime.Now.ToLongTimeString();
        var Message = "Time Now";

        //construct the view model
        var task = new AboutViewModel
        {   
            longtime = LongTime,
            message = Message

        };

        return View(task);
    }

    public IActionResult About()
    {   
        //var formed = new DateTime(2020,01,01); 
        //var days = DateTime.Now.Subtract(formed).Days;
   
        // add strongly typed values to ViewBag
        //ViewBag.Formed = formed;
        //ViewBag.Days = days;    (N.B. there was an error coming up underneath DateTime but I am unsure why)
        
        //var formed = new DateTime(2020, 01, 01);
        
        // construct the view model
        //var about = new AboutViewModel
        //{
            //Formed = formed,
            //Days = (DateTime.Now - formed).Days         
        //};  

        //Practical work

        var formed = new DateTime(2022, 1, 1);
        var title = "Welcome";
        var message = "This is practical week 4";

        //construct the view model

        var about = new AboutViewModel2
        {
            Formed = formed,
            Title = title,
            Message = message
        };  


        return View(about);
    }

    
}
