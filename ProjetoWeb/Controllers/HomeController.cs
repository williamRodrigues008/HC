using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoWeb.Classes;
using ProjetoWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWeb.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ContextoBanco _contexto;

		public HomeController(ILogger<HomeController> logger, ContextoBanco contexto)
		{
			_logger = logger;
			_contexto = contexto;
		}

		public IActionResult Index()
		{
			var eventos = _contexto.Eventos;
			return View(eventos.ToList());
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
