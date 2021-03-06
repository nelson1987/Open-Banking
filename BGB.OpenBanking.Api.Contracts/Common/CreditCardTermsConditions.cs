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
    ///
    /// </summary>
    [DataContract]
    public partial class CreditCardTermsConditions : IEquatable<CreditCardTermsConditions>
    {
        /// <summary>
        /// Percentual para pagamento mínimo sobre o saldo devedor da fatura.
        /// </summary>
        /// <value>Percentual para pagamento mínimo sobre o saldo devedor da fatura.</value>
        [Required]
        [DataMember(Name = "minimumFeeRate")]
        public string MinimumFeeRate { get; set; }

        /// <summary>
        /// Campo aberto para detalhamento de taxas de juros
        /// </summary>
        /// <value>Campo aberto para detalhamento de taxas de juros</value>
        [DataMember(Name = "additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Informação sobre as condições e critérios de elegibilidade do emissor do cartão. Pode ser informada a URL referente ao endereço onde constam as condições informadas.
        /// </summary>
        /// <value>Informação sobre as condições e critérios de elegibilidade do emissor do cartão. Pode ser informada a URL referente ao endereço onde constam as condições informadas.</value>
        [Required]
        [DataMember(Name = "elegibilityCriteriaInfo")]
        public string ElegibilityCriteriaInfo { get; set; }

        /// <summary>
        /// Descrição dos procedimentos para encerramento da conta de pagamento pós paga. Pode ser informada a URL referente ao endereço onde constam as condições informadas.
        /// </summary>
        /// <value>Descrição dos procedimentos para encerramento da conta de pagamento pós paga. Pode ser informada a URL referente ao endereço onde constam as condições informadas.</value>
        [Required]
        [DataMember(Name = "closingProcessInfo")]
        public string ClosingProcessInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCardTermsConditions {\n");
            sb.Append("  MinimumFeeRate: ").Append(MinimumFeeRate).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("  ElegibilityCriteriaInfo: ").Append(ElegibilityCriteriaInfo).Append("\n");
            sb.Append("  ClosingProcessInfo: ").Append(ClosingProcessInfo).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreditCardTermsConditions)obj);
        }

        /// <summary>
        /// Returns true if CreditCardTermsConditions instances are equal
        /// </summary>
        /// <param name="other">Instance of CreditCardTermsConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCardTermsConditions other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    MinimumFeeRate == other.MinimumFeeRate ||
                    MinimumFeeRate != null &&
                    MinimumFeeRate.Equals(other.MinimumFeeRate)
                ) &&
                (
                    AdditionalInfo == other.AdditionalInfo ||
                    AdditionalInfo != null &&
                    AdditionalInfo.Equals(other.AdditionalInfo)
                ) &&
                (
                    ElegibilityCriteriaInfo == other.ElegibilityCriteriaInfo ||
                    ElegibilityCriteriaInfo != null &&
                    ElegibilityCriteriaInfo.Equals(other.ElegibilityCriteriaInfo)
                ) &&
                (
                    ClosingProcessInfo == other.ClosingProcessInfo ||
                    ClosingProcessInfo != null &&
                    ClosingProcessInfo.Equals(other.ClosingProcessInfo)
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
                if (MinimumFeeRate != null)
                    hashCode = hashCode * 59 + MinimumFeeRate.GetHashCode();
                if (AdditionalInfo != null)
                    hashCode = hashCode * 59 + AdditionalInfo.GetHashCode();
                if (ElegibilityCriteriaInfo != null)
                    hashCode = hashCode * 59 + ElegibilityCriteriaInfo.GetHashCode();
                if (ClosingProcessInfo != null)
                    hashCode = hashCode * 59 + ClosingProcessInfo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(CreditCardTermsConditions left, CreditCardTermsConditions right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreditCardTermsConditions left, CreditCardTermsConditions right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}