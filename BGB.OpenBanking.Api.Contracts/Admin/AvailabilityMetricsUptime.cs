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
    public partial class AvailabilityMetricsUptime : IEquatable<AvailabilityMetricsUptime>
    {
        /// <summary>
        /// Gets or Sets GeneralUptimeRate
        /// </summary>
        [Required]
        [DataMember(Name = "generalUptimeRate")]
        public string GeneralUptimeRate { get; set; }

        /// <summary>
        /// Gets or Sets Endpoints
        /// </summary>
        [Required]
        [DataMember(Name = "endpoints")]
        public EndpointUptime Endpoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityMetricsUptime {\n");
            sb.Append("  GeneralUptimeRate: ").Append(GeneralUptimeRate).Append("\n");
            sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AvailabilityMetricsUptime)obj);
        }

        /// <summary>
        /// Returns true if AvailabilityMetricsUptime instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailabilityMetricsUptime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailabilityMetricsUptime other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    GeneralUptimeRate == other.GeneralUptimeRate ||
                    GeneralUptimeRate != null &&
                    GeneralUptimeRate.Equals(other.GeneralUptimeRate)
                ) &&
                (
                    Endpoints == other.Endpoints ||
                    Endpoints != null &&
                    Endpoints.Equals(other.Endpoints)
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
                if (GeneralUptimeRate != null)
                    hashCode = hashCode * 59 + GeneralUptimeRate.GetHashCode();
                if (Endpoints != null)
                    hashCode = hashCode * 59 + Endpoints.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(AvailabilityMetricsUptime left, AvailabilityMetricsUptime right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AvailabilityMetricsUptime left, AvailabilityMetricsUptime right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}