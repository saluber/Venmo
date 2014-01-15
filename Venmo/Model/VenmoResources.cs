using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venmo
{
    public class VenmoRequest
    {
        public string AccessToken { get; set; }
    }

    public class VenmoResponse
    {
        public ResponseData Data { get; set; }
        public Pagination Pagination { get; set; }
        public Error Error { get; set; }
    }

    public class ResponseData
    {
    }

    public class Pagination
    {
        public Uri Next { get; set; }
    }

    /// <summary>
    /// Resource for Venmo API error description and HttpStatusCode 
    /// </summary>
    public class Error
    {
        public string Message { get; set; }

        public string Code { get; set; }
    }
}
