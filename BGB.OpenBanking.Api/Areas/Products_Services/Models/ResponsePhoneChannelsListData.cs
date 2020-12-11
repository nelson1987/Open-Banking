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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BGB.OpenBanking.Api.Areas.Products_Services.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class ResponsePhoneChannelsListData : IEquatable<ResponsePhoneChannelsListData>
    {
        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [Required]
        [DataMember(Name = "brand")]
        public PhoneChannelsBrand Brand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponsePhoneChannelsListData {\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ResponsePhoneChannelsListData)obj);
        }

        /// <summary>
        /// Returns true if ResponsePhoneChannelsListData instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponsePhoneChannelsListData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponsePhoneChannelsListData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Brand == other.Brand ||
                    Brand != null &&
                    Brand.Equals(other.Brand)
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
                if (Brand != null)
                    hashCode = hashCode * 59 + Brand.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(ResponsePhoneChannelsListData left, ResponsePhoneChannelsListData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ResponsePhoneChannelsListData left, ResponsePhoneChannelsListData right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}