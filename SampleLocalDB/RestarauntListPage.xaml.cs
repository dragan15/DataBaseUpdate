//This page Represents the restaraunt list page for our restaraunt list in out app 
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SampleLocalDB
{
    public partial class RestarauntListPage : ContentPage
    {
        public RestarauntListPage()
        {       

            InitializeComponent();
            this.Title = "Restaraunt List";
            //button that takes me to next page. When clicked, navigate to new screen
            var toolbarItem = new ToolbarItem  {
                Text = "+"
            };
            //Toolbar item. Button needs to be bound with restaraunt model
            toolbarItem.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new RestarauntSecondListPage() { BindingContext = new Restaraunt_table()});
            };
 
            ToolbarItems.Add(toolbarItem);
        }
        //Try to get restaraunt and bind it to our list view
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            RestarauntListView.ItemsSource = await App.Database.GetRestarauntsAsync();
        }

        //Update Button
        async void Restaraunt_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new RestarauntSecondListPage() { BindingContext = e.SelectedItem as Restaraunt_table });
            }

        }

    }
}
