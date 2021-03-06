/*
 * API's OpenData do Open Banking Brasil
 *
 * As API's descritas neste documento são referentes as API's da fase OpenData do Open Banking Brasil.
 *
 * OpenAPI spec version: 2.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BGB.OpenBanking.Api.Contracts.Common
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class CreditCard : IEquatable<CreditCard>
    {
        /// <summary>
        /// Denominação/Identificação do nome da conta (cartão de crédito)
        /// </summary>
        /// <value>Denominação/Identificação do nome da conta (cartão de crédito)</value>
        [Required]
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Identification
        /// </summary>
        [Required]
        [DataMember(Name = "identification")]
        public CreditCardIdentification Identification { get; set; }

        /// <summary>
        /// Gets or Sets RewardsProgram
        /// </summary>
        [Required]
        [DataMember(Name = "rewardsProgram")]
        public CreditCardRewardsProgram RewardsProgram { get; set; }

        /// <summary>
        /// Gets or Sets Fees
        /// </summary>
        [Required]
        [DataMember(Name = "fees")]
        public CreditCardFees Fees { get; set; }

        /// <summary>
        /// Gets or Sets Interest
        /// </summary>
        [Required]
        [DataMember(Name = "interest")]
        public CreditCardInterest Interest { get; set; }

        /// <summary>
        /// Gets or Sets TermsConditions
        /// </summary>
        [Required]
        [DataMember(Name = "termsConditions")]
        public CreditCardTermsConditions TermsConditions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCard {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  RewardsProgram: ").Append(RewardsProgram).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  Interest: ").Append(Interest).Append("\n");
            sb.Append("  TermsConditions: ").Append(TermsConditions).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreditCard)obj);
        }

        /// <summary>
        /// Returns true if CreditCard instances are equal
        /// </summary>
        /// <param name="other">Instance of CreditCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCard other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    Identification == other.Identification ||
                    Identification != null &&
                    Identification.Equals(other.Identification)
                ) &&
                (
                    RewardsProgram == other.RewardsProgram ||
                    RewardsProgram != null &&
                    RewardsProgram.Equals(other.RewardsProgram)
                ) &&
                (
                    Fees == other.Fees ||
                    Fees != null &&
                    Fees.Equals(other.Fees)
                ) &&
                (
                    Interest == other.Interest ||
                    Interest != null &&
                    Interest.Equals(other.Interest)
                ) &&
                (
                    TermsConditions == other.TermsConditions ||
                    TermsConditions != null &&
                    TermsConditions.Equals(other.TermsConditions)
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Identification != null)
                    hashCode = hashCode * 59 + Identification.GetHashCode();
                if (RewardsProgram != null)
                    hashCode = hashCode * 59 + RewardsProgram.GetHashCode();
                if (Fees != null)
                    hashCode = hashCode * 59 + Fees.GetHashCode();
                if (Interest != null)
                    hashCode = hashCode * 59 + Interest.GetHashCode();
                if (TermsConditions != null)
                    hashCode = hashCode * 59 + TermsConditions.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(CreditCard left, CreditCard right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreditCard left, CreditCard right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}