using Microsoft.JSInterop;
using System.Threading.Tasks;

public class ThemeService
{
    private readonly IJSRuntime _jsRuntime;

    public ThemeService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task ApplyTheme(string theme)
    {
        await _jsRuntime.InvokeVoidAsync("applyTheme", theme);
    }
}

