using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjetoWeb.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> Login(string usuario, string senha)
		{
			SqlConnection conexao = new SqlConnection(@"Data Source=WILLIAM\NASERVER;Initial Catalog=HorasComplementares;Integrated Security=True");

			await conexao.OpenAsync();
			string retornoDados = $"select * from Usuarios where email = '{usuario}' and senha = '{senha}'";
			SqlCommand comandoSql = new(retornoDados, conexao);

			SqlDataReader leitor = comandoSql.ExecuteReader();

			if(await leitor.ReadAsync())
			{
				int idUsuario = leitor.GetInt32(0);
				string nomeUsuario = leitor.GetString(1);

				List<Claim> acessos = new List<Claim>
				{
					new Claim(ClaimTypes.NameIdentifier, idUsuario.ToString()),
					new Claim(ClaimTypes.Name, nomeUsuario)

				};

				var identidade = new ClaimsIdentity(acessos, "Identity.Login");
				var usuarioPrincipal = new ClaimsPrincipal(new[] { identidade });

				await HttpContext.SignInAsync(usuarioPrincipal, new AuthenticationProperties
				{
					IsPersistent = true,
					ExpiresUtc = DateTime.Now.AddHours(1),
				});

				return RedirectToAction("Index", "Home");
			}
			else
			{
				return Json(new { Msg = "Credenciais incorretas" });
			}
		}

		public async Task<IActionResult> Sair()
		{
			if (User.Identity.IsAuthenticated)
			{
				await HttpContext.SignOutAsync();
			}
			return RedirectToAction("Index");
		}
	}
}
