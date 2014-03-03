using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Phone.Controls;
using Venmo.Resources;

namespace Venmo
{
    public class TransactionViewModel
    {
        public TransactionViewModel()
        {
            this.UserTransaction = new VenmoTransactionResponse();
            this.UserTransactionAction = new TransactionAction();
        }

        public VenmoTransactionResponse UserTransaction { get; private set; }
        public TransactionAction UserTransactionAction { get; private set; }

        private void CancelTransaction_Tap(object sender, GestureEventArgs e)
        {
            // TODO: Navigate back to previous view on MainView
            //NavigationService.Navigate(new Uri("/ContactDetails.xaml", UriKind.Relative));
        }

        private void SubmitTransaction_Tap(object sender, GestureEventArgs e)
        {
            // TODO: Validate data and post TransactionRequest and show errors/return to MainView
            //NavigationService.Navigate(new Uri("/ContactDetails.xaml", UriKind.Relative));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
