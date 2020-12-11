/*
 * APIs OpenData do Open Banking Brasil
 *
 * As APIs descritas neste documento são referentes as APIs da fase OpenData do Open Banking Brasil.
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

namespace BGB.OpenBanking.Api.Areas.Products_Services.Models
{
    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public partial class BranchServices : IEquatable<BranchServices>
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NameEnum
        {
            /// <summary>
            /// Enum ABERTURACONTASDEPOSITOSOUPAGAMENTOPREPAGAEnum for ABERTURA_CONTAS_DEPOSITOS_OU_PAGAMENTO_PRE_PAGA
            /// </summary>
            [EnumMember(Value = "ABERTURA_CONTAS_DEPOSITOS_OU_PAGAMENTO_PRE_PAGA")]
            ABERTURACONTASDEPOSITOSOUPAGAMENTOPREPAGAEnum = 0,

            /// <summary>
            /// Enum SAQUEMOEDAEMESPECIEEnum for SAQUE_MOEDA_EM_ESPECIE
            /// </summary>
            [EnumMember(Value = "SAQUE_MOEDA_EM_ESPECIE")]
            SAQUEMOEDAEMESPECIEEnum = 1,

            /// <summary>
            /// Enum RECEBIMENTOSPAGAMENTOSQUALQUERNATUREZAEnum for RECEBIMENTOS_PAGAMENTOS_QUALQUER_NATUREZA
            /// </summary>
            [EnumMember(Value = "RECEBIMENTOS_PAGAMENTOS_QUALQUER_NATUREZA")]
            RECEBIMENTOSPAGAMENTOSQUALQUERNATUREZAEnum = 2,

            /// <summary>
            /// Enum TRANSFERENCIASELETRONICASVISANDOMOVIMENTACAOCONTASDEPOSITOSOUPAGAMENTOTITULARIDADECLIENTESEnum for TRANSFERENCIAS_ELETRONICAS_VISANDO_MOVIMENTACAO_CONTAS_DEPOSITOS_OU_PAGAMENTO_TITULARIDADE_CLIENTES
            /// </summary>
            [EnumMember(Value = "TRANSFERENCIAS_ELETRONICAS_VISANDO_MOVIMENTACAO_CONTAS_DEPOSITOS_OU_PAGAMENTO_TITULARIDADE_CLIENTES")]
            TRANSFERENCIASELETRONICASVISANDOMOVIMENTACAOCONTASDEPOSITOSOUPAGAMENTOTITULARIDADECLIENTESEnum = 3,

            /// <summary>
            /// Enum CONSULTASALDOSEXTRATOSCONTASDEPOSITOSCONTASPAGAMENTOSEnum for CONSULTA_SALDOS_EXTRATOS_CONTAS_DEPOSITOS_CONTAS_PAGAMENTOS
            /// </summary>
            [EnumMember(Value = "CONSULTA_SALDOS_EXTRATOS_CONTAS_DEPOSITOS_CONTAS_PAGAMENTOS")]
            CONSULTASALDOSEXTRATOSCONTASDEPOSITOSCONTASPAGAMENTOSEnum = 4,

            /// <summary>
            /// Enum APLICACOESRESGATESINVESTIMENTOSEnum for APLICACOES_RESGATES_INVESTIMENTOS
            /// </summary>
            [EnumMember(Value = "APLICACOES_RESGATES_INVESTIMENTOS")]
            APLICACOESRESGATESINVESTIMENTOSEnum = 5,

            /// <summary>
            /// Enum EXECUCAOATIVAPASSIVAORDENSPAGAMENTOSOLICITACAOCLIENTESUSUARIOSEnum for EXECUCAO_ATIVA_PASSIVA_ORDENS_PAGAMENTO_SOLICITACAO_CLIENTES_USUARIOS
            /// </summary>
            [EnumMember(Value = "EXECUCAO_ATIVA_PASSIVA_ORDENS_PAGAMENTO_SOLICITACAO_CLIENTES_USUARIOS")]
            EXECUCAOATIVAPASSIVAORDENSPAGAMENTOSOLICITACAOCLIENTESUSUARIOSEnum = 6,

            /// <summary>
            /// Enum DEPOSITOSMOEDAESPECIECHEQUEEnum for DEPOSITOS_MOEDA_ESPECIE_CHEQUE
            /// </summary>
            [EnumMember(Value = "DEPOSITOS_MOEDA_ESPECIE_CHEQUE")]
            DEPOSITOSMOEDAESPECIECHEQUEEnum = 7,

            /// <summary>
            /// Enum OPERACOESCREDITOBEMCOMOOUTROSSERVICOSPRESTADOSACOMPANHAMENTOOPERACAOEnum for OPERACOES_CREDITO_BEM_COMO_OUTROS_SERVICOS_PRESTADOS_ACOMPANHAMENTO_OPERACAO
            /// </summary>
            [EnumMember(Value = "OPERACOES_CREDITO_BEM_COMO_OUTROS_SERVICOS_PRESTADOS_ACOMPANHAMENTO_OPERACAO")]
            OPERACOESCREDITOBEMCOMOOUTROSSERVICOSPRESTADOSACOMPANHAMENTOOPERACAOEnum = 8,

            /// <summary>
            /// Enum CARTAOCREDITOEnum for CARTAO_CREDITO
            /// </summary>
            [EnumMember(Value = "CARTAO_CREDITO")]
            CARTAOCREDITOEnum = 9,

            /// <summary>
            /// Enum SEGUROSEnum for SEGUROS
            /// </summary>
            [EnumMember(Value = "SEGUROS")]
            SEGUROSEnum = 10,

            /// <summary>
            /// Enum OPERACOESARRENDAMENTOMERCANTILEnum for OPERACOES_ARRENDAMENTO_MERCANTIL
            /// </summary>
            [EnumMember(Value = "OPERACOES_ARRENDAMENTO_MERCANTIL")]
            OPERACOESARRENDAMENTOMERCANTILEnum = 11,

            /// <summary>
            /// Enum ABERTURACONTAPAGAMENTOPOSPAGAEnum for ABERTURA_CONTA_PAGAMENTO_POS_PAGA
            /// </summary>
            [EnumMember(Value = "ABERTURA_CONTA_PAGAMENTO_POS_PAGA")]
            ABERTURACONTAPAGAMENTOPOSPAGAEnum = 12,

            /// <summary>
            /// Enum COMPRAVENDAMOEDAESTRANGEIRAESPECIEEnum for COMPRA_VENDA_MOEDA_ESTRANGEIRA_ESPECIE
            /// </summary>
            [EnumMember(Value = "COMPRA_VENDA_MOEDA_ESTRANGEIRA_ESPECIE")]
            COMPRAVENDAMOEDAESTRANGEIRAESPECIEEnum = 13,

            /// <summary>
            /// Enum COMPRAVENDACHEQUECHEQUEVIAGEMBEMCOMOCARGAMOEDAESTRANGEIRACARTAOPREPAGOEnum for COMPRA_VENDA_CHEQUE_CHEQUE_VIAGEM_BEM_COMO_CARGA_MOEDA_ESTRANGEIRA_CARTAO_PRE_PAGO
            /// </summary>
            [EnumMember(Value = "COMPRA_VENDA_CHEQUE_CHEQUE_VIAGEM_BEM_COMO_CARGA_MOEDA_ESTRANGEIRA_CARTAO_PRE_PAGO")]
            COMPRAVENDACHEQUECHEQUEVIAGEMBEMCOMOCARGAMOEDAESTRANGEIRACARTAOPREPAGOEnum = 14,

            /// <summary>
            /// Enum COMPRAVENDAOUROEnum for COMPRA_VENDA_OURO
            /// </summary>
            [EnumMember(Value = "COMPRA_VENDA_OURO")]
            COMPRAVENDAOUROEnum = 15,

            /// <summary>
            /// Enum OUTROSPRODUTOSSERVICOSEnum for OUTROS_PRODUTOS_SERVICOS
            /// </summary>
            [EnumMember(Value = "OUTROS_PRODUTOS_SERVICOS")]
            OUTROSPRODUTOSSERVICOSEnum = 16,

            /// <summary>
            /// Enum CANCELAMENTOEnum for CANCELAMENTO
            /// </summary>
            [EnumMember(Value = "CANCELAMENTO")]
            CANCELAMENTOEnum = 17,

            /// <summary>
            /// Enum INFORMACOESEnum for INFORMACOES
            /// </summary>
            [EnumMember(Value = "INFORMACOES")]
            INFORMACOESEnum = 18,

            /// <summary>
            /// Enum RECLAMACOESEnum for RECLAMACOES
            /// </summary>
            [EnumMember(Value = "RECLAMACOES")]
            RECLAMACOESEnum = 19
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name = "name")]
        public NameEnum? Name { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum ABRECONTADEPOSITOOUPREPAGAEnum for ABRE_CONTA_DEPOSITO_OU_PRE_PAGA
            /// </summary>
            [EnumMember(Value = "ABRE_CONTA_DEPOSITO_OU_PRE_PAGA")]
            ABRECONTADEPOSITOOUPREPAGAEnum = 0,

            /// <summary>
            /// Enum SAQUEMOEDAESPECIEEnum for SAQUE_MOEDA_ESPECIE
            /// </summary>
            [EnumMember(Value = "SAQUE_MOEDA_ESPECIE")]
            SAQUEMOEDAESPECIEEnum = 1,

            /// <summary>
            /// Enum RECEBEPAGAQUALQUERNATUREZAEnum for RECEBE_PAGA_QUALQUER_NATUREZA
            /// </summary>
            [EnumMember(Value = "RECEBE_PAGA_QUALQUER_NATUREZA")]
            RECEBEPAGAQUALQUERNATUREZAEnum = 2,

            /// <summary>
            /// Enum TRANSFERENCIASELETRONICASMOVIMENTACONTASDEPOSITOSOUPAGTOTITULARESCLIENTESEnum for TRANSFERENCIAS_ELETRONICAS_MOVIMENTA_CONTAS_DEPOSITOS_OU_PAGTO_TITULARES_CLIENTES
            /// </summary>
            [EnumMember(Value = "TRANSFERENCIAS_ELETRONICAS_MOVIMENTA_CONTAS_DEPOSITOS_OU_PAGTO_TITULARES_CLIENTES")]
            TRANSFERENCIASELETRONICASMOVIMENTACONTASDEPOSITOSOUPAGTOTITULARESCLIENTESEnum = 3,

            /// <summary>
            /// Enum CONSULTASALDOSEXTRATOSCONTASDEPOSITOSPAGTOSEnum for CONSULTA_SALDOS_EXTRATOS_CONTAS_DEPOSITOS_PAGTOS
            /// </summary>
            [EnumMember(Value = "CONSULTA_SALDOS_EXTRATOS_CONTAS_DEPOSITOS_PAGTOS")]
            CONSULTASALDOSEXTRATOSCONTASDEPOSITOSPAGTOSEnum = 4,

            /// <summary>
            /// Enum APLICARESGATAINVESTIMENTOSEnum for APLICA_RESGATA_INVESTIMENTOS
            /// </summary>
            [EnumMember(Value = "APLICA_RESGATA_INVESTIMENTOS")]
            APLICARESGATAINVESTIMENTOSEnum = 5,

            /// <summary>
            /// Enum EXECUCAOATIVAPASSIVAORDENSPAGTOEnum for EXECUCAO_ATIVA_PASSIVA_ORDENS_PAGTO
            /// </summary>
            [EnumMember(Value = "EXECUCAO_ATIVA_PASSIVA_ORDENS_PAGTO")]
            EXECUCAOATIVAPASSIVAORDENSPAGTOEnum = 6,

            /// <summary>
            /// Enum DEPOSITOMOEDAESPECIECHEQUEEnum for DEPOSITO_MOEDA_ESPECIE_CHEQUE
            /// </summary>
            [EnumMember(Value = "DEPOSITO_MOEDA_ESPECIE_CHEQUE")]
            DEPOSITOMOEDAESPECIECHEQUEEnum = 7,

            /// <summary>
            /// Enum OPERACREDITOOUTROSSERVICOSACOMPANHAOPERACAOEnum for OPERA_CREDITO_OUTROS_SERVICOS_ACOMPANHA_OPERACAO
            /// </summary>
            [EnumMember(Value = "OPERA_CREDITO_OUTROS_SERVICOS_ACOMPANHA_OPERACAO")]
            OPERACREDITOOUTROSSERVICOSACOMPANHAOPERACAOEnum = 8,

            /// <summary>
            /// Enum CARTAOCREDITOEnum for CARTAO_CREDITO
            /// </summary>
            [EnumMember(Value = "CARTAO_CREDITO")]
            CARTAOCREDITOEnum = 9,

            /// <summary>
            /// Enum SEGUROSEnum for SEGUROS
            /// </summary>
            [EnumMember(Value = "SEGUROS")]
            SEGUROSEnum = 10,

            /// <summary>
            /// Enum OPERAARRENDAMENTOMERCANTILEnum for OPERA_ARRENDAMENTO_MERCANTIL
            /// </summary>
            [EnumMember(Value = "OPERA_ARRENDAMENTO_MERCANTIL")]
            OPERAARRENDAMENTOMERCANTILEnum = 11,

            /// <summary>
            /// Enum ABERTURACONTAPAGAMENTOPOSPAGAEnum for ABERTURA_CONTA_PAGAMENTO_POS_PAGA
            /// </summary>
            [EnumMember(Value = "ABERTURA_CONTA_PAGAMENTO_POS_PAGA")]
            ABERTURACONTAPAGAMENTOPOSPAGAEnum = 12,

            /// <summary>
            /// Enum COMPRAVENDAMOEDAESTRANGEIRAESPECIEEnum for COMPRA_VENDA_MOEDA_ESTRANGEIRA_ESPECIE
            /// </summary>
            [EnumMember(Value = "COMPRA_VENDA_MOEDA_ESTRANGEIRA_ESPECIE")]
            COMPRAVENDAMOEDAESTRANGEIRAESPECIEEnum = 13,

            /// <summary>
            /// Enum COMPRAVENDACHEQUECHEQUEVIAGEMCARGAMOEDAESTRANGEIRACARTAOPREPAGOEnum for COMPRA_VENDA_CHEQUE_CHEQUE_VIAGEM_CARGA_MOEDA_ESTRANGEIRA_CARTAO_PRE_PAGO
            /// </summary>
            [EnumMember(Value = "COMPRA_VENDA_CHEQUE_CHEQUE_VIAGEM_CARGA_MOEDA_ESTRANGEIRA_CARTAO_PRE_PAGO")]
            COMPRAVENDACHEQUECHEQUEVIAGEMCARGAMOEDAESTRANGEIRACARTAOPREPAGOEnum = 14,

            /// <summary>
            /// Enum COMPRAVENDAOUROEnum for COMPRA_VENDA_OURO
            /// </summary>
            [EnumMember(Value = "COMPRA_VENDA_OURO")]
            COMPRAVENDAOUROEnum = 15,

            /// <summary>
            /// Enum OUTROSPRODUTOSSERVICOSEnum for OUTROS_PRODUTOS_SERVICOS
            /// </summary>
            [EnumMember(Value = "OUTROS_PRODUTOS_SERVICOS")]
            OUTROSPRODUTOSSERVICOSEnum = 16,

            /// <summary>
            /// Enum CANCELAMENTOEnum for CANCELAMENTO
            /// </summary>
            [EnumMember(Value = "CANCELAMENTO")]
            CANCELAMENTOEnum = 17,

            /// <summary>
            /// Enum INFORMACOESEnum for INFORMACOES
            /// </summary>
            [EnumMember(Value = "INFORMACOES")]
            INFORMACOESEnum = 18,

            /// <summary>
            /// Enum RECLAMACOESEnum for RECLAMACOES
            /// </summary>
            [EnumMember(Value = "RECLAMACOES")]
            RECLAMACOESEnum = 19
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [Required]
        [DataMember(Name = "code")]
        public CodeEnum? Code { get; set; }

        /// <summary>
        /// Texto livre para complementar informação relativa ao Serviço disponível, quando for selecionada a opção p preenchida a opção &#x27;OUTROS_PRODUTOS_SERVICOS&#x27;
        /// </summary>
        /// <value>Texto livre para complementar informação relativa ao Serviço disponível, quando for selecionada a opção p preenchida a opção &#x27;OUTROS_PRODUTOS_SERVICOS&#x27;</value>
        [DataMember(Name = "additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BranchServices {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BranchServices)obj);
        }

        /// <summary>
        /// Returns true if BranchServices instances are equal
        /// </summary>
        /// <param name="other">Instance of BranchServices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BranchServices other)
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                if (AdditionalInfo != null)
                    hashCode = hashCode * 59 + AdditionalInfo.GetHashCode();
                return hashCode;
            }
        }

        #region Operators

#pragma warning disable 1591

        public static bool operator ==(BranchServices left, BranchServices right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BranchServices left, BranchServices right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591

        #endregion Operators
    }
}