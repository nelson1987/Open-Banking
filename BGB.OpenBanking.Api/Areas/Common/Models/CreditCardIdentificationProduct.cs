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
    public partial class CreditCardIdentificationProduct : IEquatable<CreditCardIdentificationProduct>
    { 
        /// <summary>
        /// Categoria atribuída a um cartão de pagamento, sob uma certa denominação, que lhe agrega um conjunto de vantagens, diferenciando-o de acordo com o perfil do portador. Essa categoria é definida pelo BACEN e está contida no documento de nome 'Elaboração e Remessa de Informações Relativas aos Cartões de Pagamento  Emissores'
        /// </summary>
        /// <value>Categoria atribuída a um cartão de pagamento, sob uma certa denominação, que lhe agrega um conjunto de vantagens, diferenciando-o de acordo com o perfil do portador. Essa categoria é definida pelo BACEN e está contida no documento de nome 'Elaboração e Remessa de Informações Relativas aos Cartões de Pagamento  Emissores'</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum CLASSICNACIONALEnum for CLASSIC_NACIONAL
            /// </summary>
            [EnumMember(Value = "CLASSIC_NACIONAL")]
            CLASSICNACIONALEnum = 0,
            /// <summary>
            /// Enum CLASSICINTERNACIONALEnum for CLASSIC_INTERNACIONAL
            /// </summary>
            [EnumMember(Value = "CLASSIC_INTERNACIONAL")]
            CLASSICINTERNACIONALEnum = 1,
            /// <summary>
            /// Enum GOLDEnum for GOLD
            /// </summary>
            [EnumMember(Value = "GOLD")]
            GOLDEnum = 2,
            /// <summary>
            /// Enum PLATINUMEnum for PLATINUM
            /// </summary>
            [EnumMember(Value = "PLATINUM")]
            PLATINUMEnum = 3,
            /// <summary>
            /// Enum INFINITEEnum for INFINITE
            /// </summary>
            [EnumMember(Value = "INFINITE")]
            INFINITEEnum = 4,
            /// <summary>
            /// Enum ELECTRONEnum for ELECTRON
            /// </summary>
            [EnumMember(Value = "ELECTRON")]
            ELECTRONEnum = 5,
            /// <summary>
            /// Enum STANDARDNACIONALEnum for STANDARD_NACIONAL
            /// </summary>
            [EnumMember(Value = "STANDARD_NACIONAL")]
            STANDARDNACIONALEnum = 6,
            /// <summary>
            /// Enum STANDARDINTERNACIONALEnum for STANDARD_INTERNACIONAL
            /// </summary>
            [EnumMember(Value = "STANDARD_INTERNACIONAL")]
            STANDARDINTERNACIONALEnum = 7,
            /// <summary>
            /// Enum ELETRONICEnum for ELETRONIC
            /// </summary>
            [EnumMember(Value = "ELETRONIC")]
            ELETRONICEnum = 8,
            /// <summary>
            /// Enum BLACKEnum for BLACK
            /// </summary>
            [EnumMember(Value = "BLACK")]
            BLACKEnum = 9,
            /// <summary>
            /// Enum REDESHOPEnum for REDESHOP
            /// </summary>
            [EnumMember(Value = "REDESHOP")]
            REDESHOPEnum = 10,
            /// <summary>
            /// Enum MAESTROMASTERCARDMAESTROEnum for MAESTRO_MASTERCARD_MAESTRO
            /// </summary>
            [EnumMember(Value = "MAESTRO_MASTERCARD_MAESTRO")]
            MAESTROMASTERCARDMAESTROEnum = 11,
            /// <summary>
            /// Enum GREENEnum for GREEN
            /// </summary>
            [EnumMember(Value = "GREEN")]
            GREENEnum = 12,
            /// <summary>
            /// Enum BLUEEnum for BLUE
            /// </summary>
            [EnumMember(Value = "BLUE")]
            BLUEEnum = 13,
            /// <summary>
            /// Enum BLUEBOXEnum for BLUEBOX
            /// </summary>
            [EnumMember(Value = "BLUEBOX")]
            BLUEBOXEnum = 14,
            /// <summary>
            /// Enum PROFISSIONALLIBERALEnum for PROFISSIONAL_LIBERAL
            /// </summary>
            [EnumMember(Value = "PROFISSIONAL_LIBERAL")]
            PROFISSIONALLIBERALEnum = 15,
            /// <summary>
            /// Enum CHEQUEELETRONICOEnum for CHEQUE_ELETRONICO
            /// </summary>
            [EnumMember(Value = "CHEQUE_ELETRONICO")]
            CHEQUEELETRONICOEnum = 16,
            /// <summary>
            /// Enum CORPORATIVOEnum for CORPORATIVO
            /// </summary>
            [EnumMember(Value = "CORPORATIVO")]
            CORPORATIVOEnum = 17,
            /// <summary>
            /// Enum EMPRESARIALEnum for EMPRESARIAL
            /// </summary>
            [EnumMember(Value = "EMPRESARIAL")]
            EMPRESARIALEnum = 18,
            /// <summary>
            /// Enum COMPRASEnum for COMPRAS
            /// </summary>
            [EnumMember(Value = "COMPRAS")]
            COMPRASEnum = 19,
            /// <summary>
            /// Enum OUTROSEnum for OUTROS
            /// </summary>
            [EnumMember(Value = "OUTROS")]
            OUTROSEnum = 20        }

        /// <summary>
        /// Categoria atribuída a um cartão de pagamento, sob uma certa denominação, que lhe agrega um conjunto de vantagens, diferenciando-o de acordo com o perfil do portador. Essa categoria é definida pelo BACEN e está contida no documento de nome &#x27;Elaboração e Remessa de Informações Relativas aos Cartões de Pagamento  Emissores&#x27;
        /// </summary>
        /// <value>Categoria atribuída a um cartão de pagamento, sob uma certa denominação, que lhe agrega um conjunto de vantagens, diferenciando-o de acordo com o perfil do portador. Essa categoria é definida pelo BACEN e está contida no documento de nome &#x27;Elaboração e Remessa de Informações Relativas aos Cartões de Pagamento  Emissores&#x27;</value>
        [Required]
        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Informações complementares se tipo de Cartão &#x27;OUTROS&#x27;. Campo deve ser obrigatoriamente preenchido se selecionado &#x27;OUTROS&#x27;
        /// </summary>
        /// <value>Informações complementares se tipo de Cartão &#x27;OUTROS&#x27;. Campo deve ser obrigatoriamente preenchido se selecionado &#x27;OUTROS&#x27;</value>
        [Required]
        [DataMember(Name="additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCardIdentificationProduct {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreditCardIdentificationProduct)obj);
        }

        /// <summary>
        /// Returns true if CreditCardIdentificationProduct instances are equal
        /// </summary>
        /// <param name="other">Instance of CreditCardIdentificationProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCardIdentificationProduct other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    AdditionalInfo == other.AdditionalInfo ||
                    AdditionalInfo != null &&
                    AdditionalInfo.Equals(other.AdditionalInfo)
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
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (AdditionalInfo != null)
                    hashCode = hashCode * 59 + AdditionalInfo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreditCardIdentificationProduct left, CreditCardIdentificationProduct right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreditCardIdentificationProduct left, CreditCardIdentificationProduct right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}