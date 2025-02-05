// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Runtime.Serialization;

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    /// <summary>
    /// The type ItemCreateSessionRequestBody.
    /// </summary>
    [DataContract]
    public partial class ItemCreateSessionRequestBody
    {
    
        /// <summary>
        /// Gets or sets Item.
        /// </summary>
        [DataMember(Name = "item", EmitDefaultValue = false, IsRequired = false)]
        public ChunkedUploadSessionDescriptor Item { get; set; }
    
    }
}
