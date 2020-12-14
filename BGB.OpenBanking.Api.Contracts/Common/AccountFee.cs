using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BGB.OpenBanking.Api.Contracts.Common
{
    /// <summary>
    /// Objeto que reúne informações de tarifas de serviços
    /// </summary>
    [DataContract]
    public partial class AccountFee : IEquatable<AccountFee>
    {
        /// <summary>
        /// Lista das Tarifas cobradas sobre Serviços Prioritários
        /// </summary>
        /// <value>Lista das Tarifas cobradas sobre Serviços Prioritários</value>
        [Required]
        [DataMember(Name = "priorityServices")]
        public List<AccountPriorityService> PriorityServices { get; set; }

        /// <summary>
        /// Lista das Tarifas cobradas sobre outros Serviços, que não prioritários
        /// </summary>
        /// <value>Lista das Tarifas cobradas sobre outros Serviços, que não prioritários</value>
        [DataMember(Name = "otherServices")]
        public List<AccountOtherService> OtherServices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountFee {\n");
            sb.Append("  PriorityServices: ").Append(PriorityServices).Append("\n");
            sb.Append("  OtherServices: ").Append(OtherServices).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AccountFee)obj);
        }

        /// <summary>
        /// Returns true if AccountFee instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountFee other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    PriorityServices == other.PriorityServices ||
                    PriorityServices != null &&
                    PriorityServices.SequenceEqual(other.PriorityServices)
                ) &&
                (
                    OtherServices == other.OtherServices ||
                    OtherServices != null &&
                    OtherServices.SequenceEqual(other.OtherServices)
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
                if (PriorityServices != null)
                    hashCode = hashCode * 59 + PriorityServices.GetHashCode();
                if (OtherServices != null)
                    hashCode = hashCode * 59 + OtherServices.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(AccountFee left, AccountFee right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccountFee left, AccountFee right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}