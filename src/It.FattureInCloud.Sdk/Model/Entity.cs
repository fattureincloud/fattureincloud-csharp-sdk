/*
 * Fatture in Cloud API v2 - API Reference
 *
 * Connect your software with Fatture in Cloud, the invoicing platform chosen by more than 400.000 businesses in Italy.   The Fatture in Cloud API is based on REST, and makes possible to interact with the user related data prior authorization via OAuth2 protocol.
 *
 * The version of the OpenAPI document: 2.0.3
 * Contact: info@fattureincloud.it
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = It.FattureInCloud.Sdk.Client.OpenAPIDateConverter;
using System.Reflection;

namespace It.FattureInCloud.Sdk.Model
{
    /// <summary>
    /// Entity
    /// </summary>
    [JsonConverter(typeof(EntityJsonConverter))]
    [DataContract(Name = "Entity")]
    public partial class Entity : AbstractOpenAPISchema, IEquatable<Entity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class
        /// with the <see cref="ModelClient" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ModelClient.</param>
        public Entity(ModelClient actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class
        /// with the <see cref="Supplier" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Supplier.</param>
        public Entity(Supplier actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(ModelClient))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(Supplier))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ModelClient, Supplier");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ModelClient`. If the actual instance is not `ModelClient`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ModelClient</returns>
        public ModelClient GetModelClient()
        {
            return (ModelClient)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `Supplier`. If the actual instance is not `Supplier`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Supplier</returns>
        public Supplier GetSupplier()
        {
            return (Supplier)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Entity {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, Entity.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Entity
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Entity</returns>
        public static Entity FromJson(string jsonString)
        {
            Entity newEntity = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newEntity;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ModelClient).GetProperty("AdditionalProperties") == null)
                {
                    newEntity = new Entity(JsonConvert.DeserializeObject<ModelClient>(jsonString, Entity.SerializerSettings));
                }
                else
                {
                    newEntity = new Entity(JsonConvert.DeserializeObject<ModelClient>(jsonString, Entity.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ModelClient");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ModelClient: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Supplier).GetProperty("AdditionalProperties") == null)
                {
                    newEntity = new Entity(JsonConvert.DeserializeObject<Supplier>(jsonString, Entity.SerializerSettings));
                }
                else
                {
                    newEntity = new Entity(JsonConvert.DeserializeObject<Supplier>(jsonString, Entity.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Supplier");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Supplier: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newEntity;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Entity);
        }

        /// <summary>
        /// Returns true if Entity instances are equal
        /// </summary>
        /// <param name="input">Instance of Entity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Entity input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for Entity
    /// </summary>
    public class EntityJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Entity).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return Entity.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
