/*
 * APIs OpenData do Open Banking Brasil
 *
 * As APIs descritas neste documento são referentes as APIs da fase OpenData do Open Banking Brasil.
 *
 * OpenAPI spec version: 2.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using BGB.OpenBanking.Api.Contracts.Common;
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
    ///
    /// </summary>
    [DataContract]
    public partial class BankingAgentsContractor : CNPJ, IEquatable<BankingAgentsContractor>
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets BankingAgents
        /// </summary>
        [DataMember(Name = "bankingAgents")]
        public List<BankingAgent> BankingAgents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankingAgentsContractor {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BankingAgents: ").Append(BankingAgents).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BankingAgentsContractor)obj);
        }

        /// <summary>
        /// Returns true if BankingAgentsContractor instances are equal
        /// </summary>
        /// <param name="other">Instance of BankingAgentsContractor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankingAgentsContractor other)
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
                    BankingAgents == other.BankingAgents ||
                    BankingAgents != null &&
                    BankingAgents.SequenceEqual(other.BankingAgents)
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
                if (BankingAgents != null)
                    hashCode = hashCode * 59 + BankingAgents.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(BankingAgentsContractor left, BankingAgentsContractor right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BankingAgentsContractor left, BankingAgentsContractor right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}