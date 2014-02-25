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
            this.UserMe = new Me();
            this.UserFriends = new ObservableCollection<Friend>();
            this.UserFeed = new ObservableCollection<TransactionSummary>();
            this.UserFriendsFeed = new ObservableCollection<TransactionSummary>();
        }

        public Me UserMe { get; private set; }
        public ObservableCollection<Friend> UserFriends { get; private set; }
        public ObservableCollection<TransactionSummary> UserFeed { get; private set; }
        public ObservableCollection<TransactionSummary> UserFriendsFeed { get; private set; }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        public DateTime LastDataLoad
        {
            get;
            private set;
        }

        public void LoadData()
        {
            // Sample data; replace with real data (TODO: Send requests to Venmo for data fields)
            this.UserMe = VenmoCommon.MeTestItem;
            this.UserFriends.Add(VenmoCommon.FriendTestItem);
            this.UserFriends.Add(VenmoCommon.FriendTestItem);
            this.UserFriends.Add(VenmoCommon.FriendTestItem);
            this.UserFriends.Add(VenmoCommon.FriendTestItem);
            this.UserFeed.Add(VenmoCommon.TransactionSummaryTestItem);
            this.UserFeed.Add(VenmoCommon.TransactionSummaryTestItem);
            this.UserFeed.Add(VenmoCommon.TransactionSummaryTestItem);
            this.UserFeed.Add(VenmoCommon.TransactionSummaryTestItem);
            this.UserFriendsFeed.Add(VenmoCommon.TransactionSummaryTestItem);
            this.UserFriendsFeed.Add(VenmoCommon.TransactionSummaryTestItem);
            this.UserFriendsFeed.Add(VenmoCommon.TransactionSummaryTestItem);
            this.UserFriendsFeed.Add(VenmoCommon.TransactionSummaryTestItem);
            this.LastDataLoad = DateTime.Now;
            this.IsDataLoaded = true;
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