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
    public partial class SharedAutomatedTellerMachinesCompany : IEquatable<SharedAutomatedTellerMachinesCompany>
    { 
        /// <summary>
        /// Nome da Instituição, pertencente à Marca.
        /// </summary>
        /// <value>Nome da Instituição, pertencente à Marca.</value>
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// URL de link para lista complementar com os nomes e CNPJs agrupados para o caso instituições ofertantes de produtos e serviços com as mesmas características. 
        /// </summary>
        /// <value>URL de link para lista complementar com os nomes e CNPJs agrupados para o caso instituições ofertantes de produtos e serviços com as mesmas características. </value>
        [DataMember(Name="urlComplementaryList")]
        public string UrlComplementaryList { get; set; }

        /// <summary>
        /// Número completo do CNPJ da instituição
        /// </summary>
        /// <value>Número completo do CNPJ da instituição</value>
        [DataMember(Name="cnpjNumber")]
        public string CnpjNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharedAutomatedTellerMachinesCompany {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UrlComplementaryList: ").Append(UrlComplementaryList).Append("\n");
            sb.Append("  CnpjNumber: ").Append(CnpjNumber).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SharedAutomatedTellerMachinesCompany)obj);
        }

        /// <summary>
        /// Returns true if SharedAutomatedTellerMachinesCompany instances are equal
        /// </summary>
        /// <param name="other">Instance of SharedAutomatedTellerMachinesCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharedAutomatedTellerMachinesCompany other)
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
                    CnpjNumber == other.CnpjNumber ||
                    CnpjNumber != null &&
                    CnpjNumber.Equals(other.CnpjNumber)
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
                    if (CnpjNumber != null)
                    hashCode = hashCode * 59 + CnpjNumber.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SharedAutomatedTellerMachinesCompany left, SharedAutomatedTellerMachinesCompany right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SharedAutomatedTellerMachinesCompany left, SharedAutomatedTellerMachinesCompany right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
