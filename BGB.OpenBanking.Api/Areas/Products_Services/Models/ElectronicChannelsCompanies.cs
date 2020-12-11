/*
 * APIs OpenData do Open Banking Brasil
 *
 * As APIs descritas neste documento são referentes as APIs da fase OpenData do Open Banking Brasil.
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

namespace BGB.OpenBanking.Api.Areas.Products_Services.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ElectronicChannelsCompanies : CNPJ, IEquatable<ElectronicChannelsCompanies>
    { 
        /// <summary>
        /// Nome da marca selecionada pela Organização proprietária da dependência (titular).
        /// </summary>
        /// <value>Nome da marca selecionada pela Organização proprietária da dependência (titular).</value>
        [Required]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets UrlComplementaryList
        /// </summary>
        [DataMember(Name="urlComplementaryList")]
        public string UrlComplementaryList { get; set; }

        /// <summary>
        /// Lista  de canais de atendimento eltrônico
        /// </summary>
        /// <value>Lista  de canais de atendimento eltrônico</value>
        [Required]
        [DataMember(Name="electronicChannels")]
        public List<ElectronicChannel> ElectronicChannels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElectronicChannelsCompanies {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UrlComplementaryList: ").Append(UrlComplementaryList).Append("\n");
            sb.Append("  ElectronicChannels: ").Append(ElectronicChannels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return obj.GetType() == GetType() && Equals((ElectronicChannelsCompanies)obj);
        }

        /// <summary>
        /// Returns true if ElectronicChannelsCompanies instances are equal
        /// </summary>
        /// <param name="other">Instance of ElectronicChannelsCompanies to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElectronicChannelsCompanies other)
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
                    UrlComplementaryList == other.UrlComplementaryList ||
                    UrlComplementaryList != null &&
                    UrlComplementaryList.Equals(other.UrlComplementaryList)
                ) && 
                (
                    ElectronicChannels == other.ElectronicChannels ||
                    ElectronicChannels != null &&
                    ElectronicChannels.SequenceEqual(other.ElectronicChannels)
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
                    if (UrlComplementaryList != null)
                    hashCode = hashCode * 59 + UrlComplementaryList.GetHashCode();
                    if (ElectronicChannels != null)
                    hashCode = hashCode * 59 + ElectronicChannels.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ElectronicChannelsCompanies left, ElectronicChannelsCompanies right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ElectronicChannelsCompanies left, ElectronicChannelsCompanies right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}