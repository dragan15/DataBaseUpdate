using System;

using Xamarin.Forms;

namespace SampleLocalDB
{
    public class RestarauntListPage : ContentPage
    {
        public RestarauntListPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

