﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using VirtoCommerce.Storefront.Model.Common;
using VirtoCommerce.Storefront.Model.Customer;

namespace VirtoCommerce.Storefront.Model.Security
{
    public partial class User : Entity
    {
        /// <summary>
        /// Store id
        /// </summary>
        public string StoreId { get; set; }
        /// <summary>
        /// Security account user name
        /// </summary>
        public string UserName { get; set; }
        public string UserNameNormalized => UserName?.ToUpper();
        public string Password { get; set; }

        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        /// <summary>
        /// Returns the email address of the customer.
        /// </summary>
        public string Email { get; set; }
        public string EmailNormalized => Email?.ToUpper();

        public string DefaultLanguage { get; set; }

        public bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// Returns true if user authenticated  returns false if it anonymous. 
        /// </summary>
        public bool IsRegisteredUser { get; set; }

        /// <summary>
        /// The user ID of an operator who has loggen in on behalf of a customer
        /// </summary>
        public string OperatorUserId { get; set; }
        /// <summary>
        /// The user name of an operator who has loggen in on behalf of a customer
        /// </summary>
        public string OperatorUserName { get; set; }

        /// <summary>
        /// List of stores which user can sign in
        /// </summary>
        public IList<string> AllowedStores { get; set; } = new List<string>();

        public IList<ExternalUserLoginInfo> ExternalLogins { get; set; } = new List<ExternalUserLoginInfo>();

        //Selected and persisted currency code
        public string SelectedCurrencyCode { get; set; }

        public string ContactId { get; set; }        
        /// <summary>
        /// Member associated with user 
        /// </summary>
        public Lazy<Contact> Contact { get; set; }
    }
}
