using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venmo
{
    enum PaymentAudience
    {
        Public,
        Friends,
        Private
    }

    enum PaymentTargetType
    {
        Phone,
        Email,
        User
    }

    enum PaymentAction
    {
        Pay,
        Charge
    }

    enum PaymentStatus
    {
        Pending,
        Settled,
        Failed,
        Expired,
        Cancelled
    }

    enum PaymentMedium
    {
        IOS,
        Android,
        Web,
        API
    }

    public static class Constants
    {
        #region Secret Strings
        
        public const string ClientId = "1545";

        public const string ClientSecret = "hA37VJvZRnyp4ckEUt4XXuDw7RRbFuSm";
        
        public const string TestAccessToken = "ZPNsSrczCPF6mq6uFDQNpeEdr6VEfcXK";

        #endregion

        #region Const Request Parameters
        
        public const string ResponseType = "code";

        public const string DateFormat = "YYYY-MM-DDTHH:MM:SSZ";
        
        #endregion

        #region Venmo API URLs
        
        public const string VenmoBaseURL = @"https://api.venmo.com/v1";

        public const string AuthorizeAction = @"/oauth/authorize";

        public const string AccessTokenAction = @"/oauth/access_token";

        public const string PaymentsController = @"/payments";

        public const string CurrentUserController = @"/me";

        public const string UserController = @"/users";

        public const string UserFriendsAction = @"/friends";

        #endregion
    }
}
