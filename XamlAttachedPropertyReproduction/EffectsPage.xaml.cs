﻿using Xamarin.Forms;

using EntryCustomReturn.Forms.Plugin.Abstractions;

namespace XamlAttachedPropertyReproduction
{
    public partial class EffectsPage : ContentPage
    {
        Command _returnCommand;

        public EffectsPage()
        {
            InitializeComponent();

            CustomReturnEntry.ReturnCommand = ReturnCommand;

            CustomReturnEffect.SetReturnCommand(EffectsEntry, ReturnCommand);
        }

        Command ReturnCommand => _returnCommand ?? (_returnCommand = new Command(async entry => await DisplayAlert("Return Tapped", "", "Ok")));
    }
}
