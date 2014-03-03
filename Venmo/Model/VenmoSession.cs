using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venmo
{
    public class VenmoSession
    {
        #region Fields

        private VenmoToken m_venmoToken;

        private bool m_isDataLoaded;

        private DateTime m_timeOfLastDataLoad;

        public VenmoUserMe CurrentUserAccount { get; set; }

        public ObservableCollection<VenmoUserSummary> CurrentUserFriends { get; set; }

        public ObservableCollection<VenmoTransactionSummary> CurrentUserHistory { get; set; }

        public ObservableCollection<VenmoTransactionSummary> CurrentUserFeed { get; set; }

        public bool IsTokenValid
        {
            get
            {
                if (this.m_venmoToken == null)
                {
                    return false;
                }
                else
                {
                    return (this.m_venmoToken.ExpiresIn > 0);
                }
            }
        }
        
        public bool IsDataLoaded
        {
            get { return this.m_isDataLoaded; }
            set { this.m_isDataLoaded = value; }
        }

        public DateTime TimeOfLastDataLoad
        {
            get { return this.m_timeOfLastDataLoad; }
            set { this.m_timeOfLastDataLoad = value; }
        }

        /// <summary>
        /// Gets time ticks since last data load
        /// </summary>
        public long TicksSinceLastRefresh
        {
            get
            {
                if (m_isDataLoaded)
                {
                    return (DateTime.Now.Ticks - this.m_timeOfLastDataLoad.Ticks);
                }
                else
                {
                    return long.MaxValue;
                }
            }
        }

        #endregion // Fields

        public VenmoSession()
        {
            this.m_venmoToken = new VenmoToken();
            this.m_isDataLoaded = false;
            this.CurrentUserAccount = new VenmoUserMe();
            this.CurrentUserFriends = new ObservableCollection<VenmoUserSummary>();
            this.CurrentUserHistory = new ObservableCollection<VenmoTransactionSummary>();
            this.CurrentUserFeed = new ObservableCollection<VenmoTransactionSummary>();
        }

        public static DateTime GetFormattedDate(long utcDate)
        {
            return DateTime.FromFileTimeUtc(utcDate).ToLocalTime();
        }

        public async Task DoAuthoizeVenmoApp()
        {
            throw new NotImplementedException();
        }

        public async Task<VenmoTokenResponse> DoVenmoUserLogin(string venomAuthCode)
        {
            throw new NotImplementedException();
        }

        public async Task<VenmoTokenResponse> DoVenmoTokenRefresh(VenmoToken token)
        {
            throw new NotImplementedException();
        }

        public void DoVenmoUserLogOut(VenmoTokenResponse user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Loads (or reloads) VenmoSession data asynchronously
        /// Updates isDataLoaded and lastRefreshTime
        /// </summary>
        /// <returns></returns>
        public async Task LoadVenmoData()
        {
            throw new NotImplementedException();
        }
    }
}
