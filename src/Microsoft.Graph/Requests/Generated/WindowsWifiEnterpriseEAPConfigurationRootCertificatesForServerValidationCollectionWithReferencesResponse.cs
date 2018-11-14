// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesResponse.cs.tt
namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type WindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionWithReferencesResponse.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class WindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionWithReferencesResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IWindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionWithReferencesPage"/> value.
        /// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName ="value", Required = Newtonsoft.Json.Required.Default)]
        public IWindowsWifiEnterpriseEAPConfigurationRootCertificatesForServerValidationCollectionWithReferencesPage Value { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}