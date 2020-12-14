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
    public partial class EndpointDowntime : IEquatable<EndpointDowntime>
    {
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [Required]
        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets PartialDowntime
        /// </summary>
        [Required]
        [DataMember(Name = "partialDowntime")]
        public int? PartialDowntime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndpointDowntime {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  PartialDowntime: ").Append(PartialDowntime).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EndpointDowntime)obj);
        }

        /// <summary>
        /// Returns true if EndpointDowntime instances are equal
        /// </summary>
        /// <param name="other">Instance of EndpointDowntime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndpointDowntime other)
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
                    PartialDowntime == other.PartialDowntime ||
                    PartialDowntime != null &&
                    PartialDowntime.Equals(other.PartialDowntime)
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
                if (PartialDowntime != null)
                    hashCode = hashCode * 59 + PartialDowntime.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(EndpointDowntime left, EndpointDowntime right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EndpointDowntime left, EndpointDowntime right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}