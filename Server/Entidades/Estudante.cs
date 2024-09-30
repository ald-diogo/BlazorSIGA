namespace BlazorSIGA.Server.Entidades
{
	public class Estudante
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Curso { get; set; }
		public DateTime DataNascimento { get; set; }
		public string Endereco { get; set; }
		public string Email { get; set; }
		public int Telefone { get; set; }
		public List<Nota> Notas { get; set; }
	}
}
