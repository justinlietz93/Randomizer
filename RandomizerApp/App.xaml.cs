using RandomizerApp.Models;

namespace RandomizerApp;

public partial class App : Application
{
    public static Repository EntityList;
    
    public App()
    {
        InitializeComponent();
        EntityList = new Repository();

        MainPage = new AppShell();
    }
}