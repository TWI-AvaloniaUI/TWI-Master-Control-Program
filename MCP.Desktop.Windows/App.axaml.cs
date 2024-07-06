namespace MCP.Desktop.Windows;

using Avalonia;

public sealed partial class App : Desktop.App
{
    public static new App? Current => Application.Current as App;
}
