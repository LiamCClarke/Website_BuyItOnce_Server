using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BuyItOnce.Server.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Welcome
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
