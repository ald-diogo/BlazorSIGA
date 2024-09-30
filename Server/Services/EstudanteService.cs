using BlazorSIGA.Server.Entidades;

namespace BlazorSIGA.Server.Services
{
	public class EstudanteService
	{
		private List<Estudante> estudantes = new List<Estudante>();

		public List<Estudante> GetEstudantes() => estudantes;

		public void AddEstudante(Estudante estudante) => estudantes.Add(estudante);

		public void UpdateEstudante(Estudante estudante)
		{
			var index = estudantes.FindIndex(e => e.Id == estudante.Id);
			if (index != -1)
			{
				estudantes[index] = estudante;
			}
		}

		public void DeleteEstudante(int id) => estudantes.RemoveAll(e => e.Id == id);
	}

}
