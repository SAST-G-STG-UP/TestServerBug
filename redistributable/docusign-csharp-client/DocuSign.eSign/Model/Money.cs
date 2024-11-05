/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Money
    /// </summary>
    [DataContract]
    public partial class Money :  IEquatable<Money>, IValidatableObject
    {
        public Money()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Money" /> class.
        /// </summary>
        /// <param name="AmountInBaseUnit">.</param>
        /// <param name="Currency">.</param>
        /// <param name="DisplayAmount">.</param>
        public Money(string AmountInBaseUnit = default(string), string Currency = default(string), string DisplayAmount = default(string))
        {
            this.AmountInBaseUnit = AmountInBaseUnit;
            this.Currency = Currency;
            this.DisplayAmount = DisplayAmount;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="amountInBaseUnit", EmitDefaultValue=false)]
        public string AmountInBaseUnit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="displayAmount", EmitDefaultValue=false)]
        public string DisplayAmount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Money {\n");
            sb.Append("  AmountInBaseUnit: ").Append(AmountInBaseUnit).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DisplayAmount: ").Append(DisplayAmount).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Money);
        }

        /// <summary>
        /// Returns true if Money instances are equal
        /// </summary>
        /// <param name="other">Instance of Money to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Money other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AmountInBaseUnit == other.AmountInBaseUnit ||
                    this.AmountInBaseUnit != null &&
                    this.AmountInBaseUnit.Equals(other.AmountInBaseUnit)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.DisplayAmount == other.DisplayAmount ||
                    this.DisplayAmount != null &&
                    this.DisplayAmount.Equals(other.DisplayAmount)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AmountInBaseUnit != null)
                    hash = hash * 59 + this.AmountInBaseUnit.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.DisplayAmount != null)
                    hash = hash * 59 + this.DisplayAmount.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
