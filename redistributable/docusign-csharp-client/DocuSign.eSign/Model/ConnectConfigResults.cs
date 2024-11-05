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
    /// ConnectConfigResults
    /// </summary>
    [DataContract]
    public partial class ConnectConfigResults :  IEquatable<ConnectConfigResults>, IValidatableObject
    {
        public ConnectConfigResults()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectConfigResults" /> class.
        /// </summary>
        /// <param name="Configurations">Reserved: TBD.</param>
        /// <param name="TotalRecords">.</param>
        public ConnectConfigResults(List<ConnectCustomConfiguration> Configurations = default(List<ConnectCustomConfiguration>), string TotalRecords = default(string))
        {
            this.Configurations = Configurations;
            this.TotalRecords = TotalRecords;
        }
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="configurations", EmitDefaultValue=false)]
        public List<ConnectCustomConfiguration> Configurations { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="totalRecords", EmitDefaultValue=false)]
        public string TotalRecords { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectConfigResults {\n");
            sb.Append("  Configurations: ").Append(Configurations).Append("\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
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
            return this.Equals(obj as ConnectConfigResults);
        }

        /// <summary>
        /// Returns true if ConnectConfigResults instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectConfigResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectConfigResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Configurations == other.Configurations ||
                    this.Configurations != null &&
                    this.Configurations.SequenceEqual(other.Configurations)
                ) && 
                (
                    this.TotalRecords == other.TotalRecords ||
                    this.TotalRecords != null &&
                    this.TotalRecords.Equals(other.TotalRecords)
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
                if (this.Configurations != null)
                    hash = hash * 59 + this.Configurations.GetHashCode();
                if (this.TotalRecords != null)
                    hash = hash * 59 + this.TotalRecords.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
