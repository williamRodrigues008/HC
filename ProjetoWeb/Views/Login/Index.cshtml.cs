using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace ProjetoWeb.Views.Login
{
    public class IndexModel : PageModel
    {
        private readonly string _conexao = @"Data Source=WILLIAM\NASERVER;Initial Catalog=HorasComplementares;Integrated Security=True";
        public int Codigo { get; set; }

        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório")]
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public bool UsuarioPodeLogar()
        {
            var resultado = false;
            var sql = "select Id, Nome from Usuarios where Email = '" + this.Usuario + "' and senha = '" + this.Senha + "'";

            try
            {
                using (var conexao = new SqlConnection(_conexao))
                {
                    conexao.Open();
                    using (var comando = new SqlCommand(sql, conexao))
                    {
                        using (var executarLeitura = comando.ExecuteReader())
                        {
                            if (executarLeitura.HasRows)
                            {
                                if (executarLeitura.Read())
                                {
                                    if (this.Senha == executarLeitura["senha"].ToString())
                                    {
                                        this.Codigo = Convert.ToInt32(executarLeitura["Id"]);
                                        this.Usuario = executarLeitura["Email"].ToString();
                                        resultado = true;
                                    }
                                }
                            }
                            else
                            {
                                resultado = false;
                            }
                        }
                    }
                }
                return resultado;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Logar()
        {
            Usuario = Request.Form["Email"];
            Senha = Request.Form["Senha"];

            if (UsuarioPodeLogar())
            {
                Response.Redirect("/Home/Index");
            }
            else
            {
                Response.Redirect("/Home/Index");
            }
        }

        public void OnGet()
        {
        }
    }
}
