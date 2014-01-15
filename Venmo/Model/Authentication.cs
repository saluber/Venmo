using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venmo
{
    public class AuthorizeData
    {
        public string ClientId { get; set; }

        public string Scope { get; set; }

        public string ReasonType { get; set; }

        public Uri RedirectUri { get; set; }

        public string State { get; set; }
    }

    public class AuthenticatedSession
    {
        public string AccessToken { get; set; }

        public double Balance { get; set; }

        public long ExpiresIn { get; set; }

        public User AuthenticatedUser { get; set; }

        public string RefreshToken { get; set; }
    }

    public class Tokens
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public long ExpiresIn { get; set; }
    }
}
