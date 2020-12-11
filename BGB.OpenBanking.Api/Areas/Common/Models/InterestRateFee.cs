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
    public partial class InterestRateFee : IEquatable<InterestRateFee>
    { 
        /// <summary>
        /// Tipos de taxas referenciais ou indexadores, conforme Anexo 5: Taxa referencial ou Indexador (Indx), do Documento 3040
        /// </summary>
        /// <value>Tipos de taxas referenciais ou indexadores, conforme Anexo 5: Taxa referencial ou Indexador (Indx), do Documento 3040</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ReferentialRateIndexerEnum
        {
            /// <summary>
            /// Enum SEMINDEXADORTAXAEnum for SEM_INDEXADOR_TAXA
            /// </summary>
            [EnumMember(Value = "SEM_INDEXADOR_TAXA")]
            SEMINDEXADORTAXAEnum = 0,
            /// <summary>
            /// Enum PREFIXADOEnum for PRE_FIXADO
            /// </summary>
            [EnumMember(Value = "PRE_FIXADO")]
            PREFIXADOEnum = 1,
            /// <summary>
            /// Enum POSFIXADOTRTBFEnum for POS_FIXADO_TR_TBF
            /// </summary>
            [EnumMember(Value = "POS_FIXADO_TR_TBF")]
            POSFIXADOTRTBFEnum = 2,
            /// <summary>
            /// Enum POSFIXADOTJLPEnum for POS_FIXADO_TJLP
            /// </summary>
            [EnumMember(Value = "POS_FIXADO_TJLP")]
            POSFIXADOTJLPEnum = 3,
            /// <summary>
            /// Enum POSFIXADOLIBOREnum for POS_FIXADO_LIBOR
            /// </summary>
            [EnumMember(Value = "POS_FIXADO_LIBOR")]
            POSFIXADOLIBOREnum = 4,
            /// <summary>
            /// Enum POSFIXADOTLPEnum for POS_FIXADO_TLP
            /// </summary>
            [EnumMember(Value = "POS_FIXADO_TLP")]
            POSFIXADOTLPEnum = 5,
            /// <summary>
            /// Enum OUTRASTAXASPOSFIXADASEnum for OUTRAS_TAXAS_POS_FIXADAS
            /// </summary>
            [EnumMember(Value = "OUTRAS_TAXAS_POS_FIXADAS")]
            OUTRASTAXASPOSFIXADASEnum = 6,
            /// <summary>
            /// Enum FLUTUANTESCDIEnum for FLUTUANTES_CDI
            /// </summary>
            [EnumMember(Value = "FLUTUANTES_CDI")]
            FLUTUANTESCDIEnum = 7,
            /// <summary>
            /// Enum FLUTUANTESSELICEnum for FLUTUANTES_SELIC
            /// </summary>
            [EnumMember(Value = "FLUTUANTES_SELIC")]
            FLUTUANTESSELICEnum = 8,
            /// <summary>
            /// Enum OUTRASTAXASFLUTUANTESEnum for OUTRAS_TAXAS_FLUTUANTES
            /// </summary>
            [EnumMember(Value = "OUTRAS_TAXAS_FLUTUANTES")]
            OUTRASTAXASFLUTUANTESEnum = 9,
            /// <summary>
            /// Enum INDICESPRECOSIGPMEnum for INDICES_PRECOS_IGPM
            /// </summary>
            [EnumMember(Value = "INDICES_PRECOS_IGPM")]
            INDICESPRECOSIGPMEnum = 10,
            /// <summary>
            /// Enum INDICESPRECOSIPCAEnum for INDICES_PRECOS_IPCA
            /// </summary>
            [EnumMember(Value = "INDICES_PRECOS_IPCA")]
            INDICESPRECOSIPCAEnum = 11,
            /// <summary>
            /// Enum INDICESPRECOSIPCCEnum for INDICES_PRECOS_IPCC
            /// </summary>
            [EnumMember(Value = "INDICES_PRECOS_IPCC")]
            INDICESPRECOSIPCCEnum = 12,
            /// <summary>
            /// Enum OUTROSINDICESPRECOEnum for OUTROS_INDICES_PRECO
            /// </summary>
            [EnumMember(Value = "OUTROS_INDICES_PRECO")]
            OUTROSINDICESPRECOEnum = 13,
            /// <summary>
            /// Enum CREDITORURALTCRPREEnum for CREDITO_RURAL_TCR_PRE
            /// </summary>
            [EnumMember(Value = "CREDITO_RURAL_TCR_PRE")]
            CREDITORURALTCRPREEnum = 14,
            /// <summary>
            /// Enum CREDITORURALTCRPOSEnum for CREDITO_RURAL_TCR_POS
            /// </summary>
            [EnumMember(Value = "CREDITO_RURAL_TCR_POS")]
            CREDITORURALTCRPOSEnum = 15,
            /// <summary>
            /// Enum CREDITORURALTRFCPREEnum for CREDITO_RURAL_TRFC_PRE
            /// </summary>
            [EnumMember(Value = "CREDITO_RURAL_TRFC_PRE")]
            CREDITORURALTRFCPREEnum = 16,
            /// <summary>
            /// Enum CREDITORURALTRFCPOSEnum for CREDITO_RURAL_TRFC_POS
            /// </summary>
            [EnumMember(Value = "CREDITO_RURAL_TRFC_POS")]
            CREDITORURALTRFCPOSEnum = 17,
            /// <summary>
            /// Enum OUTROSINDEXADORESEnum for OUTROS_INDEXADORES
            /// </summary>
            [EnumMember(Value = "OUTROS_INDEXADORES")]
            OUTROSINDEXADORESEnum = 18        }

        /// <summary>
        /// Tipos de taxas referenciais ou indexadores, conforme Anexo 5: Taxa referencial ou Indexador (Indx), do Documento 3040
        /// </summary>
        /// <value>Tipos de taxas referenciais ou indexadores, conforme Anexo 5: Taxa referencial ou Indexador (Indx), do Documento 3040</value>
        [Required]
        [DataMember(Name="referentialRateIndexer")]
        public ReferentialRateIndexerEnum? ReferentialRateIndexer { get; set; }

        /// <summary>
        /// Percentual que incide sobre a composição das taxas de juros remuneratórios. (representa uma porcentagem Ex: 0.15 (O valor ao lado representa 15%. O valor &#x27;1 &#x27;representa 100%) A apuração pode acontecer com até 4 casas decimais. O preenchimento deve respeitar as 4 casas decimais, mesmo que venham preenchidas com zeros (representação de porcentagem p.ex: 0.1500. Este valor representa 15%. O valor 1 representa 100%) 
        /// </summary>
        /// <value>Percentual que incide sobre a composição das taxas de juros remuneratórios. (representa uma porcentagem Ex: 0.15 (O valor ao lado representa 15%. O valor &#x27;1 &#x27;representa 100%) A apuração pode acontecer com até 4 casas decimais. O preenchimento deve respeitar as 4 casas decimais, mesmo que venham preenchidas com zeros (representação de porcentagem p.ex: 0.1500. Este valor representa 15%. O valor 1 representa 100%) </value>
        [Required]
        [DataMember(Name="rate")]
        public string Rate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InterestRateFee {\n");
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
            return obj.GetType() == GetType() && Equals((InterestRateFee)obj);
        }

        /// <summary>
        /// Returns true if InterestRateFee instances are equal
        /// </summary>
        /// <param name="other">Instance of InterestRateFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterestRateFee other)
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

        public static bool operator ==(InterestRateFee left, InterestRateFee right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InterestRateFee left, InterestRateFee right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}