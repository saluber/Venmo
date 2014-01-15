using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venmo
{
    public class MakePaymentResource : VenmoRequest
    {
        public string TargetUser { get; set; }

        public string Note { get; set; }

        public double Amount { get; set; }

        public string Audience { get; set; }
    }

    public class SubmittedPayment : ResponseData
    {
        public string Balance { get; set; }
        public Payment Payment { get; set; }
    }

    public class UserRecentPayments : ResponseData
    {
        public RecentPayment[] Payments;
    }

    public class RecentPayment
    {
        public string Status { get; set; }

        public DateTime DateCompleted { get; set; }

        public Target Target { get; set; }

        public string Audience { get; set; }

        public Actor Actor { get; set; }

        public string Note { get; set; }

        public double Amount { get; set; }

        public string Action { get; set; }

        public DateTime DateCreated { get; set; }

        public string Id { get; set; }
    }

    public class Payment : ResponseData
    {
        public string Status { get; set; }

        public Payment Refund { get; set; }

        public string Medium { get; set; }

        public DateTime DateCompleted { get; set; }

        public Target Target { get; set; }

        public string Audience { get; set; }

        public Actor Actor { get; set; }

        public string Note { get; set; }

        public double Amount { get; set; }

        public double Fee { get; set; }

        public string Action { get; set; }

        public DateTime DateCreated { get; set; }

        public string Id { get; set; }
    }

    /// <summary>
    /// Target user in a payment resource
    /// </summary>
    public class Target
    {
        public string m_phone;

        public string m_type;

        public string Email { get; set; }

        public Actor User { get; set; }
    }

    /// <summary>
    /// Acting user in a payment resource
    /// </summary>
    public class Actor
    {
        public DateTime DateJoined { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DisplayName { get; set; }

        public string About { get; set; }

        public Uri ProfilePictureURL { get; set; }

        public string Id { get; set; }
    }
}
