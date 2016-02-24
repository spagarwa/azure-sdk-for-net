// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Azure Storage account properties information.
    /// </summary>
    public partial class StorageAccountProperties
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountProperties class.
        /// </summary>
        public StorageAccountProperties() { }

        /// <summary>
        /// Initializes a new instance of the StorageAccountProperties class.
        /// </summary>
        public StorageAccountProperties(string accessKey = default(string), string suffix = default(string))
        {
            AccessKey = accessKey;
            Suffix = suffix;
        }

        /// <summary>
        /// Gets or sets the access key associated with this Azure Storage
        /// account that will be used to connect to it.
        /// </summary>
        [JsonProperty(PropertyName = "accessKey")]
        public string AccessKey { get; set; }

        /// <summary>
        /// Gets or sets the optional suffix for the Data Lake account.
        /// </summary>
        [JsonProperty(PropertyName = "suffix")]
        public string Suffix { get; set; }

    }
}
