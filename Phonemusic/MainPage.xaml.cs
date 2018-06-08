using System;
using Xamarin.Forms;

namespace Phonemusic
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        void OnAdd(object sender, EventArgs e)
        {
            if (true)
            {
                songAdd.IsEnabled = true;
                songAdd.Text = "Added!";
            }
        }
    }
}