/*
 * APIs OpenData do Open Banking Brasil
 *
 * As APIs descritas neste documento são referentes as APIs da fase OpenData do Open Banking Brasil.
 *
 * OpenAPI spec version: 2.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BGB.OpenBanking.Api.Areas.Products_Services.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class PhoneChannelPhone : IEquatable<PhoneChannelPhone>
    { 
        /// <summary>
        /// Número de DDI (Discagem Direta Internacional) para  telefone de acesso ao Canal - se houver.
        /// </summary>
        /// <value>Número de DDI (Discagem Direta Internacional) para  telefone de acesso ao Canal - se houver.</value>
        [Required]
        [DataMember(Name="countryCallingCode")]
        public string CountryCallingCode { get; set; }

        /// <summary>
        /// Número de DDD (Discagem Direta à Distância) para  telefone de acesso ao Canal - se houver.
        /// </summary>
        /// <value>Número de DDD (Discagem Direta à Distância) para  telefone de acesso ao Canal - se houver.</value>
        [Required]
        [DataMember(Name="areaCode")]
        public string AreaCode { get; set; }

        /// <summary>
        /// Número de telefone de acesso ao canal. 
        /// </summary>
        /// <value>Número de telefone de acesso ao canal. </value>
        [Required]
        [DataMember(Name="number")]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalInfo
        /// </summary>
        [DataMember(Name="additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneChannelPhone {\n");
            sb.Append("  CountryCallingCode: ").Append(CountryCallingCode).Append("\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PhoneChannelPhone)obj);
        }

        /// <summary>
        /// Returns true if PhoneChannelPhone instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneChannelPhone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneChannelPhone other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CountryCallingCode == other.CountryCallingCode ||
                    CountryCallingCode != null &&
                    CountryCallingCode.Equals(other.CountryCallingCode)
                ) && 
                (
                    AreaCode == other.AreaCode ||
                    AreaCode != null &&
                    AreaCode.Equals(other.AreaCode)
                ) && 
                (
                    Number == other.Number ||
                    Number != null &&
                    Number.Equals(other.Number)
                ) && 
                (
                    AdditionalInfo == other.AdditionalInfo ||
                    AdditionalInfo != null &&
                    AdditionalInfo.Equals(other.AdditionalInfo)
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
                    if (CountryCallingCode != null)
                    hashCode = hashCode * 59 + CountryCallingCode.GetHashCode();
                    if (AreaCode != null)
                    hashCode = hashCode * 59 + AreaCode.GetHashCode();
                    if (Number != null)
                    hashCode = hashCode * 59 + Number.GetHashCode();
                    if (AdditionalInfo != null)
                    hashCode = hashCode * 59 + AdditionalInfo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PhoneChannelPhone left, PhoneChannelPhone right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PhoneChannelPhone left, PhoneChannelPhone right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
