using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Venmo
{
    public sealed partial class MainPage : PhoneApplicationPage
    {
        private HttpClient httpClient;
        private AuthenticatedSession userSession;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.httpClient = new HttpClient();
            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }
    }
}