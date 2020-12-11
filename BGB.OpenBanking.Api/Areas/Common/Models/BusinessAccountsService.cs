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
    public partial class BusinessAccountsService : IEquatable<BusinessAccountsService>
    { 
        /// <summary>
        /// Nome do Serviço que incide sobre tipo de conta selecionado para pessoa jurídica(Campo Livre)
        /// </summary>
        /// <value>Nome do Serviço que incide sobre tipo de conta selecionado para pessoa jurídica(Campo Livre)</value>
        [Required]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Sigla de identificação de Outros Serviços que incidem sobre os tipos de contas informados.
        /// </summary>
        /// <value>Sigla de identificação de Outros Serviços que incidem sobre os tipos de contas informados.</value>
        [Required]
        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Fatos geradores de cobrança que incidem sobre serviço que compõe o Pacote de Serviços.
        /// </summary>
        /// <value>Fatos geradores de cobrança que incidem sobre serviço que compõe o Pacote de Serviços.</value>
        [Required]
        [DataMember(Name="chargingTriggerInfo")]
        public string ChargingTriggerInfo { get; set; }

        /// <summary>
        /// Lista distribuição preços tarifas de serviços
        /// </summary>
        /// <value>Lista distribuição preços tarifas de serviços</value>
        [Required]
        [DataMember(Name="prices")]
        public List<Price> Prices { get; set; }

        /// <summary>
        /// Gets or Sets Minimum
        /// </summary>
        [Required]
        [DataMember(Name="minimum")]
        public MinimumPrice Minimum { get; set; }

        /// <summary>
        /// Gets or Sets Maximum
        /// </summary>
        [Required]
        [DataMember(Name="maximum")]
        public MaximumPrice Maximum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessAccountsService {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ChargingTriggerInfo: ").Append(ChargingTriggerInfo).Append("\n");
            sb.Append("  Prices: ").Append(Prices).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BusinessAccountsService)obj);
        }

        /// <summary>
        /// Returns true if BusinessAccountsService instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessAccountsService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessAccountsService other)
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
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                ) && 
                (
                    ChargingTriggerInfo == other.ChargingTriggerInfo ||
                    ChargingTriggerInfo != null &&
                    ChargingTriggerInfo.Equals(other.ChargingTriggerInfo)
                ) && 
                (
                    Prices == other.Prices ||
                    Prices != null &&
                    Prices.SequenceEqual(other.Prices)
                ) && 
                (
                    Minimum == other.Minimum ||
                    Minimum != null &&
                    Minimum.Equals(other.Minimum)
                ) && 
                (
                    Maximum == other.Maximum ||
                    Maximum != null &&
                    Maximum.Equals(other.Maximum)
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
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (ChargingTriggerInfo != null)
                    hashCode = hashCode * 59 + ChargingTriggerInfo.GetHashCode();
                    if (Prices != null)
                    hashCode = hashCode * 59 + Prices.GetHashCode();
                    if (Minimum != null)
                    hashCode = hashCode * 59 + Minimum.GetHashCode();
                    if (Maximum != null)
                    hashCode = hashCode * 59 + Maximum.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BusinessAccountsService left, BusinessAccountsService right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BusinessAccountsService left, BusinessAccountsService right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
