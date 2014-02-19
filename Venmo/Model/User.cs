using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Venmo
{
    #region User Request Responses
    /// <summary>
    /// Me (Current user) resource
    /// </summary>
    [DataContract]
    public class Me : VenmoResponse
    {
        [DataMember]
        public User UserAccount { get; set; }

        [DataMember]
        public double Balance { get; set; }
    }

    /// <summary>
    /// User account resource
    /// </summary>
    [DataContract]
    public class User : VenmoResponse
    {
        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string DateJoined { get; set; }

        [DataMember]
        public string About { get; set; }

        [DataMember]
        public string ProfilePictureURL { get; set; }

        [DataMember]
        public int FriendsCount { get; set; }

        [DataMember]
        public bool IsFriend { get; set; }
    }

    /// <summary>
    /// User's friend resource
    /// </summary>
    [DataContract]
    public class Friend : VenmoResponse
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public string About { get; set; }

        [DataMember]
        public string ProfilePictureURL { get; set; }
    }
    #endregion // User Request Responses
}
