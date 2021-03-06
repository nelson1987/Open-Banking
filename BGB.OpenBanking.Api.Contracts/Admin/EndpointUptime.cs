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
    public partial class EndpointUptime : IEquatable<EndpointUptime>
    {
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [Required]
        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets UptimeRate
        /// </summary>
        [Required]
        [DataMember(Name = "uptimeRate")]
        public string UptimeRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointUptime {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UptimeRate: ").Append(UptimeRate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EndpointUptime)obj);
        }

        /// <summary>
        /// Returns true if EndpointUptime instances are equal
        /// </summary>
        /// <param name="other">Instance of EndpointUptime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndpointUptime other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Url == other.Url ||
                    Url != null &&
                    Url.Equals(other.Url)
                ) &&
                (
                    UptimeRate == other.UptimeRate ||
                    UptimeRate != null &&
                    UptimeRate.Equals(other.UptimeRate)
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
                if (Url != null)
                    hashCode = hashCode * 59 + Url.GetHashCode();
                if (UptimeRate != null)
                    hashCode = hashCode * 59 + UptimeRate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(EndpointUptime left, EndpointUptime right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EndpointUptime left, EndpointUptime right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}