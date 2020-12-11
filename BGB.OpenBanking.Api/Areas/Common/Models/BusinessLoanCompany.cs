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
    public partial class BusinessLoanCompany : CNPJ, IEquatable<BusinessLoanCompany>
    { 
        /// <summary>
        /// Nome da Instituição, pertencente à marca, responsável pela modalidade de Empréstimos. p.ex.&#x27;Empresa da Organização A&#x27;
        /// </summary>
        /// <value>Nome da Instituição, pertencente à marca, responsável pela modalidade de Empréstimos. p.ex.&#x27;Empresa da Organização A&#x27;</value>
        [Required]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// URL do link que conterá a lista complementar com os nomes e CNPJs agrupados sob o mesmo cnpjNumber. Os contidos nessa lista possuem as mesmas características para produtos e serviços. Endereço eletrônico de acesso ao canal.
        /// </summary>
        /// <value>URL do link que conterá a lista complementar com os nomes e CNPJs agrupados sob o mesmo cnpjNumber. Os contidos nessa lista possuem as mesmas características para produtos e serviços. Endereço eletrônico de acesso ao canal.</value>
        [DataMember(Name="urlComplementaryList")]
        public string UrlComplementaryList { get; set; }

        /// <summary>
        /// Lista de modalidades de empréstimos
        /// </summary>
        /// <value>Lista de modalidades de empréstimos</value>
        [Required]
        [DataMember(Name="businessLoans")]
        public List<BusinessLoan> BusinessLoans { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessLoanCompany {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UrlComplementaryList: ").Append(UrlComplementaryList).Append("\n");
            sb.Append("  BusinessLoans: ").Append(BusinessLoans).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BusinessLoanCompany)obj);
        }

        /// <summary>
        /// Returns true if BusinessLoanCompany instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessLoanCompany to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessLoanCompany other)
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
                    BusinessLoans == other.BusinessLoans ||
                    BusinessLoans != null &&
                    BusinessLoans.SequenceEqual(other.BusinessLoans)
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
                    if (BusinessLoans != null)
                    hashCode = hashCode * 59 + BusinessLoans.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BusinessLoanCompany left, BusinessLoanCompany right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BusinessLoanCompany left, BusinessLoanCompany right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}