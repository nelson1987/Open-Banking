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
    public partial class SharedAutomatedTellerMachinesCompanies : SharedAutomatedTellerMachinesCompany, IEquatable<SharedAutomatedTellerMachinesCompanies>
    { 
        /// <summary>
        /// Gets or Sets SharedAutomatedTellerMachines
        /// </summary>
        [DataMember(Name="sharedAutomatedTellerMachines")]
        public List<SharedAutomatedTellerMachines> SharedAutomatedTellerMachines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharedAutomatedTellerMachinesCompanies {\n");
            sb.Append("  SharedAutomatedTellerMachines: ").Append(SharedAutomatedTellerMachines).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return obj.GetType() == GetType() && Equals((SharedAutomatedTellerMachinesCompanies)obj);
        }

        /// <summary>
        /// Returns true if SharedAutomatedTellerMachinesCompanies instances are equal
        /// </summary>
        /// <param name="other">Instance of SharedAutomatedTellerMachinesCompanies to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedAutomatedTellerMachinesCompanies other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SharedAutomatedTellerMachines == other.SharedAutomatedTellerMachines ||
                    SharedAutomatedTellerMachines != null &&
                    SharedAutomatedTellerMachines.SequenceEqual(other.SharedAutomatedTellerMachines)
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
                    if (SharedAutomatedTellerMachines != null)
                    hashCode = hashCode * 59 + SharedAutomatedTellerMachines.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SharedAutomatedTellerMachinesCompanies left, SharedAutomatedTellerMachinesCompanies right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SharedAutomatedTellerMachinesCompanies left, SharedAutomatedTellerMachinesCompanies right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}