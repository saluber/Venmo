using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Venmo
{
    #region Enumerations
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
        User,
        Invalid
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
    #endregion // Enumerations

    #region Venmo Request\Response Base Data Contracts
    [DataContract]
    public class VenmoRequest
    {
        [DataMember]
        public string AccessToken { get; set; }
    }

    [DataContract]
    public class VenmoResponse
    {
        [DataMember]
        public string NextPage { get; set; }

        [DataMember]
        public Error Error { get; set; }
    }

    /// <summary>
    /// Resource for Venmo API error description and HttpStatusCode 
    /// </summary>
    [DataContract]
    public class Error
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Code { get; set; }
    }
    #endregion

    public static class VenmoCommon
    {
        #region Constants

        #region Application Secret Strings
        public const string ClientId = "1545";

        public const string ClientSecret = "hA37VJvZRnyp4ckEUt4XXuDw7RRbFuSm";
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
        #endregion
    }
}
