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
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
        }

        public VenmoSession VenmoSession
        {
            get
            {
                return App.VenmoSession;
            }
        }

        public void LoadData()
        {
            // Sample data; replace with real data (TODO: Send requests to Venmo for data fields)
            this.VenmoSession.CurrentUserAccount = VenmoCommon.MeTestItem;
            this.VenmoSession.CurrentUserFriends.Add(VenmoCommon.FriendTestItem);
            this.VenmoSession.CurrentUserFriends.Add(VenmoCommon.FriendTestItem);
            this.VenmoSession.CurrentUserFriends.Add(VenmoCommon.FriendTestItem);
            this.VenmoSession.CurrentUserFriends.Add(VenmoCommon.FriendTestItem);
            this.VenmoSession.CurrentUserFeed.Add(VenmoCommon.TransactionSummaryTestItem);
            this.VenmoSession.CurrentUserFeed.Add(VenmoCommon.TransactionSummaryTestItem);
            this.VenmoSession.CurrentUserFeed.Add(VenmoCommon.TransactionSummaryTestItem);
            this.VenmoSession.CurrentUserFeed.Add(VenmoCommon.TransactionSummaryTestItem);
            this.VenmoSession.CurrentUserHistory.Add(VenmoCommon.TransactionSummaryTestItem);
            this.VenmoSession.CurrentUserHistory.Add(VenmoCommon.TransactionSummaryTestItem);
            this.VenmoSession.CurrentUserHistory.Add(VenmoCommon.TransactionSummaryTestItem);
            this.VenmoSession.CurrentUserHistory.Add(VenmoCommon.TransactionSummaryTestItem);
            this.VenmoSession.CurrentUserHistory.Add(VenmoCommon.TransactionSummaryTestItem);
            this.VenmoSession.TimeOfLastDataLoad = DateTime.Now;
            this.VenmoSession.IsDataLoaded = true;
        }

        private void PayTransaction_Tap(object sender, GestureEventArgs e)
        {
            // TODO: Navigate to TransactionView with Pay action selected (with user field filled in if specified)
            //NavigationService.Navigate(new Uri("/ContactDetails.xaml", UriKind.Relative));
        }

        private void ChargeTransaction_Tap(object sender, GestureEventArgs e)
        {
            // TODO: Navigate to TransactionView with Charge action selected (with user field filled in if specified)
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