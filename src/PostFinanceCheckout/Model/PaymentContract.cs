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
    /// PaymentContract
    /// </summary>
    [DataContract]
    public partial class PaymentContract :  IEquatable<PaymentContract>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public PaymentContractState? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentContract" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentContract()
        {
        }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public Account Account { get; private set; }

        /// <summary>
        /// Gets or Sets ActivatedOn
        /// </summary>
        [DataMember(Name="activatedOn", EmitDefaultValue=false)]
        public DateTime? ActivatedOn { get; private set; }

        /// <summary>
        /// Gets or Sets ContractIdentifier
        /// </summary>
        [DataMember(Name="contractIdentifier", EmitDefaultValue=false)]
        public string ContractIdentifier { get; private set; }

        /// <summary>
        /// Gets or Sets ContractType
        /// </summary>
        [DataMember(Name="contractType", EmitDefaultValue=false)]
        public PaymentContractType ContractType { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public User CreatedBy { get; private set; }

        /// <summary>
        /// The created on date indicates the date on which the entity was stored into the database.
        /// </summary>
        /// <value>The created on date indicates the date on which the entity was stored into the database.</value>
        [DataMember(Name="createdOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; private set; }

        /// <summary>
        /// A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead.
        /// </summary>
        /// <value>A client generated nonce which identifies the entity to be created. Subsequent creation requests with the same external ID will not create new entities but return the initially created entity instead.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; private set; }

        /// <summary>
        /// The ID is the primary key of the entity. The ID identifies the entity uniquely.
        /// </summary>
        /// <value>The ID is the primary key of the entity. The ID identifies the entity uniquely.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets or Sets RejectedOn
        /// </summary>
        [DataMember(Name="rejectedOn", EmitDefaultValue=false)]
        public DateTime? RejectedOn { get; private set; }

        /// <summary>
        /// Gets or Sets RejectionReason
        /// </summary>
        [DataMember(Name="rejectionReason", EmitDefaultValue=false)]
        public FailureReason RejectionReason { get; private set; }

        /// <summary>
        /// Gets or Sets StartTerminatingOn
        /// </summary>
        [DataMember(Name="startTerminatingOn", EmitDefaultValue=false)]
        public DateTime? StartTerminatingOn { get; private set; }


        /// <summary>
        /// Gets or Sets TerminatedBy
        /// </summary>
        [DataMember(Name="terminatedBy", EmitDefaultValue=false)]
        public User TerminatedBy { get; private set; }

        /// <summary>
        /// Gets or Sets TerminatedOn
        /// </summary>
        [DataMember(Name="terminatedOn", EmitDefaultValue=false)]
        public DateTime? TerminatedOn { get; private set; }

        /// <summary>
        /// The version number indicates the version of the entity. The version is incremented whenever the entity is changed.
        /// </summary>
        /// <value>The version number indicates the version of the entity. The version is incremented whenever the entity is changed.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentContract {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  ActivatedOn: ").Append(ActivatedOn).Append("\n");
            sb.Append("  ContractIdentifier: ").Append(ContractIdentifier).Append("\n");
            sb.Append("  ContractType: ").Append(ContractType).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RejectedOn: ").Append(RejectedOn).Append("\n");
            sb.Append("  RejectionReason: ").Append(RejectionReason).Append("\n");
            sb.Append("  StartTerminatingOn: ").Append(StartTerminatingOn).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TerminatedBy: ").Append(TerminatedBy).Append("\n");
            sb.Append("  TerminatedOn: ").Append(TerminatedOn).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as PaymentContract);
        }

        /// <summary>
        /// Returns true if PaymentContract instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentContract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.ActivatedOn == input.ActivatedOn ||
                    (this.ActivatedOn != null &&
                    this.ActivatedOn.Equals(input.ActivatedOn))
                ) && 
                (
                    this.ContractIdentifier == input.ContractIdentifier ||
                    (this.ContractIdentifier != null &&
                    this.ContractIdentifier.Equals(input.ContractIdentifier))
                ) && 
                (
                    this.ContractType == input.ContractType ||
                    (this.ContractType != null &&
                    this.ContractType.Equals(input.ContractType))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RejectedOn == input.RejectedOn ||
                    (this.RejectedOn != null &&
                    this.RejectedOn.Equals(input.RejectedOn))
                ) && 
                (
                    this.RejectionReason == input.RejectionReason ||
                    (this.RejectionReason != null &&
                    this.RejectionReason.Equals(input.RejectionReason))
                ) && 
                (
                    this.StartTerminatingOn == input.StartTerminatingOn ||
                    (this.StartTerminatingOn != null &&
                    this.StartTerminatingOn.Equals(input.StartTerminatingOn))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TerminatedBy == input.TerminatedBy ||
                    (this.TerminatedBy != null &&
                    this.TerminatedBy.Equals(input.TerminatedBy))
                ) && 
                (
                    this.TerminatedOn == input.TerminatedOn ||
                    (this.TerminatedOn != null &&
                    this.TerminatedOn.Equals(input.TerminatedOn))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.ActivatedOn != null)
                    hashCode = hashCode * 59 + this.ActivatedOn.GetHashCode();
                if (this.ContractIdentifier != null)
                    hashCode = hashCode * 59 + this.ContractIdentifier.GetHashCode();
                if (this.ContractType != null)
                    hashCode = hashCode * 59 + this.ContractType.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedOn != null)
                    hashCode = hashCode * 59 + this.CreatedOn.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RejectedOn != null)
                    hashCode = hashCode * 59 + this.RejectedOn.GetHashCode();
                if (this.RejectionReason != null)
                    hashCode = hashCode * 59 + this.RejectionReason.GetHashCode();
                if (this.StartTerminatingOn != null)
                    hashCode = hashCode * 59 + this.StartTerminatingOn.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TerminatedBy != null)
                    hashCode = hashCode * 59 + this.TerminatedBy.GetHashCode();
                if (this.TerminatedOn != null)
                    hashCode = hashCode * 59 + this.TerminatedOn.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }

}
