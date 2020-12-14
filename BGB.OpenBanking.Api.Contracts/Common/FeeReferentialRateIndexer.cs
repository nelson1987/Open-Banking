/*
 * API's OpenData do Open Banking Brasil
 *
 * As API's descritas neste documento são referentes as API's da fase OpenData do Open Banking Brasil.
 *
 * OpenAPI spec version: 2.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BGB.OpenBanking.Api.Contracts.Common
{
    /// <summary>
    /// Tarifas cobradas sobre Serviços ofertados
    /// </summary>
    [DataContract]
    public partial class FeeReferentialRateIndexer : IEquatable<FeeReferentialRateIndexer>
    {
        /// <summary>
        /// Gets or Sets ReferentialRateIndexer
        /// </summary>
        [Required]
        [DataMember(Name = "referentialRateIndexer")]
        public ReferentialRateIndexer ReferentialRateIndexer { get; set; }

        /// <summary>
        /// Percentual que incide sobre a composição das taxas de juros remuneratórios. (representa uma porcentagem Ex: 0.15 (O valor ao lado representa 15%. O valor &#x27;1 &#x27;representa 100%). A apuração pode acontecer com até 4 casas decimais. O preenchimento deve respeitar as 4 casas decimais, mesmo que venham preenchidas com zeros (representação de porcentagem p.ex: 0.1500. Este valor representa 15%. O valor 1 representa 100%)
        /// </summary>
        /// <value>Percentual que incide sobre a composição das taxas de juros remuneratórios. (representa uma porcentagem Ex: 0.15 (O valor ao lado representa 15%. O valor &#x27;1 &#x27;representa 100%). A apuração pode acontecer com até 4 casas decimais. O preenchimento deve respeitar as 4 casas decimais, mesmo que venham preenchidas com zeros (representação de porcentagem p.ex: 0.1500. Este valor representa 15%. O valor 1 representa 100%) </value>
        [Required]
        [DataMember(Name = "rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeeReferentialRateIndexer {\n");
            sb.Append("  ReferentialRateIndexer: ").Append(ReferentialRateIndexer).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FeeReferentialRateIndexer)obj);
        }

        /// <summary>
        /// Returns true if FeeReferentialRateIndexer instances are equal
        /// </summary>
        /// <param name="other">Instance of FeeReferentialRateIndexer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeReferentialRateIndexer other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    ReferentialRateIndexer == other.ReferentialRateIndexer ||
                    ReferentialRateIndexer != null &&
                    ReferentialRateIndexer.Equals(other.ReferentialRateIndexer)
                ) &&
                (
                    Rate == other.Rate ||
                    Rate != null &&
                    Rate.Equals(other.Rate)
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
                if (ReferentialRateIndexer != null)
                    hashCode = hashCode * 59 + ReferentialRateIndexer.GetHashCode();
                if (Rate != null)
                    hashCode = hashCode * 59 + Rate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(FeeReferentialRateIndexer left, FeeReferentialRateIndexer right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FeeReferentialRateIndexer left, FeeReferentialRateIndexer right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}