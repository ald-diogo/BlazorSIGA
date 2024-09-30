namespace BlazorSIGA.Server.Services
{
    public class AvaliacaoService
    {
        public string AvaliarAluno(double media)
        {
            if (media >= 9.5)
                return "Apto";

            else if (media <= 9)
                return "Recurso";

            else
                return "Reprovado";

        }
    }
}
