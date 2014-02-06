using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Venmo
{
    #region Transaction Request
    [DataContract]
    public class MakePaymentResource : VenmoRequest
    {
        [DataMember]
        public string TargetUser { get; set; }

        [DataMember]
        public string Note { get; set; }

        [DataMember]
        public double Amount { get; set; }

        [DataMember]
        public string Audience { get; set; }
    }
    #endregion

    #region Transaction Request Responses
    [DataContract]
    public class PaymentSubmission
    {
        [DataMember]
        public string Balance { get; set; }

        [DataMember]
        public Payment Payment { get; set; }
    }

    [DataContract]
    public class RecentPayments
    {
        [DataMember]
        public RecentPayment[] Payments { get; set; }
    }

    [DataContract]
    public class RecentPayment
    {
        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string DateCompleted { get; set; }

        [DataMember]
        public Target Target { get; set; }

        [DataMember]
        public string Audience { get; set; }

        [DataMember]
        public Actor Actor { get; set; }

        [DataMember]
        public string Note { get; set; }

        [DataMember]
        public double Amount { get; set; }

        [DataMember]
        public string Action { get; set; }

        [DataMember]
        public string DateCreated { get; set; }

        [DataMember]
        public string Id { get; set; }
    }

    [DataContract]
    public class Payment
    {
        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public Payment Refund { get; set; }

        [DataMember]
        public string Medium { get; set; }

        [DataMember]
        public Target Target { get; set; }

        [DataMember]
        public string Audience { get; set; }

        [DataMember]
        public Actor Actor { get; set; }

        [DataMember]
        public string Note { get; set; }

        [DataMember]
        public double Amount { get; set; }

        [DataMember]
        public double Fee { get; set; }

        [DataMember]
        public string Action { get; set; }

        [DataMember]
        public string DateCreated { get; set; }

        [DataMember]
        public string DateCompleted { get; set; }

        [DataMember]
        public string Id { get; set; }
    }

    /// <summary>
    /// Target user in a payment resource
    /// </summary>
    [DataContract]
    public class Target
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
        public string Phone { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string DateJoined { get; set; }

        [DataMember]
        public string About { get; set; }

        [DataMember]
        public string ProfilePictureURL { get; set; }
    }

    /// <summary>
    /// Acting user in a payment resource
    /// </summary>
    [DataContract]
    public class Actor
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
        public string DateJoined { get; set; }

        [DataMember]
        public string About { get; set; }

        [DataMember]
        public string ProfilePictureURL { get; set; }
    }
    #endregion // Transaction Request Responses
}
