using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venmo
{
    /// <summary>
    /// Current user resource
    /// </summary>
    public class CurrentUser : ResponseData
    {
        public string Balance { get; set; }
        public User User { get; set; }
    }

    /// <summary>
    /// User resource
    /// </summary>
    public class User : ResponseData
    {
        public DateTime DateJoined { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DisplayName { get; set; }

        public string About { get; set; }

        public Uri ProfilePictureURL { get; set; }

        public string Id { get; set; }

        public int FriendsCount { get; set; }

        public bool IsFriend { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }

    /// <summary>
    /// User's friends resources
    /// </summary>
    public class UserFriends : ResponseData
    {
        public Friend[] Friends { get; set; }
    }

    /// <summary>
    /// User's friend resource
    /// </summary>
    public class Friend
    {
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DisplayName { get; set; }

        public string About { get; set; }

        public Uri ProfilePictureURL { get; set; }

        public string Id { get; set; }
    }
}
