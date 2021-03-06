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
    public partial class BusinessUnarrangedAccountOverdraftCompany : Company, IEquatable<BusinessUnarrangedAccountOverdraftCompany>
    {
        /// <summary>
        /// Lista de adiantamento a depositante
        /// </summary>
        /// <value>Lista de adiantamento a depositante</value>
        [Required]
        [DataMember(Name = "businessUnarrangedAccountOverdraft")]
        public List<BusinessUnarrangedAccountOverdraft> BusinessUnarrangedAccountOverdraft { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessUnarrangedAccountOverdraftCompany {\n");
            sb.Append("  BusinessUnarrangedAccountOverdraft: ").Append(BusinessUnarrangedAccountOverdraft).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BusinessUnarrangedAccountOverdraftCompany)obj);
        }

        /// <summary>
        /// Returns true if BusinessUnarrangedAccountOverdraftCompany instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessUnarrangedAccountOverdraftCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessUnarrangedAccountOverdraftCompany other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    BusinessUnarrangedAccountOverdraft == other.BusinessUnarrangedAccountOverdraft ||
                    BusinessUnarrangedAccountOverdraft != null &&
                    BusinessUnarrangedAccountOverdraft.SequenceEqual(other.BusinessUnarrangedAccountOverdraft)
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
                if (BusinessUnarrangedAccountOverdraft != null)
                    hashCode = hashCode * 59 + BusinessUnarrangedAccountOverdraft.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(BusinessUnarrangedAccountOverdraftCompany left, BusinessUnarrangedAccountOverdraftCompany right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BusinessUnarrangedAccountOverdraftCompany left, BusinessUnarrangedAccountOverdraftCompany right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}