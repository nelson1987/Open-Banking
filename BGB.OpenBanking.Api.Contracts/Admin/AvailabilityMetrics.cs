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
    public partial class AvailabilityMetrics : IEquatable<AvailabilityMetrics>
    {
        /// <summary>
        /// Gets or Sets Uptime
        /// </summary>
        [Required]
        [DataMember(Name = "uptime")]
        public AvailabilityMetricsUptime Uptime { get; set; }

        /// <summary>
        /// Gets or Sets Downtime
        /// </summary>
        [Required]
        [DataMember(Name = "downtime")]
        public AvailabilityMetricsDowntime Downtime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityMetrics {\n");
            sb.Append("  Uptime: ").Append(Uptime).Append("\n");
            sb.Append("  Downtime: ").Append(Downtime).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AvailabilityMetrics)obj);
        }

        /// <summary>
        /// Returns true if AvailabilityMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailabilityMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailabilityMetrics other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Uptime == other.Uptime ||
                    Uptime != null &&
                    Uptime.Equals(other.Uptime)
                ) &&
                (
                    Downtime == other.Downtime ||
                    Downtime != null &&
                    Downtime.Equals(other.Downtime)
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
                if (Uptime != null)
                    hashCode = hashCode * 59 + Uptime.GetHashCode();
                if (Downtime != null)
                    hashCode = hashCode * 59 + Downtime.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(AvailabilityMetrics left, AvailabilityMetrics right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AvailabilityMetrics left, AvailabilityMetrics right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}