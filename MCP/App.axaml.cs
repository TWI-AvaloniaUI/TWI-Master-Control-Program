namespace MCP;

using Avalonia;

public abstract partial class App : Application
{
    public static new App? Current => Application.Current as App;
}
