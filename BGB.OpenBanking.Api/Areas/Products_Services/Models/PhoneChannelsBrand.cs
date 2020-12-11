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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BGB.OpenBanking.Api.Areas.Products_Services.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class PhoneChannelsBrand : IEquatable<PhoneChannelsBrand>
    {
        /// <summary>
        /// Nome da Marca reportada pelo participante do Open Banking. O conceito a que se refere a &#x27;marca&#x27; utilizada está em definição pelos participantes.
        /// </summary>
        /// <value>Nome da Marca reportada pelo participante do Open Banking. O conceito a que se refere a &#x27;marca&#x27; utilizada está em definição pelos participantes.</value>
        [Required]
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Lista de instituições pertencentes à marca
        /// </summary>
        /// <value>Lista de instituições pertencentes à marca</value>
        [Required]
        [DataMember(Name = "companies")]
        public List<PhoneChannelsCompany> Companies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneChannelsBrand {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Companies: ").Append(Companies).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PhoneChannelsBrand)obj);
        }

        /// <summary>
        /// Returns true if PhoneChannelsBrand instances are equal
        /// </summary>
        /// <param name="other">Instance of PhoneChannelsBrand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneChannelsBrand other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    Companies == other.Companies ||
                    Companies != null &&
                    Companies.SequenceEqual(other.Companies)
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Companies != null)
                    hashCode = hashCode * 59 + Companies.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(PhoneChannelsBrand left, PhoneChannelsBrand right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PhoneChannelsBrand left, PhoneChannelsBrand right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}