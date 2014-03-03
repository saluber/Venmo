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
    public class VenmoTransactionRequest : VenmoRequest
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
    public class VenmoTransactionResponse : VenmoResponse
    {
        [DataMember]
        public string Balance { get; set; }

        [DataMember]
        public VenmoTransaction Transaction { get; set; }
    }

    [DataContract]
    public class VenmoTransactionHistory : VenmoResponse
    {
        [DataMember]
        public VenmoTransactionSummary[] Transactions { get; set; }
    }

    [DataContract]
    public class VenmoTransactionSummary : VenmoResponse
    {
        private string m_status;
        [DataMember]
        public string Status 
        {
            get
            {
                return this.m_status;
            }
            set
            {
                this.m_status = value;
                // Try to parse TransactionStatus value from status field
                TransactionStatus ts;
                if (Enum.TryParse<TransactionStatus>(this.m_status, true, out ts))
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
        public VenmoTransactionTarget Target { get; set; }

        private string m_audience;
        [DataMember]
        public string Audience 
        {
            get
            {
                return this.m_audience;
            }
            set
            {
                this.m_audience = value;
                // Try to parse TransactionAudience value from audience field
                TransactionAudience ta;
                if (Enum.TryParse<TransactionAudience>(this.m_audience, true, out ta))
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
        public VenmoTransactionActor Actor { get; set; }

        [DataMember]
        public string Note { get; set; }

        [DataMember]
        public double Amount { get; set; }

        private string m_action;
        [DataMember]
        public string Action 
        {
            get
            {
                return this.m_action;
            }
            set
            {
                this.m_action = value;
                // Try to parse TransactionAction value from action field
                TransactionAction t;
                if (Enum.TryParse<TransactionAction>(this.m_action, true, out t))
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
    public class VenmoTransaction
    {
        private string m_status;

        [DataMember]
        public string Status
        {
            get
            {
                return this.m_status;
            }
            set
            {
                this.Status = value;
                // Try to parse TransactionStatus value from status field
                TransactionStatus ts;
                if (Enum.TryParse<TransactionStatus>(this.m_status, true, out ts))
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
        public VenmoTransaction Refund { get; set; }

        private string m_medium;
        [DataMember]
        public string Medium 
        {
            get
            {
                return this.m_medium;
            }
            set
            {
                this.m_medium = value;
                // Try to parse TransactionTransactionMedium value from medium field
                TransactionMedium t;
                if (Enum.TryParse<TransactionMedium>(this.m_medium, true, out t))
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
        public VenmoTransactionTarget Target { get; set; }

        private string m_audience;
        [DataMember]
        public string Audience
        {
            get
            {
                return this.m_audience;
            }
            set
            {
                this.m_audience = value;
                // Try to parse TransactionAudience value from audience field
                TransactionAudience ta;
                if (Enum.TryParse<TransactionAudience>(this.m_audience, true, out ta))
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
        public VenmoTransactionActor Actor { get; set; }

        [DataMember]
        public string Note { get; set; }

        [DataMember]
        public double Amount { get; set; }

        [DataMember]
        public double Fee { get; set; }

        private string m_action;
        [DataMember]
        public string Action
        {
            get
            {
                return this.m_action;
            }
            set
            {
                this.m_action = value;
                // Try to parse TransactionAction value from action field
                TransactionAction t;
                if (Enum.TryParse<TransactionAction>(this.m_action, true, out t))
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
    /// Target user in a VenmoTransaction resource
    /// </summary>
    [DataContract]
    public class VenmoTransactionTarget
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
    /// Acting user in a VenmoTransaction resource
    /// </summary>
    [DataContract]
    public class VenmoTransactionActor
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
