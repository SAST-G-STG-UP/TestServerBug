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
    /// Contains information about an APP store product.
    /// </summary>
    [DataContract]
    public partial class AppStoreProduct :  IEquatable<AppStoreProduct>, IValidatableObject
    {
        public AppStoreProduct()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreProduct" /> class.
        /// </summary>
        /// <param name="MarketPlace">.</param>
        /// <param name="ProductId">The Product ID from the AppStore..</param>
        public AppStoreProduct(string MarketPlace = default(string), string ProductId = default(string))
        {
            this.MarketPlace = MarketPlace;
            this.ProductId = ProductId;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="marketPlace", EmitDefaultValue=false)]
        public string MarketPlace { get; set; }
        /// <summary>
        /// The Product ID from the AppStore.
        /// </summary>
        /// <value>The Product ID from the AppStore.</value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public string ProductId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppStoreProduct {\n");
            sb.Append("  MarketPlace: ").Append(MarketPlace).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
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
            return this.Equals(obj as AppStoreProduct);
        }

        /// <summary>
        /// Returns true if AppStoreProduct instances are equal
        /// </summary>
        /// <param name="other">Instance of AppStoreProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreProduct other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MarketPlace == other.MarketPlace ||
                    this.MarketPlace != null &&
                    this.MarketPlace.Equals(other.MarketPlace)
                ) && 
                (
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
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
                if (this.MarketPlace != null)
                    hash = hash * 59 + this.MarketPlace.GetHashCode();
                if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
