using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            StringModel gotLI = new StringModel()
            {
                Filler = "When you play the game of thrones, you win or you die. Words are like wind. Forgive my manners. I don't see many ladies these days. Lucky for the ladies. It is rare to meet a Lannister who shares my enthusiasm for dead Lannisters. The tourney of Ashford Meadows. A good act does not wash out the bad, nor a bad act the good. Each should have its own reward. As High as Honor. Unbowed, Unbent, Unbroken. It is rare to meet a Lannister who shares my enthusiasm for dead Lannisters. The tourney of Ashford Meadows. Pay the iron price. Fire and blood. Bastards are born of passion, aren't they? We don't despise them in Dorne. A good act does not wash out the bad, nor a bad act the good. Each should have its own reward. The night is dark and full of terrors."
            };
            
            return View(gotLI);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {

            List<User> userList = new List<User>()
            {
                new User ("Moose", "Phillips"),
                new User ("Sarah", ""),
                new User ("Jerry", ""),
                new User ("Rene", "Ricky"),
                new User ("Barbara", "")
            };

            return View(userList);
        }

        [HttpGet("user")]
        public IActionResult UserProfile()
        {
            User u1 = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };

            return View("User", u1);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] nums = new int[]
            {
                1,2,3,4,5,6,7,8,9,10
            };
            return View("Numbers", nums);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
