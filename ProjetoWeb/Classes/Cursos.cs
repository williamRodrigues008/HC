using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoWeb.Classes
{
	[Table("Cursos")]
	public class Cursos
	{
		public Cursos()
		{

		}

		[Column("IdCurso")]
		public int Id { get; set; }
		public string NomeCurso { get; set; }
	}
}
