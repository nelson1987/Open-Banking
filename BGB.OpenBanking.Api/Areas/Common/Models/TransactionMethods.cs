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
        /// Lista de formas de movimentação possíveis para a conta
        /// </summary>
        /// <value>Lista de formas de movimentação possíveis para a conta</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TransactionMethods
        {
            /// <summary>
            /// Enum ELETRONICAEnum for MOVIMENTACAO_ELETRONICA
            /// </summary>
            [EnumMember(Value = "MOVIMENTACAO_ELETRONICA")]
            ELETRONICAEnum = 0,
            /// <summary>
            /// Enum CHEQUEEnum for MOVIMENTACAO_CHEQUE
            /// </summary>
            [EnumMember(Value = "MOVIMENTACAO_CHEQUE")]
            CHEQUEEnum = 1,
            /// <summary>
            /// Enum CARTAOEnum for MOVIMENTACAO_CARTAO
            /// </summary>
            [EnumMember(Value = "MOVIMENTACAO_CARTAO")]
            CARTAOEnum = 2,
            /// <summary>
            /// Enum PRESENCIALEnum for MOVIMENTACAO_PRESENCIAL
            /// </summary>
            [EnumMember(Value = "MOVIMENTACAO_PRESENCIAL")]
            PRESENCIALEnum = 3        }
}