namespace BlazorSIGA.Server.Entidades
{
	public class Professor
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Disciplina { get; set; }
		public DateTime DataContratacao { get; set; }
		public string Endereco { get; set; }
		public string Email { get; set; }
		public int Telefone { get; set; }
	}
}
