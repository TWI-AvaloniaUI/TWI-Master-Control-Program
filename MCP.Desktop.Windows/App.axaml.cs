namespace MCP.Desktop.Windows;

using Avalonia;

public abstract partial class App : Desktop.App
{
    public static new App? Current => Application.Current as App;
}
