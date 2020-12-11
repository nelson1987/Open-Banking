/*
 * API's OpenData do Open Banking Brasil
 *
 * As API's descritas neste documento são referentes as API's da fase OpenData do Open Banking Brasil.
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

namespace BGB.OpenBanking.Api.Areas.Common.Models
{ 
    /// <summary>
    /// Objeto que reúne informações de tarifas de serviços
    /// </summary>
    [DataContract]
    public partial class BusinessInvoiceFinancingsFees : IEquatable<BusinessInvoiceFinancingsFees>
    { 
        /// <summary>
        /// Lista das Tarifas cobradas sobre Serviços
        /// </summary>
        /// <value>Lista das Tarifas cobradas sobre Serviços</value>
        [Required]
        [DataMember(Name="services")]
        public List<InvoiceFinancingsService> Services { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessInvoiceFinancingsFees {\n");
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
            return obj.GetType() == GetType() && Equals((BusinessInvoiceFinancingsFees)obj);
        }

        /// <summary>
        /// Returns true if BusinessInvoiceFinancingsFees instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessInvoiceFinancingsFees to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessInvoiceFinancingsFees other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
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
                    if (Services != null)
                    hashCode = hashCode * 59 + Services.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BusinessInvoiceFinancingsFees left, BusinessInvoiceFinancingsFees right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BusinessInvoiceFinancingsFees left, BusinessInvoiceFinancingsFees right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
