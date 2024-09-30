using Microsoft.JSInterop;
using System.Threading.Tasks;

public class NotificationService
{
    private readonly IJSRuntime _jsRuntime;

    public NotificationService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task SolicitarPermissao()
    {
        var permission = await _jsRuntime.InvokeAsync<string>("Notification.requestPermission");
        if (permission == "granted")
        {
            Console.WriteLine("Permissão concedida para notificações.");
        }
        else
        {
            Console.WriteLine("Permissão negada para notificações.");
        }
    }

    public async Task EnviarNotificacao(string titulo, string corpo)
    {
        await _jsRuntime.InvokeVoidAsync("exibirNotificacao", titulo, corpo);
    }
}

