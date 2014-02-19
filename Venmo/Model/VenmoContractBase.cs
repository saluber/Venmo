using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Venmo
{
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
    #endregion // Venmo Request/Respone Base Data Contracts
}
