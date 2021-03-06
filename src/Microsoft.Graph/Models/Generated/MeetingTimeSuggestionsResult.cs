// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type MeetingTimeSuggestionsResult.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MeetingTimeSuggestionsResult
    {
    
        /// <summary>
        /// Gets or sets meetingTimeSuggestions.
		/// An array of meeting suggestions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meetingTimeSuggestions", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MeetingTimeSuggestion> MeetingTimeSuggestions { get; set; }
    
        /// <summary>
        /// Gets or sets emptySuggestionsReason.
		/// A reason for not returning any meeting suggestions. Possible values are: attendeesUnavailable, attendeesUnavailableOrUnknown, locationsUnavailable, organizerUnavailable, or unknown. This property is an empty string if the meetingTimeSuggestions property does include any meeting suggestions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emptySuggestionsReason", Required = Newtonsoft.Json.Required.Default)]
        public string EmptySuggestionsReason { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}
