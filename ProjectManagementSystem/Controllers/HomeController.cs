using Microsoft.AspNetCore.Mvc;

namespace ProjectManagementSystem.Controllers
{
    /// <summary>
    /// Home controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Index this instance.
        /// </summary>
        /// <returns>The index.</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Error this instance.
        /// </summary>
        /// <returns>The error.</returns>
        public IActionResult Error()
        {
            return View();
        }
    }
}
