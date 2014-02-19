using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Venmo
{
    #region Transaction Type Enumerations
    public enum TransactionAudience
    {
        [EnumMember]
        Public,

        [EnumMember]
        Friends,
        
        [EnumMember]
        Private
    }

    public enum TransactionTargetType
    {
        [EnumMember]
        Phone,

        [EnumMember]
        Email,

        [EnumMember]
        User,

        [EnumMember]
        Invalid
    }

    public enum TransactionAction
    {
        [EnumMember]
        Pay,

        [EnumMember]
        Charge
    }

    public enum TransactionStatus
    {
        [EnumMember]
        Pending,

        [EnumMember]
        Settled,

        [EnumMember]
        Failed,

        [EnumMember]
        Expired,

        [EnumMember]
        Cancelled
    }

    public enum TransactionMedium
    {
        [EnumMember]
        IOS,

        [EnumMember]
        Android,

        [EnumMember]
        Web,

        [EnumMember]
        API
    }
    #endregion // Transaction Type Enumerations

    #region Transaction Requests
    [DataContract]
    public class TransactionRequest : VenmoRequest
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
    #endregion // Transaction Requests

    #region Transaction Request Responses
    [DataContract]
    public class TransactionSubmission : VenmoResponse
    {
        [DataMember]
        public string Balance { get; set; }

        [DataMember]
        public Transaction Transaction { get; set; }
    }

    [DataContract]
    public class RecentTransactions : VenmoResponse
    {
        [DataMember]
        public TransactionSummary[] Transactions { get; set; }
    }

    [DataContract]
    public class TransactionSummary : VenmoResponse
    {
        private string status;
        [DataMember]
        public string Status 
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
                // Try to parse TransactionStatus value from status field
                TransactionStatus ts;
                if (Enum.TryParse<TransactionStatus>(this.status, true, out ts))
                {
                    this.TransactionStatus = ts;
                }
                else
                {
                    // TODO: Mark unexpected value for status
                }
            }
        }

        [DataMember]
        public string DateCompleted { get; set; }

        [DataMember]
        public Target Target { get; set; }

        private string audience;
        [DataMember]
        public string Audience 
        {
            get
            {
                return this.audience;
            }
            set
            {
                this.audience = value;
                // Try to parse TransactionAudience value from audience field
                TransactionAudience ta;
                if (Enum.TryParse<TransactionAudience>(this.audience, true, out ta))
                {
                    this.TransactionAudience = ta;
                }
                else
                {
                    // TODO: Mark unexpected value for audience
                }
            }
        }

        [DataMember]
        public Actor Actor { get; set; }

        [DataMember]
        public string Note { get; set; }

        [DataMember]
        public double Amount { get; set; }

        private string action;
        [DataMember]
        public string Action 
        {
            get
            {
                return this.action;
            }
            set
            {
                this.action = value;
                // Try to parse TransactionAction value from action field
                TransactionAction t;
                if (Enum.TryParse<TransactionAction>(this.action, true, out t))
                {
                    this.TransactionAction = t;
                }
                else
                {
                    // TODO: Mark unexpected value for action
                }
            } 
        }

        [DataMember]
        public string DateCreated { get; set; }

        [DataMember]
        public string Id { get; set; }

        #region Helper Accessors
        public TransactionStatus TransactionStatus { get; private set; }

        public TransactionAudience TransactionAudience { get; private set; }

        public TransactionAction TransactionAction { get; private set; }

        public string Description
        {
            get
            {
                if (this.TransactionAction == Venmo.TransactionAction.Pay)
                {
                    return this.Actor.DisplayName + Resources.AppResources.PaidText + this.Target.DisplayName;
                }
                else
                {
                    return this.Target.DisplayName + Resources.AppResources.PaidText + this.Actor.DisplayName;
                }
            }
        }

        public string FormattedAmount
        {
            get
            {
                string amountPrefix = Resources.AppResources.CurrencySymbol;
                if (this.Amount < 0)
                {
                    amountPrefix = "-" + amountPrefix;
                }

                return amountPrefix + Math.Abs(this.Amount).ToString();
            }
        }
        #endregion // Helper Accessors
    }
    #endregion // Transaction Request Responses

    #region Transaction Base Data Contracts
    [DataContract]
    public class Transaction
    {
        private string status;
        [DataMember]
        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.Status = value;
                // Try to parse TransactionStatus value from status field
                TransactionStatus ts;
                if (Enum.TryParse<TransactionStatus>(this.status, true, out ts))
                {
                    this.TransactionStatus = ts;
                }
                else
                {
                    // TODO: Mark unexpected value for status
                }
            }
        }

        [DataMember]
        public Transaction Refund { get; set; }

        private string medium;
        [DataMember]
        public string Medium 
        {
            get
            {
                return this.medium;
            }
            set
            {
                this.medium = value;
                // Try to parse TransactionTransactionMedium value from medium field
                TransactionMedium t;
                if (Enum.TryParse<TransactionMedium>(this.medium, true, out t))
                {
                    this.TransactionMedium = t;
                }
                else
                {
                    // TODO: Mark unexpected value for medium
                }
            }
        }

        [DataMember]
        public Target Target { get; set; }

        private string audience;
        [DataMember]
        public string Audience
        {
            get
            {
                return this.audience;
            }
            set
            {
                this.audience = value;
                // Try to parse TransactionAudience value from audience field
                TransactionAudience ta;
                if (Enum.TryParse<TransactionAudience>(this.audience, true, out ta))
                {
                    this.TransactionAudience = ta;
                }
                else
                {
                    // TODO: Mark unexpected value for audience
                }
            }
        }

        [DataMember]
        public Actor Actor { get; set; }

        [DataMember]
        public string Note { get; set; }

        [DataMember]
        public double Amount { get; set; }

        [DataMember]
        public double Fee { get; set; }

        private string action;
        [DataMember]
        public string Action
        {
            get
            {
                return this.action;
            }
            set
            {
                this.action = value;
                // Try to parse TransactionAction value from action field
                TransactionAction t;
                if (Enum.TryParse<TransactionAction>(this.action, true, out t))
                {
                    this.TransactionAction = t;
                }
                else
                {
                    // TODO: Mark unexpected value for action
                }
            }
        }

        [DataMember]
        public string DateCreated { get; set; }

        [DataMember]
        public string DateCompleted { get; set; }

        [DataMember]
        public string Id { get; set; }

        #region Helper Accessors
        public TransactionStatus TransactionStatus { get; private set; }

        public TransactionMedium TransactionMedium { get; private set; }

        public TransactionAudience TransactionAudience { get; private set; }

        public TransactionAction TransactionAction { get; private set; }

        public string Description
        {
            get
            {
                if (this.TransactionAction == Venmo.TransactionAction.Pay)
                {
                    return this.Actor.DisplayName + Resources.AppResources.PaidText + this.Target.DisplayName;
                }
                else
                {
                    return this.Target.DisplayName + Resources.AppResources.PaidText + this.Actor.DisplayName;
                }
            }
        }

        public string FormattedAmount
        {
            get
            {
                string amountPrefix = Resources.AppResources.CurrencySymbol;
                if (this.Amount < 0)
                {
                    amountPrefix = "-" + amountPrefix;
                }

                return amountPrefix + Math.Abs(this.Amount).ToString();
            }
        }
        #endregion // Helper Accessors
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
    #endregion // Transaction Base Data Contracts
}
