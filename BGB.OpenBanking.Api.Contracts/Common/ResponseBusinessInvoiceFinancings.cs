/*
 * API's OpenData do Open Banking Brasil
 *
 * As API's descritas neste documento são referentes as API's da fase OpenData do Open Banking Brasil.
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

namespace BGB.OpenBanking.Api.Contracts.Common
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class ResponseBusinessInvoiceFinancings : IEquatable<ResponseBusinessInvoiceFinancings>
    {
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [Required]
        [DataMember(Name = "data")]
        public ResponseBusinessInvoiceFinancingsData Data { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [Required]
        [DataMember(Name = "links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [Required]
        [DataMember(Name = "meta")]
        public Meta Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseBusinessInvoiceFinancings {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ResponseBusinessInvoiceFinancings)obj);
        }

        /// <summary>
        /// Returns true if ResponseBusinessInvoiceFinancings instances are equal
        /// </summary>
        /// <param name="other">Instance of ResponseBusinessInvoiceFinancings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseBusinessInvoiceFinancings other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.Equals(other.Data)
                ) &&
                (
                    Links == other.Links ||
                    Links != null &&
                    Links.Equals(other.Links)
                ) &&
                (
                    Meta == other.Meta ||
                    Meta != null &&
                    Meta.Equals(other.Meta)
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
                if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                if (Meta != null)
                    hashCode = hashCode * 59 + Meta.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(ResponseBusinessInvoiceFinancings left, ResponseBusinessInvoiceFinancings right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ResponseBusinessInvoiceFinancings left, ResponseBusinessInvoiceFinancings right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}