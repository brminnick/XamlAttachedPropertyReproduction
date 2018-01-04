using Xamarin.Forms;

using EntryCustomReturn.Forms.Plugin.Abstractions;

namespace XamlAttachedPropertyReproduction
{
    public partial class EffectsPage : ContentPage
    {
        public EffectsPage()
        {
            InitializeComponent();

            CustomReturnEffect.SetReturnCommand(EffectsEntry, new Command(async () => await DisplayAlert("Return Tapped", "", "Ok")));
        }
    }
}
