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

namespace BGB.OpenBanking.Api.Contracts.Products_Services
{
    /// <summary>
    /// Dependência de instituições financeiras e demais instituições, autorizadas a funcionar pelo Banco Central do Brasil, destinada à prática das atividades para as quais a instituição esteja regularmente habilitada.
    /// </summary>
    [DataContract]
    public partial class Branch : IEquatable<Branch>
    {
        /// <summary>
        /// Gets or Sets Identification
        /// </summary>
        [Required]
        [DataMember(Name = "identification")]
        public BranchIdentification Identification { get; set; }

        /// <summary>
        /// Gets or Sets PostalAddresses
        /// </summary>
        [DataMember(Name = "postalAddresses")]
        public BranchPostalAddress PostalAddresses { get; set; }

        /// <summary>
        /// Gets or Sets Availability
        /// </summary>
        [Required]
        [DataMember(Name = "availability")]
        public BranchAvailability Availability { get; set; }

        /// <summary>
        /// Gets or Sets Phones
        /// </summary>
        [DataMember(Name = "phones")]
        public List<Phone> Phones { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [Required]
        [DataMember(Name = "services")]
        public List<BranchServices> Services { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Branch {\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  PostalAddresses: ").Append(PostalAddresses).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  Phones: ").Append(Phones).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Branch)obj);
        }

        /// <summary>
        /// Returns true if Branch instances are equal
        /// </summary>
        /// <param name="other">Instance of Branch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Branch other)
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
                    PostalAddresses == other.PostalAddresses ||
                    PostalAddresses != null &&
                    PostalAddresses.Equals(other.PostalAddresses)
                ) &&
                (
                    Availability == other.Availability ||
                    Availability != null &&
                    Availability.Equals(other.Availability)
                ) &&
                (
                    Phones == other.Phones ||
                    Phones != null &&
                    Phones.SequenceEqual(other.Phones)
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
                if (PostalAddresses != null)
                    hashCode = hashCode * 59 + PostalAddresses.GetHashCode();
                if (Availability != null)
                    hashCode = hashCode * 59 + Availability.GetHashCode();
                if (Phones != null)
                    hashCode = hashCode * 59 + Phones.GetHashCode();
                if (Services != null)
                    hashCode = hashCode * 59 + Services.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(Branch left, Branch right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Branch left, Branch right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}