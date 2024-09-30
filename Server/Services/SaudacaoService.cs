namespace BlazorSIGA.Server.Services
{
    public class SaudacaoService
    {
        public string ObterSaudacao()
        {
            var horaAtual = DateTime.Now.Hour;
            if (horaAtual < 12)
            {
                return "Bom dia";
            }

            else if (horaAtual < 18)
            {
                return "Boa tarde";
            }

            else
            {
                return "Boa noite";
            }
        }
    }
}
