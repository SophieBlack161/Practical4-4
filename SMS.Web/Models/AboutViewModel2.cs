using System;
namespace SMS.Web.Models
{
  public class AboutViewModel2
  {   
      public string Title { get; set; }
      public string Message { get; set; }
      public DateTime Formed { get; set; } = DateTime.Now;
      public string FormedString => Formed.ToLongDateString();
      public int Days => (DateTime.Now - Formed).Days;
     
  }
} 
