﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Venmo
{
    #region Authentication Requests
    /// <summary>
    /// Authorize mobile application for Venmo user request sent to Venmo service
    /// </summary>
    [DataContract]
    public class AuthorizeAppRequest
    {
        [DataMember]
        public string ClientId { get; set; }

        [DataMember]
        public string Scope { get; set; }

        [DataMember]
        public string ResponseType { get; set; }

        [DataMember]
        public Uri RedirectUri { get; set; }

        [DataMember]
        public string State { get; set; }
    }

    /// <summary>
    /// Get token for authenticated Venmo user request sent to Venmo service
    /// </summary>
    [DataContract]
    public class AccessTokenRequest
    {
        [DataMember]
        public string ClientId { get; set; }

        [DataMember]
        public string ClientSecret { get; set; }

        [DataMember]
        public string AuthorizationCode { get; set; }
    }

    /// <summary>
    /// Refresh token request for authenticated Venmo user
    /// </summary>
    [DataContract]
    public class RefreshTokenRequest
    {
        [DataMember]
        public string ClientId { get; set; }

        [DataMember]
        public string ClientSecret { get; set; }

        [DataMember]
        public string RefreshToken { get; set; }
    }
    #endregion

    #region Authentication Request Responses
    [DataContract]
    public class VenmoAuthUser
    {
        [DataMember]
        public string AccessToken { get; set; }

        [DataMember]
        public string RefreshToken { get; set; }

        [DataMember]
        public long ExpiresIn { get; set; }

        [DataMember]
        public Me VenmoAccount { get; set; }
    }

    /// <summary>
    /// Refreshed Token Resource
    /// </summary>
    [DataContract]
    public class VenmoToken
    {
        [DataMember]
        public string AccessToken { get; set; }

        [DataMember]
        public string RefreshToken { get; set; }

        [DataMember]
        public long ExpiresIn { get; set; }
    }
    #endregion // Authentication Request Responses
}
