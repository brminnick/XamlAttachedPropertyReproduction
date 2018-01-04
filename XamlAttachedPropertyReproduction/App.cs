using Xamarin.Forms;

[assembly: Xamarin.Forms.Xaml.XamlCompilation(Xamarin.Forms.Xaml.XamlCompilationOptions.Compile)]
namespace XamlAttachedPropertyReproduction
{
    public class App:Application
    {
        public App() => MainPage = new NavigationPage(new MainPage());
    }
}
