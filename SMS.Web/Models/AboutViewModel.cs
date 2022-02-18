using System;//had to add this in here aswell to get DateTime to work(not sure why)
namespace SMS.Web.Models
{
  public class AboutViewModel
  {
      public DateTime Formed { get; set; }
      public int Days { get; set; }

      public string message{get;set;}

      public string longtime{get;set;}
  }
} 