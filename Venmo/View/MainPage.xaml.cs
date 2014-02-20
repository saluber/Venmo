using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace Venmo
{
    public sealed partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of MainPage view to MainViewModel
            DataContext = App.MainViewModel;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About!");
            // TODO: Do work for application here.
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout!");
            // TODO: Do work for application here.
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.MainViewModel.IsDataLoaded)
            {
                App.MainViewModel.LoadData();
            }
        }
    }
}