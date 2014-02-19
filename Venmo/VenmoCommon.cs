using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Venmo
{
    public static class VenmoCommon
    {
        #region Constants

        #region Application Secret Strings
        internal const string ClientId = "1545";

        internal const string ClientSecret = "hA37VJvZRnyp4ckEUt4XXuDw7RRbFuSm";
        #endregion // Application Secret Strings

        public static string OAuthVersion = "1.0a";

        public const string ResponseType = "code";

        public const string DateFormatter = "YYYY-MM-DDTHH:MM:SSZ";

        #region Venmo API Uris
        /// <summary>
        /// Callback URL passed to Venmo
        /// </summary>
        public const string CallbackUri = @"http://www.microsoft.com";

        public const string VenmoBaseUri = @"https://api.venmo.com/v1";

        public const string AuthorizeUri = @"https://api.venmo.com/v1/oauth/authorize";

        public const string AccessTokenUri = @"https://api.venmo.com/v1/oauth/access_token";

        public const string PaymentsUri = @"https://api.venmo.com/v1/payments";

        public const string MeUri = @"https://api.venmo.com/v1/me";

        public const string UserUri = @"https://api.venmo.com/v1/users";

        public const string FriendsUri = @"https://api.venmo.com/v1/friends";
        #endregion // Venmo API Uris

        #endregion // Constants

        #region Helper Methods
        public static DateTime GetFormattedDate(long utcDate)
        {
            return DateTime.FromFileTimeUtc(utcDate).ToLocalTime();
        }

        public static async Task AuthorizeApp()
        {
            throw new NotImplementedException();
        }

        public static async Task<VenmoAuthUser> LogIn(string venomAuthCode)
        {
            throw new NotImplementedException();
        }

        public static async Task<VenmoResponse> PostTransaction()
        {
            throw new NotImplementedException();
        }

        public static async Task<VenmoAuthUser> GetMe()
        {
            throw new NotImplementedException();
        }

        public static async Task<User> GetUser(string userId)
        {
            throw new NotImplementedException();
        }

        public static async Task<List<Friend>> GetFriendList(string userId)
        {
            throw new NotImplementedException();
        }

        public static async Task<VenmoAuthUser> RefreshLogin(VenmoToken token)
        {
            throw new NotImplementedException();
        }

        public static void LogOut(VenmoAuthUser user)
        {
            throw new NotImplementedException();
        }

        #endregion // Helper Methods

        #region Test Data
        public static TransactionSummary[] TransactionSummaryTestArray
        {
            get
            {
                TransactionSummary[] transactions = new TransactionSummary[3];
                for (int i = 0; i < transactions.Length; i++)
                {
                    transactions[i] = VenmoCommon.TransactionSummaryTestItem;
                }

                return transactions;
            }
        }

        public static TransactionSummary TransactionSummaryTestItem
        {
            get
            {
                return new TransactionSummary()
                {
                    Status = "Settled",
                    Target = VenmoCommon.TargetTestItem,
                    Audience = "Friends",
                    Actor = VenmoCommon.ActorTestItem,
                    Note = "Note",
                    Amount = 10.00,
                    Action = "pay",
                    DateCreated = DateTime.Now.ToShortDateString(),
                    DateCompleted = DateTime.Now.ToShortDateString(),
                    Id = "Id"
                };
            }
        }

        public static Target TargetTestItem
        {
            get
            {
                return new Target()
                {
                    Id = "Id",
                    Username = "Username",
                    FirstName = "FirstName",
                    LastName = "LastName",
                    DisplayName = "DisplayName",
                    Phone = "Phone",
                    Type = "User",
                    Email = "testemail@outlook.com",
                    DateJoined = DateTime.Now.ToShortDateString(),
                    About = "About",
                    ProfilePictureURL = "PictureURL"
                };
            }
        }

        public static Actor ActorTestItem
        {
            get
            {
                return new Actor()
                {
                    Id = "Id",
                    Username = "Username",
                    FirstName = "FirstName",
                    LastName = "LastName",
                    DisplayName = "DisplayName",
                    DateJoined = DateTime.Now.ToShortDateString(),
                    About = "About",
                    ProfilePictureURL = "PictureURL"
                };
            }
        }

        public static Transaction TransactionTestItem
        {
            get
            {
                return new Transaction()
                {
                    Status = "Settled",
                    Refund = null,
                    Medium = "Web",
                    Target = VenmoCommon.TargetTestItem,
                    Audience = "Friends",
                    Actor = VenmoCommon.ActorTestItem,
                    Note = "Note",
                    Amount = 10.00,
                    Fee = 0.00,
                    Action = "pay",
                    DateCreated = DateTime.Now.ToShortDateString(),
                    DateCompleted = DateTime.Now.ToShortDateString(),
                    Id = "Id"
                };
            }
        }

        public static Me MeTestItem
        {
            get
            {
                return new Me()
                {
                    UserAccount = VenmoCommon.UserTestItem,
                    Balance = 20.0
                };
            }
        }

        public static User UserTestItem
        {
            get
            {
                return new User()
                {
                    Id = "Id",
                    Username = "Username",
                    FirstName = "FirstName",
                    LastName = "LastName",
                    DisplayName = "DisplayName",
                    PhoneNumber = "Phone",
                    Email = "testemail@outlook.com",
                    DateJoined = DateTime.Now.ToShortDateString(),
                    About = "About",
                    ProfilePictureURL = "PictureURL",
                    IsFriend = true,
                    FriendsCount = 10
                };
            }
        }

        public static Friend FriendTestItem
        {
            get
            {
                return new Friend()
                {
                    Id = "Id",
                    Username = "Username",
                    FirstName = "FirstName",
                    LastName = "LastName",
                    DisplayName = "DisplayName",
                    About = "About",
                    ProfilePictureURL = "PictureURL"
                };
            }
        }
        #endregion // Test Data
    }
}
