// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a MongoDB shard key
    /// </summary>
    public partial class MongoDbShardKeySetting
    {
        /// <summary>
        /// Initializes a new instance of the MongoDbShardKeySetting class.
        /// </summary>
        public MongoDbShardKeySetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MongoDbShardKeySetting class.
        /// </summary>
        /// <param name="fields">The fields within the shard key</param>
        /// <param name="isUnique">Whether the shard key is unique</param>
        public MongoDbShardKeySetting(IList<MongoDbShardKeyField> fields, bool isUnique)
        {
            Fields = fields;
            IsUnique = isUnique;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fields within the shard key
        /// </summary>
        [JsonProperty(PropertyName = "fields")]
        public IList<MongoDbShardKeyField> Fields { get; set; }

        /// <summary>
        /// Gets or sets whether the shard key is unique
        /// </summary>
        [JsonProperty(PropertyName = "isUnique")]
        public bool IsUnique { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Fields == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Fields");
            }
            if (Fields != null)
            {
                foreach (var element in Fields)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
