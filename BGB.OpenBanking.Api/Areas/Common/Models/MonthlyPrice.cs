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
    /// 
    /// </summary>
    [DataContract]
    public partial class MonthlyPrice : IEquatable<MonthlyPrice>
    { 
        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [Required]
        [DataMember(Name="interval")]
        public PriceIntervals Interval { get; set; }

        /// <summary>
        /// Valor da mediana de cada faixa relativa ao serviço ofertado, informado no período, conforme Res nº 32 BCB, 2020. p.ex. &#x27;&#x27;45.00&#x27;&#x27; (representa um valor monetário. p.ex: 1547368.92. Este valor, considerando que a moeda seja BRL, significa R$ 1.547.368,92. O único separador presente deve ser o &#x27;&#x27;.&#x27;&#x27; (ponto) para indicar a casa decimal. Não deve haver separador de milhar) 
        /// </summary>
        /// <value>Valor da mediana de cada faixa relativa ao serviço ofertado, informado no período, conforme Res nº 32 BCB, 2020. p.ex. &#x27;&#x27;45.00&#x27;&#x27; (representa um valor monetário. p.ex: 1547368.92. Este valor, considerando que a moeda seja BRL, significa R$ 1.547.368,92. O único separador presente deve ser o &#x27;&#x27;.&#x27;&#x27; (ponto) para indicar a casa decimal. Não deve haver separador de milhar) </value>
        [Required]
        [DataMember(Name="monthlyFee")]
        public string MonthlyFee { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [Required]
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Customers
        /// </summary>
        [Required]
        [DataMember(Name="customers")]
        public Customer Customers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MonthlyPrice {\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  MonthlyFee: ").Append(MonthlyFee).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customers: ").Append(Customers).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MonthlyPrice)obj);
        }

        /// <summary>
        /// Returns true if MonthlyPrice instances are equal
        /// </summary>
        /// <param name="other">Instance of MonthlyPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonthlyPrice other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Interval == other.Interval ||
                    Interval != null &&
                    Interval.Equals(other.Interval)
                ) && 
                (
                    MonthlyFee == other.MonthlyFee ||
                    MonthlyFee != null &&
                    MonthlyFee.Equals(other.MonthlyFee)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                ) && 
                (
                    Customers == other.Customers ||
                    Customers != null &&
                    Customers.Equals(other.Customers)
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
                    if (Interval != null)
                    hashCode = hashCode * 59 + Interval.GetHashCode();
                    if (MonthlyFee != null)
                    hashCode = hashCode * 59 + MonthlyFee.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                    if (Customers != null)
                    hashCode = hashCode * 59 + Customers.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MonthlyPrice left, MonthlyPrice right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MonthlyPrice left, MonthlyPrice right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
