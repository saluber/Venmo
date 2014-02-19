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
    public class LoginViewModel : INotifyPropertyChanged
    {
        public LoginViewModel()
        {
        }

        private void DoLogin_Tap(object sender, GestureEventArgs e)
        {
            // TODO: Validate login with oauth and get Venmo access token and navigate to MainView
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
