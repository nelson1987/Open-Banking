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
    public partial class ElectronicChannel : IEquatable<ElectronicChannel>
    { 
        /// <summary>
        /// Gets or Sets Identification
        /// </summary>
        [Required]
        [DataMember(Name="identification")]
        public ElectronicChannelIdentification Identification { get; set; }

        /// <summary>
        /// Traz a relação de serviços disponbilizados pelo Canal de Atendimento
        /// </summary>
        /// <value>Traz a relação de serviços disponbilizados pelo Canal de Atendimento</value>
        [Required]
        [DataMember(Name="services")]
        public List<ElectronicChannelService> Services { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElectronicChannel {\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ElectronicChannel)obj);
        }

        /// <summary>
        /// Returns true if ElectronicChannel instances are equal
        /// </summary>
        /// <param name="other">Instance of ElectronicChannel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElectronicChannel other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Identification == other.Identification ||
                    Identification != null &&
                    Identification.Equals(other.Identification)
                ) && 
                (
                    Services == other.Services ||
                    Services != null &&
                    Services.SequenceEqual(other.Services)
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
                    if (Identification != null)
                    hashCode = hashCode * 59 + Identification.GetHashCode();
                    if (Services != null)
                    hashCode = hashCode * 59 + Services.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ElectronicChannel left, ElectronicChannel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ElectronicChannel left, ElectronicChannel right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
