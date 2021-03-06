using BGB.OpenBanking.Api.Contracts.Admin;
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
    public partial class AvailabilityMetricsDowntime : IEquatable<AvailabilityMetricsDowntime>
    {
        /// <summary>
        /// Gets or Sets GeneralDowntime
        /// </summary>
        [Required]
        [DataMember(Name = "generalDowntime")]
        public int? GeneralDowntime { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledOutage
        /// </summary>
        [Required]
        [DataMember(Name = "scheduledOutage")]
        public int? ScheduledOutage { get; set; }

        /// <summary>
        /// Gets or Sets Endpoints
        /// </summary>
        [Required]
        [DataMember(Name = "endpoints")]
        public EndpointDowntime Endpoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailabilityMetricsDowntime {\n");
            sb.Append("  GeneralDowntime: ").Append(GeneralDowntime).Append("\n");
            sb.Append("  ScheduledOutage: ").Append(ScheduledOutage).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AvailabilityMetricsDowntime)obj);
        }

        /// <summary>
        /// Returns true if AvailabilityMetricsDowntime instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailabilityMetricsDowntime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailabilityMetricsDowntime other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    GeneralDowntime == other.GeneralDowntime ||
                    GeneralDowntime != null &&
                    GeneralDowntime.Equals(other.GeneralDowntime)
                ) &&
                (
                    ScheduledOutage == other.ScheduledOutage ||
                    ScheduledOutage != null &&
                    ScheduledOutage.Equals(other.ScheduledOutage)
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
                if (GeneralDowntime != null)
                    hashCode = hashCode * 59 + GeneralDowntime.GetHashCode();
                if (ScheduledOutage != null)
                    hashCode = hashCode * 59 + ScheduledOutage.GetHashCode();
                if (Endpoints != null)
                    hashCode = hashCode * 59 + Endpoints.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(AvailabilityMetricsDowntime left, AvailabilityMetricsDowntime right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AvailabilityMetricsDowntime left, AvailabilityMetricsDowntime right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}