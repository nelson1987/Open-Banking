using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BGB.OpenBanking.Api.Areas.Common.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class BusinessAccounts : IEquatable<BusinessAccounts>
    { 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Required]
        [DataMember(Name="type")]
        public AccountType Type { get; set; }

        /// <summary>
        /// Gets or Sets Fees
        /// </summary>
        [Required]
        [DataMember(Name="fees")]
        public BusinessAccountsFees Fees { get; set; }

        /// <summary>
        /// Lista dos serviços que compõe o pacote de serviços
        /// </summary>
        /// <value>Lista dos serviços que compõe o pacote de serviços</value>
        [Required]
        [DataMember(Name="serviceBundles")]
        public List<ServiceBundle> ServiceBundles { get; set; }

        /// <summary>
        /// Lista dos canais para aberturas e encerramento
        /// </summary>
        /// <value>Lista dos canais para aberturas e encerramento</value>
        [Required]
        [DataMember(Name="openingClosingChannels")]
        public List<OpeningClosingChannels> OpeningClosingChannels { get; set; }

        /// <summary>
        /// Texto livre para complementar informação relativa ao Canal disponível, quando no campo &#x27;&#x27;openingClosingChannels&#x27;&#x27; estiver preenchida a opção &#x27;&#x27;Outros&#x27;&#x27; Restrição: Campo de preenchimento obrigatório se &#x27;&#x27;openingCloseChannels&#x27;&#x27; estiver preenchida a opção &#x27;&#x27;OUTROS&#x27;&#x27; 
        /// </summary>
        /// <value>Texto livre para complementar informação relativa ao Canal disponível, quando no campo &#x27;&#x27;openingClosingChannels&#x27;&#x27; estiver preenchida a opção &#x27;&#x27;Outros&#x27;&#x27; Restrição: Campo de preenchimento obrigatório se &#x27;&#x27;openingCloseChannels&#x27;&#x27; estiver preenchida a opção &#x27;&#x27;OUTROS&#x27;&#x27; </value>
        [DataMember(Name="additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Lista de formas de movimentação
        /// </summary>
        /// <value>Lista de formas de movimentação</value>
        [Required]
        [DataMember(Name="transactionMethods")]
        public List<TransactionMethods> TransactionMethods { get; set; }

        /// <summary>
        /// Gets or Sets TermsConditions
        /// </summary>
        [Required]
        [DataMember(Name="termsConditions")]
        public AccountsTermsConditions TermsConditions { get; set; }

        /// <summary>
        /// Gets or Sets IncomeRate
        /// </summary>
        [Required]
        [DataMember(Name="incomeRate")]
        public AccountsIncomeRate IncomeRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessAccounts {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  ServiceBundles: ").Append(ServiceBundles).Append("\n");
            sb.Append("  OpeningClosingChannels: ").Append(OpeningClosingChannels).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("  TransactionMethods: ").Append(TransactionMethods).Append("\n");
            sb.Append("  TermsConditions: ").Append(TermsConditions).Append("\n");
            sb.Append("  IncomeRate: ").Append(IncomeRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((BusinessAccounts)obj);
        }

        /// <summary>
        /// Returns true if BusinessAccounts instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessAccounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessAccounts other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Fees == other.Fees ||
                    Fees != null &&
                    Fees.Equals(other.Fees)
                ) && 
                (
                    ServiceBundles == other.ServiceBundles ||
                    ServiceBundles != null &&
                    ServiceBundles.SequenceEqual(other.ServiceBundles)
                ) && 
                (
                    OpeningClosingChannels == other.OpeningClosingChannels ||
                    OpeningClosingChannels != null &&
                    OpeningClosingChannels.SequenceEqual(other.OpeningClosingChannels)
                ) && 
                (
                    AdditionalInfo == other.AdditionalInfo ||
                    AdditionalInfo != null &&
                    AdditionalInfo.Equals(other.AdditionalInfo)
                ) && 
                (
                    TransactionMethods == other.TransactionMethods ||
                    TransactionMethods != null &&
                    TransactionMethods.SequenceEqual(other.TransactionMethods)
                ) && 
                (
                    TermsConditions == other.TermsConditions ||
                    TermsConditions != null &&
                    TermsConditions.Equals(other.TermsConditions)
                ) && 
                (
                    IncomeRate == other.IncomeRate ||
                    IncomeRate != null &&
                    IncomeRate.Equals(other.IncomeRate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Fees != null)
                    hashCode = hashCode * 59 + Fees.GetHashCode();
                    if (ServiceBundles != null)
                    hashCode = hashCode * 59 + ServiceBundles.GetHashCode();
                    if (OpeningClosingChannels != null)
                    hashCode = hashCode * 59 + OpeningClosingChannels.GetHashCode();
                    if (AdditionalInfo != null)
                    hashCode = hashCode * 59 + AdditionalInfo.GetHashCode();
                    if (TransactionMethods != null)
                    hashCode = hashCode * 59 + TransactionMethods.GetHashCode();
                    if (TermsConditions != null)
                    hashCode = hashCode * 59 + TermsConditions.GetHashCode();
                    if (IncomeRate != null)
                    hashCode = hashCode * 59 + IncomeRate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BusinessAccounts left, BusinessAccounts right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BusinessAccounts left, BusinessAccounts right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
