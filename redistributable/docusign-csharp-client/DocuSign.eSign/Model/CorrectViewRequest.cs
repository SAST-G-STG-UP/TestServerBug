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
    /// CorrectViewRequest
    /// </summary>
    [DataContract]
    public partial class CorrectViewRequest :  IEquatable<CorrectViewRequest>, IValidatableObject
    {
        public CorrectViewRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorrectViewRequest" /> class.
        /// </summary>
        /// <param name="ReturnUrl">The url used after correct/send view session has ended. DocuSign redirects to the url and includes an event parameter that can be used by your app. The event parameters returned are:   * send (user corrected and sent the envelope) * save (user saved the envelope) * cancel (user canceled the transaction.) * error (there was an error when performing the correct or send) * sessionEnd (the session ended before the user completed a different action)  ###### Note: Include https:// in the URL or the redirect might not succeed on some browsers. .</param>
        /// <param name="SuppressNavigation">Specifies whether the window is displayed with or without dressing..</param>
        public CorrectViewRequest(string ReturnUrl = default(string), string SuppressNavigation = default(string))
        {
            this.ReturnUrl = ReturnUrl;
            this.SuppressNavigation = SuppressNavigation;
        }
        
        /// <summary>
        /// The url used after correct/send view session has ended. DocuSign redirects to the url and includes an event parameter that can be used by your app. The event parameters returned are:   * send (user corrected and sent the envelope) * save (user saved the envelope) * cancel (user canceled the transaction.) * error (there was an error when performing the correct or send) * sessionEnd (the session ended before the user completed a different action)  ###### Note: Include https:// in the URL or the redirect might not succeed on some browsers. 
        /// </summary>
        /// <value>The url used after correct/send view session has ended. DocuSign redirects to the url and includes an event parameter that can be used by your app. The event parameters returned are:   * send (user corrected and sent the envelope) * save (user saved the envelope) * cancel (user canceled the transaction.) * error (there was an error when performing the correct or send) * sessionEnd (the session ended before the user completed a different action)  ###### Note: Include https:// in the URL or the redirect might not succeed on some browsers. </value>
        [DataMember(Name="returnUrl", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }
        /// <summary>
        /// Specifies whether the window is displayed with or without dressing.
        /// </summary>
        /// <value>Specifies whether the window is displayed with or without dressing.</value>
        [DataMember(Name="suppressNavigation", EmitDefaultValue=false)]
        public string SuppressNavigation { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CorrectViewRequest {\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  SuppressNavigation: ").Append(SuppressNavigation).Append("\n");
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
            return this.Equals(obj as CorrectViewRequest);
        }

        /// <summary>
        /// Returns true if CorrectViewRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CorrectViewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CorrectViewRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReturnUrl == other.ReturnUrl ||
                    this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(other.ReturnUrl)
                ) && 
                (
                    this.SuppressNavigation == other.SuppressNavigation ||
                    this.SuppressNavigation != null &&
                    this.SuppressNavigation.Equals(other.SuppressNavigation)
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
                if (this.ReturnUrl != null)
                    hash = hash * 59 + this.ReturnUrl.GetHashCode();
                if (this.SuppressNavigation != null)
                    hash = hash * 59 + this.SuppressNavigation.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
