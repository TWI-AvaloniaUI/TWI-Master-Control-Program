namespace MCP.Desktop;

using Avalonia;

public abstract partial class App : MCP.App
{
    public static new App? Current => Application.Current as App;
}
