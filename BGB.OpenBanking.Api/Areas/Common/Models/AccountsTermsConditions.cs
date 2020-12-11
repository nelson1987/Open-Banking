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
    /// Objeto que reúne informações relativas a Termos e Condições para as modalidades tratadas
    /// </summary>
    [DataContract]
    public partial class AccountsTermsConditions : IEquatable<AccountsTermsConditions>
    { 
        /// <summary>
        /// Gets or Sets MinimumBalance
        /// </summary>
        [Required]
        [DataMember(Name="minimumBalance")]
        public MinimumBalance MinimumBalance { get; set; }

        /// <summary>
        /// Critérios de qualificação do cliente com a finalidade de definir sua elegibilidade para a aquisição do tipo de conta. Campo Aberto
        /// </summary>
        /// <value>Critérios de qualificação do cliente com a finalidade de definir sua elegibilidade para a aquisição do tipo de conta. Campo Aberto</value>
        [Required]
        [DataMember(Name="elegibilityCriteriaInfo")]
        public string ElegibilityCriteriaInfo { get; set; }

        /// <summary>
        /// Procedimentos de encerramento para o tipo de conta tratado. Possibilidade de inscrição da URL. Endereço eletrônico de acesso ao canal. p.ex. &#x27;https://example.com/mobile-banking&#x27; 
        /// </summary>
        /// <value>Procedimentos de encerramento para o tipo de conta tratado. Possibilidade de inscrição da URL. Endereço eletrônico de acesso ao canal. p.ex. &#x27;https://example.com/mobile-banking&#x27; </value>
        [Required]
        [DataMember(Name="closingProcessInfo")]
        public string ClosingProcessInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountsTermsConditions {\n");
            sb.Append("  MinimumBalance: ").Append(MinimumBalance).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AccountsTermsConditions)obj);
        }

        /// <summary>
        /// Returns true if AccountsTermsConditions instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountsTermsConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountsTermsConditions other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MinimumBalance == other.MinimumBalance ||
                    MinimumBalance != null &&
                    MinimumBalance.Equals(other.MinimumBalance)
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
                    if (MinimumBalance != null)
                    hashCode = hashCode * 59 + MinimumBalance.GetHashCode();
                    if (ElegibilityCriteriaInfo != null)
                    hashCode = hashCode * 59 + ElegibilityCriteriaInfo.GetHashCode();
                    if (ClosingProcessInfo != null)
                    hashCode = hashCode * 59 + ClosingProcessInfo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AccountsTermsConditions left, AccountsTermsConditions right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccountsTermsConditions left, AccountsTermsConditions right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}