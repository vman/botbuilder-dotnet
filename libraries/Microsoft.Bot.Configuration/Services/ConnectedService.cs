﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Configuration
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    [Obsolete("This class is deprecated.  See https://aka.ms/bot-file-basics for more information.", false)]
    public class ConnectedService
    {
        public ConnectedService(string type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets type of the service.
        /// </summary>
        /// <value>The type of service.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets user friendly name of the service.
        /// </summary>
        /// <value>The name of the service.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets unique id for the service.
        /// </summary>
        /// <value>The Id of the service.</value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets properties that are not otherwise defined.
        /// </summary>
        /// <value>The extended properties for the object.</value>
        /// <remarks>With this, properties not represented in the defined type are not dropped when
        /// the JSON object is deserialized, but are instead stored in this property. Such properties
        /// will be written to a JSON object when the instance is serialized.</remarks>
        [JsonExtensionData(ReadData = true, WriteData = true)]
        public JObject Properties { get; set; } = new JObject();

        /// <summary>
        /// Decrypt properties on this service.
        /// </summary>
        /// <param name="secret"> secret to use to decrypt the keys in this service.</param>
        public virtual void Decrypt(string secret)
        {
        }

        /// <summary>
        /// Encrypt properties on this service.
        /// </summary>
        /// <param name="secret">secret to use to encrypt the keys in this service.</param>
        public virtual void Encrypt(string secret)
        {
        }
    }
}
