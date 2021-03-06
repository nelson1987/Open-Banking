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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BGB.OpenBanking.Api.Contracts.Common
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class PersonalCreditCardCompany : Company, IEquatable<PersonalCreditCardCompany>
    {
        /// <summary>
        /// Lista das contas de pagamento pós-paga
        /// </summary>
        /// <value>Lista das contas de pagamento pós-paga</value>
        [Required]
        [DataMember(Name = "personalCreditCards")]
        public List<CreditCard> PersonalCreditCards { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonalCreditCardCompany {\n");
            sb.Append("  PersonalCreditCards: ").Append(PersonalCreditCards).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
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
            return obj.GetType() == GetType() && Equals((PersonalCreditCardCompany)obj);
        }

        /// <summary>
        /// Returns true if PersonalCreditCardCompany instances are equal
        /// </summary>
        /// <param name="other">Instance of PersonalCreditCardCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalCreditCardCompany other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    PersonalCreditCards == other.PersonalCreditCards ||
                    PersonalCreditCards != null &&
                    PersonalCreditCards.SequenceEqual(other.PersonalCreditCards)
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
                if (PersonalCreditCards != null)
                    hashCode = hashCode * 59 + PersonalCreditCards.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(PersonalCreditCardCompany left, PersonalCreditCardCompany right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PersonalCreditCardCompany left, PersonalCreditCardCompany right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}