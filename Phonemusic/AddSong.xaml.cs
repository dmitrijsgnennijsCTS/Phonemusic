using System;
using Xamarin.Forms;
using System.Threading;

namespace Phonemusic
{
    public partial class AddSong : ContentPage
    {

        public AddSong()
        {
            InitializeComponent();
        }

        void OnAdd(object sender, EventArgs e)
        {
            if (true)
            {
                songAdd.IsEnabled = true;
                songAdd.Text = "Added!";

                /*System.Threading.Thread.Sleep(5000);
                songAdd.Text = "Add";*/
            }
        }
    }
}