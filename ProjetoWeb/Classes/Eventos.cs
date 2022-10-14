using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ProjetoWeb.Classes
{
	[Table("Eventos")]
	public class Eventos
	{
		public Eventos()
		{

		}

		[Column("IdEventos")]
		public int Id { get; set; }
		public string NomeEvento { get; set; }
		public DateTime DataEvento{ get; set; }

		[ForeignKey("Cursos")]
		public int IdCurso { get; set; }
		public virtual Cursos Cursos { get; set; }
		public int CargaHoraria { get; set; }
		public string Palestrante { get; set; }
		public string CargoPalestrante { get; set; }
		public string Organizador { get; set; }
		public string SobreEvento { get; set; }
	}
}
