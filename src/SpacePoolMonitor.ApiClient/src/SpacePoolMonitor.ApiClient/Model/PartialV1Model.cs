/*
 * Space Pool Developer API
 *
 * Space Pool public developer REST APIs
 *
 * The version of the OpenAPI document: v1
 * Contact: info@pool.space
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
using OpenAPIDateConverter = SpacePoolMonitor.ApiClient.Client.OpenAPIDateConverter;

namespace SpacePoolMonitor.ApiClient.Model
{
    /// <summary>
    /// PartialV1Model
    /// </summary>
    [DataContract(Name = "PartialV1Model")]
    public partial class PartialV1Model : IEquatable<PartialV1Model>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartialV1Model" /> class.
        /// </summary>
        /// <param name="launcherId">Launcher id that generated the partial.</param>
        /// <param name="harvesterId">Harvester id that generated the partial.</param>
        /// <param name="state">state.</param>
        /// <param name="error">error.</param>
        /// <param name="difficulty">Difficulty of the partial.</param>
        /// <param name="submissionDateTimeUtc">Date and time the partial was submitted to the pool.</param>
        public PartialV1Model(string launcherId = default(string), string harvesterId = default(string), PartialStateV1Model state = default(PartialStateV1Model), PartialErrorV1Model error = default(PartialErrorV1Model), long difficulty = default(long), string submissionDateTimeUtc = default(string))
        {
            this.LauncherId = launcherId;
            this.HarvesterId = harvesterId;
            this.State = state;
            this.Error = error;
            this.Difficulty = difficulty;
            this.SubmissionDateTimeUtc = submissionDateTimeUtc;
        }

        /// <summary>
        /// Launcher id that generated the partial
        /// </summary>
        /// <value>Launcher id that generated the partial</value>
        [DataMember(Name = "launcherId", EmitDefaultValue = true)]
        public string LauncherId { get; set; }

        /// <summary>
        /// Harvester id that generated the partial
        /// </summary>
        /// <value>Harvester id that generated the partial</value>
        [DataMember(Name = "harvesterId", EmitDefaultValue = true)]
        public string HarvesterId { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public PartialStateV1Model State { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public PartialErrorV1Model Error { get; set; }

        /// <summary>
        /// Difficulty of the partial
        /// </summary>
        /// <value>Difficulty of the partial</value>
        [DataMember(Name = "difficulty", EmitDefaultValue = false)]
        public long Difficulty { get; set; }

        /// <summary>
        /// Date and time the partial was submitted to the pool
        /// </summary>
        /// <value>Date and time the partial was submitted to the pool</value>
        [DataMember(Name = "submissionDateTimeUtc", EmitDefaultValue = true)]
        public string SubmissionDateTimeUtc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartialV1Model {\n");
            sb.Append("  LauncherId: ").Append(LauncherId).Append("\n");
            sb.Append("  HarvesterId: ").Append(HarvesterId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
            sb.Append("  SubmissionDateTimeUtc: ").Append(SubmissionDateTimeUtc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PartialV1Model);
        }

        /// <summary>
        /// Returns true if PartialV1Model instances are equal
        /// </summary>
        /// <param name="input">Instance of PartialV1Model to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartialV1Model input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LauncherId == input.LauncherId ||
                    (this.LauncherId != null &&
                    this.LauncherId.Equals(input.LauncherId))
                ) && 
                (
                    this.HarvesterId == input.HarvesterId ||
                    (this.HarvesterId != null &&
                    this.HarvesterId.Equals(input.HarvesterId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Difficulty == input.Difficulty ||
                    this.Difficulty.Equals(input.Difficulty)
                ) && 
                (
                    this.SubmissionDateTimeUtc == input.SubmissionDateTimeUtc ||
                    (this.SubmissionDateTimeUtc != null &&
                    this.SubmissionDateTimeUtc.Equals(input.SubmissionDateTimeUtc))
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
                if (this.LauncherId != null)
                {
                    hashCode = (hashCode * 59) + this.LauncherId.GetHashCode();
                }
                if (this.HarvesterId != null)
                {
                    hashCode = (hashCode * 59) + this.HarvesterId.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Difficulty.GetHashCode();
                if (this.SubmissionDateTimeUtc != null)
                {
                    hashCode = (hashCode * 59) + this.SubmissionDateTimeUtc.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}