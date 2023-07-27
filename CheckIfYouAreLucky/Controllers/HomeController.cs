using CheckIfYouAreLucky.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CheckIfYouAreLucky.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GenerateMessage()
        {
            string displayMessage = GenerateRandomMessage();
            ViewBag.Message = displayMessage;
            return View("Index");
        }

        private string GenerateRandomMessage()
        {
            // Generate a random number between 1 and 5
            Random random = new Random();
            int randomNumber = random.Next(1, 6);

            // Define the cute messages
            string message;
            switch (randomNumber)
            {
                case 1:
                    message = "Today is your lucky day! Enjoy every moment!";
                    break;
                case 2:
                    message = "Today may not be your lucky day, but don't worry, there are still plenty of opportunities waiting for you!";
                    break;
                case 3:
                    message = "Embrace today with a positive attitude and make it your lucky day!";
                    break;
                case 4:
                    message = "Luck comes to those who believe in themselves. Today, it's your turn!";
                    break;
                case 5:
                    message = "Sometimes luck is disguised as hard work. Keep pushing forward and success will come your way!";
                    break;
                default:
                    message = "Invalid message";
                    break;
            }

            return message;
        }
    }
}
