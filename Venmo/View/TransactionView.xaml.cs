using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Venmo
{
    public partial class TransactionView : PhoneApplicationPage
    {
        public TransactionView()
        {
            InitializeComponent();

            // Set the data context of TransactionView to TransactionViewModel
            DataContext = App.TransactionViewModel;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send!");
            // TODO: Do work for application here.
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel!");
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
            // TODO
        }
    }
}