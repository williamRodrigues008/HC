using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjetoWeb.Classes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoWeb.Views
{
    public class IndexModel : PageModel
    {
        public void OnGet() 
        {

        }

        public List<Cursos> EventosPorCurso()
        {
            var curso = new List<Cursos>();

            curso.Add(new Cursos { NomeCurso = "Nutricão" });
            curso.Add(new Cursos { NomeCurso = "Medicina" });
            curso.Add(new Cursos { NomeCurso = "Psicologia" });
            curso.Add(new Cursos { NomeCurso = "ADS" });
            curso.Add(new Cursos { NomeCurso = "Pedagogia" });
            curso.Add(new Cursos { NomeCurso = "Pedagogia" });
            curso.Add(new Cursos { NomeCurso = "Pedagogia" });
            curso.Add(new Cursos { NomeCurso = "Pedagogia" });
            curso.Add(new Cursos { NomeCurso = "Pedagogia" });
            curso.Add(new Cursos { NomeCurso = "Pedagogia" });

            return curso;
        }

        public List<Eventos> EventosFuturos()
        {
            var eventos = new List<Eventos>();
            eventos.Add(new Eventos { Codigo = 1, Faculdade = "Fadesa", NomeEvento = "Semana Academica de Pedagogia", Palestrante = "Kennedy Miné" });
            eventos.Add(new Eventos { Codigo = 2, Faculdade = "Fadesa", NomeEvento = "Semana Academica de Pedagogia", Palestrante = "Kennedy Miné" });
            eventos.Add(new Eventos { Codigo = 3, Faculdade = "Fadesa", NomeEvento = "Semana Academica de Pedagogia", Palestrante = "Kennedy Miné" });
            eventos.Add(new Eventos { Codigo = 4, Faculdade = "Fadesa", NomeEvento = "Semana Academica de Pedagogia", Palestrante = "Kennedy Miné" });
            eventos.Add(new Eventos { Codigo = 5, Faculdade = "Fadesa", NomeEvento = "Semana Academica de Pedagogia", Palestrante = "Kennedy Miné" });
            eventos.Add(new Eventos { Codigo = 6, Faculdade = "Fadesa", NomeEvento = "Semana Academica de Pedagogia", Palestrante = "Kennedy Miné" });

            return eventos;
        }
    }
}

