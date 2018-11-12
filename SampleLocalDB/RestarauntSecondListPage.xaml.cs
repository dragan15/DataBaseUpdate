using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleLocalDB
{
    public partial class RestarauntSecondListPage : ContentPage
    {
        public RestarauntSecondListPage()
        {
            InitializeComponent();
        }

        //Save Button
        async void Save_Clicked(object sender, System.EventArgs e)
        {
            var RestarauntItem = (Restaraunt_table)BindingContext;
            await App.Database.SaveRestarauntAsync(RestarauntItem);
            await Navigation.PopAsync();

        }
        //Cancel Button
        async void Cancel_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();

        }

    }
}
   