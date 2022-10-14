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
            eventos.Add(new Eventos { Id = 1, Organizador = "Fadesa", NomeEvento = "Semana Academica de Pedagogia", Palestrante = "Kennedy Miné" });
            eventos.Add(new Eventos { Id = 2, Organizador = "Fadesa", NomeEvento = "Semana Academica de Pedagogia", Palestrante = "Kennedy Miné" });
            eventos.Add(new Eventos { Id = 3, Organizador = "Fadesa", NomeEvento = "Semana Academica de Pedagogia", Palestrante = "Kennedy Miné" });
            eventos.Add(new Eventos { Id = 4, Organizador = "Fadesa", NomeEvento = "Semana Academica de Pedagogia", Palestrante = "Kennedy Miné" });
            eventos.Add(new Eventos { Id = 5, Organizador = "Fadesa", NomeEvento = "Semana Academica de Pedagogia", Palestrante = "Kennedy Miné" });
            eventos.Add(new Eventos { Id = 6, Organizador = "Fadesa", NomeEvento = "Semana Academica de Pedagogia", Palestrante = "Kennedy Miné" });

            return eventos;
        }
    }
}

