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
using SwaggerDateConverter = PostFinanceCheckout.Client.SwaggerDateConverter;

namespace PostFinanceCheckout.Model
{
    /// <summary>
    /// PaymentMethod
    /// </summary>
    [DataContract]
    public partial class PaymentMethod :  IEquatable<PaymentMethod>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentMethod()
        {
        }

        /// <summary>
        /// Gets or Sets DataCollectionTypes
        /// </summary>
        [DataMember(Name="dataCollectionTypes", EmitDefaultValue=true)]
        public List<DataCollectionType> DataCollectionTypes { get; private set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public Dictionary<string, string> Description { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets ImagePath
        /// </summary>
        [DataMember(Name="imagePath", EmitDefaultValue=true)]
        public string ImagePath { get; private set; }

        /// <summary>
        /// Gets or Sets MerchantDescription
        /// </summary>
        [DataMember(Name="merchantDescription", EmitDefaultValue=true)]
        public Dictionary<string, string> MerchantDescription { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public Dictionary<string, string> Name { get; private set; }

        /// <summary>
        /// Gets or Sets SupportedCurrencies
        /// </summary>
        [DataMember(Name="supportedCurrencies", EmitDefaultValue=true)]
        public List<string> SupportedCurrencies { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethod {\n");
            sb.Append("  DataCollectionTypes: ").Append(DataCollectionTypes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImagePath: ").Append(ImagePath).Append("\n");
            sb.Append("  MerchantDescription: ").Append(MerchantDescription).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SupportedCurrencies: ").Append(SupportedCurrencies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentMethod);
        }

        /// <summary>
        /// Returns true if PaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataCollectionTypes == input.DataCollectionTypes ||
                    this.DataCollectionTypes != null &&
                    this.DataCollectionTypes.SequenceEqual(input.DataCollectionTypes)
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ImagePath == input.ImagePath ||
                    (this.ImagePath != null &&
                    this.ImagePath.Equals(input.ImagePath))
                ) && 
                (
                    this.MerchantDescription == input.MerchantDescription ||
                    this.MerchantDescription != null &&
                    this.MerchantDescription.SequenceEqual(input.MerchantDescription)
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.SupportedCurrencies == input.SupportedCurrencies ||
                    this.SupportedCurrencies != null &&
                    this.SupportedCurrencies.SequenceEqual(input.SupportedCurrencies)
                );
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
                if (this.DataCollectionTypes != null)
                    hashCode = hashCode * 59 + this.DataCollectionTypes.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImagePath != null)
                    hashCode = hashCode * 59 + this.ImagePath.GetHashCode();
                if (this.MerchantDescription != null)
                    hashCode = hashCode * 59 + this.MerchantDescription.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SupportedCurrencies != null)
                    hashCode = hashCode * 59 + this.SupportedCurrencies.GetHashCode();
                return hashCode;
            }
        }

    }

}
