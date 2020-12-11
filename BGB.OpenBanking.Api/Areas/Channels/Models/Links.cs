/*
 * APIs OpenData do Open Banking Brasil
 *
 * As APIs descritas neste documento são referentes as APIs da fase OpenData do Open Banking Brasil.
 *
 * OpenAPI spec version: 1.0.0
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

namespace BGB.OpenBanking.Api.Areas.Channels.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Links : IEquatable<Links>
    { 
        /// <summary>
        /// URL da página atualmente requisitada
        /// </summary>
        /// <value>URL da página atualmente requisitada</value>
        [DataMember(Name="self")]
        public string Self { get; set; }

        /// <summary>
        /// URL da primeira página de registros
        /// </summary>
        /// <value>URL da primeira página de registros</value>
        [DataMember(Name="first")]
        public string First { get; set; }

        /// <summary>
        /// URL da página anterior de registros
        /// </summary>
        /// <value>URL da página anterior de registros</value>
        [DataMember(Name="prev")]
        public string Prev { get; set; }

        /// <summary>
        /// URL da próxima página de registros
        /// </summary>
        /// <value>URL da próxima página de registros</value>
        [DataMember(Name="next")]
        public string Next { get; set; }

        /// <summary>
        /// URL da última página de registros
        /// </summary>
        /// <value>URL da última página de registros</value>
        [DataMember(Name="last")]
        public string Last { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Links {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Prev: ").Append(Prev).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Links)obj);
        }

        /// <summary>
        /// Returns true if Links instances are equal
        /// </summary>
        /// <param name="other">Instance of Links to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Links other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Self == other.Self ||
                    Self != null &&
                    Self.Equals(other.Self)
                ) && 
                (
                    First == other.First ||
                    First != null &&
                    First.Equals(other.First)
                ) && 
                (
                    Prev == other.Prev ||
                    Prev != null &&
                    Prev.Equals(other.Prev)
                ) && 
                (
                    Next == other.Next ||
                    Next != null &&
                    Next.Equals(other.Next)
                ) && 
                (
                    Last == other.Last ||
                    Last != null &&
                    Last.Equals(other.Last)
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
                    if (Self != null)
                    hashCode = hashCode * 59 + Self.GetHashCode();
                    if (First != null)
                    hashCode = hashCode * 59 + First.GetHashCode();
                    if (Prev != null)
                    hashCode = hashCode * 59 + Prev.GetHashCode();
                    if (Next != null)
                    hashCode = hashCode * 59 + Next.GetHashCode();
                    if (Last != null)
                    hashCode = hashCode * 59 + Last.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Links left, Links right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Links left, Links right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
