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

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO
        }
    }
}