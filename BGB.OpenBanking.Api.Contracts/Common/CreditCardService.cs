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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace BGB.OpenBanking.Api.Contracts.Common
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class CreditCardService : IEquatable<CreditCardService>
    {
        /// <summary>
        /// Denominação de Serviços relacionados à Modalidade de Contas de Pagamento Pós-Pagas (Vide ENUM)
        /// </summary>
        /// <value>Denominação de Serviços relacionados à Modalidade de Contas de Pagamento Pós-Pagas (Vide ENUM)</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Enum ANUIDADECARTAOBASICONACIONALEnum for ANUIDADE_CARTAO_BASICO_NACIONAL
            /// </summary>
            [EnumMember(Value = "ANUIDADE_CARTAO_BASICO_NACIONAL")]
            ANUIDADECARTAOBASICONACIONALEnum = 0,

            /// <summary>
            /// Enum ANUIDADECARTAOBASICOINTERNACIONALEnum for ANUIDADE_CARTAO_BASICO_INTERNACIONAL
            /// </summary>
            [EnumMember(Value = "ANUIDADE_CARTAO_BASICO_INTERNACIONAL")]
            ANUIDADECARTAOBASICOINTERNACIONALEnum = 1,

            /// <summary>
            /// Enum UTILIZACAOCANAISATENDIMENTORETIRADAESPECIEBRASILEnum for UTILIZACAO_CANAIS_ATENDIMENTO_RETIRADA_ESPECIE_BRASIL
            /// </summary>
            [EnumMember(Value = "UTILIZACAO_CANAIS_ATENDIMENTO_RETIRADA_ESPECIE_BRASIL")]
            UTILIZACAOCANAISATENDIMENTORETIRADAESPECIEBRASILEnum = 2,

            /// <summary>
            /// Enum UTILIZACAOCANAISATENDIMENTORETIRADAESPECIEEXTERIOREnum for UTILIZACAO_CANAIS_ATENDIMENTO_RETIRADA_ESPECIE_EXTERIOR
            /// </summary>
            [EnumMember(Value = "UTILIZACAO_CANAIS_ATENDIMENTO_RETIRADA_ESPECIE_EXTERIOR")]
            UTILIZACAOCANAISATENDIMENTORETIRADAESPECIEEXTERIOREnum = 3,

            /// <summary>
            /// Enum AVALIACAOEMERGENCIALCREDITOEnum for AVALIACAO_EMERGENCIAL_CREDITO
            /// </summary>
            [EnumMember(Value = "AVALIACAO_EMERGENCIAL_CREDITO")]
            AVALIACAOEMERGENCIALCREDITOEnum = 4,

            /// <summary>
            /// Enum FORNECIMENTOSEGUNDAVIAFUNCAOCREDITOEnum for FORNECIMENTO_SEGUNDA_VIA_FUNCAO_CREDITO
            /// </summary>
            [EnumMember(Value = "FORNECIMENTO_SEGUNDA_VIA_FUNCAO_CREDITO")]
            FORNECIMENTOSEGUNDAVIAFUNCAOCREDITOEnum = 5,

            /// <summary>
            /// Enum PAGAMENTOCONTASUTILIZANDOFUNCAOCREDITOEnum for PAGAMENTO_CONTAS_UTILIZANDO_FUNCAO_CREDITO
            /// </summary>
            [EnumMember(Value = "PAGAMENTO_CONTAS_UTILIZANDO_FUNCAO_CREDITO")]
            PAGAMENTOCONTASUTILIZANDOFUNCAOCREDITOEnum = 6,

            /// <summary>
            /// Enum SMSEnum for SMS
            /// </summary>
            [EnumMember(Value = "SMS")]
            SMSEnum = 7
        }

        /// <summary>
        /// Denominação de Serviços relacionados à Modalidade de Contas de Pagamento Pós-Pagas (Vide ENUM)
        /// </summary>
        /// <value>Denominação de Serviços relacionados à Modalidade de Contas de Pagamento Pós-Pagas (Vide ENUM)</value>
        [Required]
        [DataMember(Name = "name")]
        public NameEnum? Name { get; set; }

        /// <summary>
        /// Sigla de identificação do Serviço relacionado à Modalidade de Contas de Pagamento Pós-Pagas (Vide ENUM)
        /// </summary>
        /// <value>Sigla de identificação do Serviço relacionado à Modalidade de Contas de Pagamento Pós-Pagas (Vide ENUM)</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum ANUIDADENACIONALEnum for ANUIDADE_NACIONAL
            /// </summary>
            [EnumMember(Value = "ANUIDADE_NACIONAL")]
            ANUIDADENACIONALEnum = 0,

            /// <summary>
            /// Enum ANUIDADEINTERNACIONALEnum for ANUIDADE_INTERNACIONAL
            /// </summary>
            [EnumMember(Value = "ANUIDADE_INTERNACIONAL")]
            ANUIDADEINTERNACIONALEnum = 1,

            /// <summary>
            /// Enum SAQUECARTAOBRASILEnum for SAQUE_CARTAO_BRASIL
            /// </summary>
            [EnumMember(Value = "SAQUE_CARTAO_BRASIL")]
            SAQUECARTAOBRASILEnum = 2,

            /// <summary>
            /// Enum SAQUECARTAOEXTERIOREnum for SAQUE_CARTAO_EXTERIOR
            /// </summary>
            [EnumMember(Value = "SAQUE_CARTAO_EXTERIOR")]
            SAQUECARTAOEXTERIOREnum = 3,

            /// <summary>
            /// Enum AVALIACAOEMERGENCIALCREDITOEnum for AVALIACAO_EMERGENCIAL_CREDITO
            /// </summary>
            [EnumMember(Value = "AVALIACAO_EMERGENCIAL_CREDITO")]
            AVALIACAOEMERGENCIALCREDITOEnum = 4,

            /// <summary>
            /// Enum EMISSAOSEGUNDAVIAEnum for EMISSAO_SEGUNDA_VIA
            /// </summary>
            [EnumMember(Value = "EMISSAO_SEGUNDA_VIA")]
            EMISSAOSEGUNDAVIAEnum = 5,

            /// <summary>
            /// Enum TARIFAPAGAMENTOCONTASEnum for TARIFA_PAGAMENTO_CONTAS
            /// </summary>
            [EnumMember(Value = "TARIFA_PAGAMENTO_CONTAS")]
            TARIFAPAGAMENTOCONTASEnum = 6,

            /// <summary>
            /// Enum SMSEnum for SMS
            /// </summary>
            [EnumMember(Value = "SMS")]
            SMSEnum = 7
        }

        /// <summary>
        /// Sigla de identificação do Serviço relacionado à Modalidade de Contas de Pagamento Pós-Pagas (Vide ENUM)
        /// </summary>
        /// <value>Sigla de identificação do Serviço relacionado à Modalidade de Contas de Pagamento Pós-Pagas (Vide ENUM)</value>
        [Required]
        [DataMember(Name = "code")]
        public CodeEnum? Code { get; set; }

        /// <summary>
        /// Fatos geradores de cobrança que incidem sobre as Modalidades de Contas de Pagamento Pós-Pagas informada, para pessoa jurídica. (Campo Livre)
        /// </summary>
        /// <value>Fatos geradores de cobrança que incidem sobre as Modalidades de Contas de Pagamento Pós-Pagas informada, para pessoa jurídica. (Campo Livre)</value>
        [Required]
        [DataMember(Name = "chargingTriggerInfo")]
        public string ChargingTriggerInfo { get; set; }

        /// <summary>
        /// Lista distribuição preços tarifas de serviços
        /// </summary>
        /// <value>Lista distribuição preços tarifas de serviços</value>
        [Required]
        [DataMember(Name = "prices")]
        public List<Price> Prices { get; set; }

        /// <summary>
        /// Gets or Sets Minimum
        /// </summary>
        [Required]
        [DataMember(Name = "minimum")]
        public MinimumPrice Minimum { get; set; }

        /// <summary>
        /// Gets or Sets Maximum
        /// </summary>
        [Required]
        [DataMember(Name = "maximum")]
        public MaximumPrice Maximum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCardService {\n");
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
            return obj.GetType() == GetType() && Equals((CreditCardService)obj);
        }

        /// <summary>
        /// Returns true if CreditCardService instances are equal
        /// </summary>
        /// <param name="other">Instance of CreditCardService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCardService other)
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

        public static bool operator ==(CreditCardService left, CreditCardService right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreditCardService left, CreditCardService right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}