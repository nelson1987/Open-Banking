using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BGB.OpenBanking.Api.Contracts.Admin
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class AverageMetrics : IEquatable<AverageMetrics>
    {
        /// <summary>
        /// Gets or Sets Unauthenticated
        /// </summary>
        [Required]
        [DataMember(Name = "unauthenticated")]
        public InvocationMetricsUnauthenticated Unauthenticated { get; set; }

        /// <summary>
        /// Gets or Sets HighPriority
        /// </summary>
        [Required]
        [DataMember(Name = "highPriority")]
        public InvocationMetricsUnauthenticated HighPriority { get; set; }

        /// <summary>
        /// Gets or Sets MediumPriority
        /// </summary>
        [Required]
        [DataMember(Name = "mediumPriority")]
        public InvocationMetricsUnauthenticated MediumPriority { get; set; }

        /// <summary>
        /// Gets or Sets Unattended
        /// </summary>
        [Required]
        [DataMember(Name = "unattended")]
        public InvocationMetricsUnauthenticated Unattended { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AverageMetrics {\n");
            sb.Append("  Unauthenticated: ").Append(Unauthenticated).Append("\n");
            sb.Append("  HighPriority: ").Append(HighPriority).Append("\n");
            sb.Append("  MediumPriority: ").Append(MediumPriority).Append("\n");
            sb.Append("  Unattended: ").Append(Unattended).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AverageMetrics)obj);
        }

        /// <summary>
        /// Returns true if AverageMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of AverageMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AverageMetrics other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Unauthenticated == other.Unauthenticated ||
                    Unauthenticated != null &&
                    Unauthenticated.Equals(other.Unauthenticated)
                ) &&
                (
                    HighPriority == other.HighPriority ||
                    HighPriority != null &&
                    HighPriority.Equals(other.HighPriority)
                ) &&
                (
                    MediumPriority == other.MediumPriority ||
                    MediumPriority != null &&
                    MediumPriority.Equals(other.MediumPriority)
                ) &&
                (
                    Unattended == other.Unattended ||
                    Unattended != null &&
                    Unattended.Equals(other.Unattended)
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
                if (Unauthenticated != null)
                    hashCode = hashCode * 59 + Unauthenticated.GetHashCode();
                if (HighPriority != null)
                    hashCode = hashCode * 59 + HighPriority.GetHashCode();
                if (MediumPriority != null)
                    hashCode = hashCode * 59 + MediumPriority.GetHashCode();
                if (Unattended != null)
                    hashCode = hashCode * 59 + Unattended.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(AverageMetrics left, AverageMetrics right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AverageMetrics left, AverageMetrics right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}