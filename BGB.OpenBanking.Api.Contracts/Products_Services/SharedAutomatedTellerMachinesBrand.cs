using BGB.OpenBanking.Api.Contracts.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BGB.OpenBanking.Api.Contracts.Products_Services
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class SharedAutomatedTellerMachinesBrand : Brand, IEquatable<SharedAutomatedTellerMachinesBrand>
    {
        /// <summary>
        /// Lista de instituições pertencentes à marca
        /// </summary>
        /// <value>Lista de instituições pertencentes à marca</value>
        [DataMember(Name = "companies")]
        public List<SharedAutomatedTellerMachinesCompanies> Companies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharedAutomatedTellerMachinesBrand {\n");
            sb.Append("  Companies: ").Append(Companies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public new string ToJson()
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
            return obj.GetType() == GetType() && Equals((SharedAutomatedTellerMachinesBrand)obj);
        }

        /// <summary>
        /// Returns true if SharedAutomatedTellerMachinesBrand instances are equal
        /// </summary>
        /// <param name="other">Instance of SharedAutomatedTellerMachinesBrand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedAutomatedTellerMachinesBrand other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
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
                if (Companies != null)
                    hashCode = hashCode * 59 + Companies.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(SharedAutomatedTellerMachinesBrand left, SharedAutomatedTellerMachinesBrand right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SharedAutomatedTellerMachinesBrand left, SharedAutomatedTellerMachinesBrand right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}