/*
 * APIs OpenData do Open Banking Brasil
 *
 * As APIs descritas neste documento são referentes as APIs da fase OpenData do Open Banking Brasil.
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

namespace BGB.OpenBanking.Api.Areas.Products_Services.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class BranchAvailability : IEquatable<BranchAvailability>
    {
        /// <summary>
        /// Gets or Sets Standards
        /// </summary>
        [Required]
        [DataMember(Name = "standards")]
        public List<BranchAvailabilityStandards> Standards { get; set; }

        /// <summary>
        /// Gets or Sets Exception
        /// </summary>
        [Required]
        [DataMember(Name = "exception")]
        public string Exception { get; set; }

        /// <summary>
        /// Gets or Sets IsPublicAccessAllowed
        /// </summary>
        [DataMember(Name = "isPublicAccessAllowed")]
        public bool? IsPublicAccessAllowed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BranchAvailability {\n");
            sb.Append("  Standards: ").Append(Standards).Append("\n");
            sb.Append("  Exception: ").Append(Exception).Append("\n");
            sb.Append("  IsPublicAccessAllowed: ").Append(IsPublicAccessAllowed).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BranchAvailability)obj);
        }

        /// <summary>
        /// Returns true if BranchAvailability instances are equal
        /// </summary>
        /// <param name="other">Instance of BranchAvailability to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BranchAvailability other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Standards == other.Standards ||
                    Standards != null &&
                    Standards.SequenceEqual(other.Standards)
                ) &&
                (
                    Exception == other.Exception ||
                    Exception != null &&
                    Exception.Equals(other.Exception)
                ) &&
                (
                    IsPublicAccessAllowed == other.IsPublicAccessAllowed ||
                    IsPublicAccessAllowed != null &&
                    IsPublicAccessAllowed.Equals(other.IsPublicAccessAllowed)
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
                if (Standards != null)
                    hashCode = hashCode * 59 + Standards.GetHashCode();
                if (Exception != null)
                    hashCode = hashCode * 59 + Exception.GetHashCode();
                if (IsPublicAccessAllowed != null)
                    hashCode = hashCode * 59 + IsPublicAccessAllowed.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(BranchAvailability left, BranchAvailability right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BranchAvailability left, BranchAvailability right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}