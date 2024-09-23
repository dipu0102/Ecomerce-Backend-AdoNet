using Microsoft.AspNetCore.Mvc;

namespace Ecomerce_Backend_AdoNet.Controllers
{
	public class AuthController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
