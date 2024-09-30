using BlazorSIGA.Server.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorSIGA.Server.Services
{
	public class AcademicReportService
	{
		public Task<List<Relatorio>> GetReportsAsync()
		{
			// Simulação de dados de relatório acadêmico
			var reports = new List<Relatorio>
			{
				new Relatorio { NomeEstudante = "", Classe = "", Discplina = "" },
				new Relatorio { NomeEstudante = "", Classe = "", Discplina = "" },
				new Relatorio { NomeEstudante= "", Classe = "", Discplina = "" }
			};

			return Task.FromResult(reports);
		}
	}

	public class Relatorio
	{
		public string NomeEstudante { get; set; }
		public string Classe { get; set; }
		public string Discplina { get; set; }
	}
}


