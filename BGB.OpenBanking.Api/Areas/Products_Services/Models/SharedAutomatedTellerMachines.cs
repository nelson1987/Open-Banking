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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BGB.OpenBanking.Api.Areas.Products_Services.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class SharedAutomatedTellerMachines : IEquatable<SharedAutomatedTellerMachines>
    {
        /// <summary>
        /// Gets or Sets Identification
        /// </summary>
        [DataMember(Name = "identification")]
        public SharedAutomatedTellerMachinesIdentification Identification { get; set; }

        /// <summary>
        /// Gets or Sets PostalAddress
        /// </summary>
        [DataMember(Name = "postalAddress")]
        public SharedAutomatedTellerMachinesPostalAddress PostalAddress { get; set; }

        /// <summary>
        /// Gets or Sets Availability
        /// </summary>
        [DataMember(Name = "availability")]
        public SharedAutomatedTellerMachinesAvailability Availability { get; set; }

        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name = "services")]
        public List<SharedAutomatedTellerMachinesServices> Services { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharedAutomatedTellerMachines {\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SharedAutomatedTellerMachines)obj);
        }

        /// <summary>
        /// Returns true if SharedAutomatedTellerMachines instances are equal
        /// </summary>
        /// <param name="other">Instance of SharedAutomatedTellerMachines to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedAutomatedTellerMachines other)
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
                    PostalAddress == other.PostalAddress ||
                    PostalAddress != null &&
                    PostalAddress.Equals(other.PostalAddress)
                ) &&
                (
                    Availability == other.Availability ||
                    Availability != null &&
                    Availability.Equals(other.Availability)
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
                if (PostalAddress != null)
                    hashCode = hashCode * 59 + PostalAddress.GetHashCode();
                if (Availability != null)
                    hashCode = hashCode * 59 + Availability.GetHashCode();
                if (Services != null)
                    hashCode = hashCode * 59 + Services.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(SharedAutomatedTellerMachines left, SharedAutomatedTellerMachines right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SharedAutomatedTellerMachines left, SharedAutomatedTellerMachines right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}