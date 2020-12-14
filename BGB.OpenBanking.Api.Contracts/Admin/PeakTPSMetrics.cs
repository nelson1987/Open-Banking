using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BGB.OpenBanking.Api.Contracts.Admin
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class PeakTPSMetrics : IEquatable<PeakTPSMetrics>
    {
        /// <summary>
        /// Gets or Sets CurrentDay
        /// </summary>
        [Required]
        [DataMember(Name = "currentDay")]
        public int? CurrentDay { get; set; }

        /// <summary>
        /// Gets or Sets PreviousDays
        /// </summary>
        [Required]
        [DataMember(Name = "previousDays")]
        public List<int?> PreviousDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeakTPSMetrics {\n");
            sb.Append("  CurrentDay: ").Append(CurrentDay).Append("\n");
            sb.Append("  PreviousDays: ").Append(PreviousDays).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PeakTPSMetrics)obj);
        }

        /// <summary>
        /// Returns true if PeakTPSMetrics instances are equal
        /// </summary>
        /// <param name="other">Instance of PeakTPSMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PeakTPSMetrics other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    CurrentDay == other.CurrentDay ||
                    CurrentDay != null &&
                    CurrentDay.Equals(other.CurrentDay)
                ) &&
                (
                    PreviousDays == other.PreviousDays ||
                    PreviousDays != null &&
                    PreviousDays.SequenceEqual(other.PreviousDays)
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
                if (CurrentDay != null)
                    hashCode = hashCode * 59 + CurrentDay.GetHashCode();
                if (PreviousDays != null)
                    hashCode = hashCode * 59 + PreviousDays.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(PeakTPSMetrics left, PeakTPSMetrics right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PeakTPSMetrics left, PeakTPSMetrics right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}