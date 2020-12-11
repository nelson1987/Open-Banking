using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BGB.OpenBanking.Api.Areas.Admin.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class ResponseMetricsListData : IEquatable<ResponseMetricsListData>
    {
        /// <summary>
        /// Gets or Sets RequestTime
        /// </summary>
        [Required]
        [DataMember(Name = "requestTime")]
        public DateTime? RequestTime { get; set; }

        /// <summary>
        /// Gets or Sets Availability
        /// </summary>
        [Required]
        [DataMember(Name = "availability")]
        public AvailabilityMetrics Availability { get; set; }

        /// <summary>
        /// Gets or Sets Invocations
        /// </summary>
        [Required]
        [DataMember(Name = "invocations")]
        public InvocationMetrics Invocations { get; set; }

        /// <summary>
        /// Gets or Sets AverageResponse
        /// </summary>
        [Required]
        [DataMember(Name = "averageResponse")]
        public AverageMetrics AverageResponse { get; set; }

        /// <summary>
        /// Gets or Sets AverageTps
        /// </summary>
        [Required]
        [DataMember(Name = "averageTps")]
        public AverageTPSMetrics AverageTps { get; set; }

        /// <summary>
        /// Gets or Sets PeakTps
        /// </summary>
        [Required]
        [DataMember(Name = "peakTps")]
        public PeakTPSMetrics PeakTps { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [Required]
        [DataMember(Name = "errors")]
        public ErrorMetrics Errors { get; set; }

        /// <summary>
        /// Gets or Sets Rejections
        /// </summary>
        [Required]
        [DataMember(Name = "rejections")]
        public RejectionMetrics Rejections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseMetricsListData {\n");
            sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  Invocations: ").Append(Invocations).Append("\n");
            sb.Append("  AverageResponse: ").Append(AverageResponse).Append("\n");
            sb.Append("  AverageTps: ").Append(AverageTps).Append("\n");
            sb.Append("  PeakTps: ").Append(PeakTps).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Rejections: ").Append(Rejections).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ResponseMetricsListData)obj);
        }

        /// <summary>
        /// Returns true if ResponseMetricsListData instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseMetricsListData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseMetricsListData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    RequestTime == other.RequestTime ||
                    RequestTime != null &&
                    RequestTime.Equals(other.RequestTime)
                ) &&
                (
                    Availability == other.Availability ||
                    Availability != null &&
                    Availability.Equals(other.Availability)
                ) &&
                (
                    Invocations == other.Invocations ||
                    Invocations != null &&
                    Invocations.Equals(other.Invocations)
                ) &&
                (
                    AverageResponse == other.AverageResponse ||
                    AverageResponse != null &&
                    AverageResponse.Equals(other.AverageResponse)
                ) &&
                (
                    AverageTps == other.AverageTps ||
                    AverageTps != null &&
                    AverageTps.Equals(other.AverageTps)
                ) &&
                (
                    PeakTps == other.PeakTps ||
                    PeakTps != null &&
                    PeakTps.Equals(other.PeakTps)
                ) &&
                (
                    Errors == other.Errors ||
                    Errors != null &&
                    Errors.Equals(other.Errors)
                ) &&
                (
                    Rejections == other.Rejections ||
                    Rejections != null &&
                    Rejections.Equals(other.Rejections)
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
                if (RequestTime != null)
                    hashCode = hashCode * 59 + RequestTime.GetHashCode();
                if (Availability != null)
                    hashCode = hashCode * 59 + Availability.GetHashCode();
                if (Invocations != null)
                    hashCode = hashCode * 59 + Invocations.GetHashCode();
                if (AverageResponse != null)
                    hashCode = hashCode * 59 + AverageResponse.GetHashCode();
                if (AverageTps != null)
                    hashCode = hashCode * 59 + AverageTps.GetHashCode();
                if (PeakTps != null)
                    hashCode = hashCode * 59 + PeakTps.GetHashCode();
                if (Errors != null)
                    hashCode = hashCode * 59 + Errors.GetHashCode();
                if (Rejections != null)
                    hashCode = hashCode * 59 + Rejections.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(ResponseMetricsListData left, ResponseMetricsListData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ResponseMetricsListData left, ResponseMetricsListData right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}