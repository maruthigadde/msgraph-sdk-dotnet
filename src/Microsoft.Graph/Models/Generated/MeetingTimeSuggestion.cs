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
    /// The type MeetingTimeSuggestion.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MeetingTimeSuggestion
    {

        /// <summary>
        /// Gets or sets confidence.
        /// A percentage that represents the likelhood of all the attendees attending.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "confidence", Required = Newtonsoft.Json.Required.Default)]
        public double? Confidence { get; set; }
    
        /// <summary>
        /// Gets or sets order.
        /// Order of meeting time suggestions sorted by their computed confidence value from high to low, then by chronology if there are suggestions with the same confidence.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "order", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Order { get; set; }
    
        /// <summary>
        /// Gets or sets organizerAvailability.
        /// Availability of the meeting organizer for this meeting suggestion. The possible values are: free, tentative, busy, oof, workingElsewhere, unknown.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "organizerAvailability", Required = Newtonsoft.Json.Required.Default)]
        public FreeBusyStatus? OrganizerAvailability { get; set; }
    
        /// <summary>
        /// Gets or sets attendeeAvailability.
        /// An array that shows the availability status of each attendee for this meeting suggestion.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attendeeAvailability", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AttendeeAvailability> AttendeeAvailability { get; set; }
    
        /// <summary>
        /// Gets or sets locations.
        /// An array that specifies the name and geographic location of each meeting location for this meeting suggestion.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "locations", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Location> Locations { get; set; }
    
        /// <summary>
        /// Gets or sets suggestionReason.
        /// Reason for suggesting the meeting time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "suggestionReason", Required = Newtonsoft.Json.Required.Default)]
        public string SuggestionReason { get; set; }
    
        /// <summary>
        /// Gets or sets meetingTimeSlot.
        /// A time period suggested for the meeting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meetingTimeSlot", Required = Newtonsoft.Json.Required.Default)]
        public TimeSlot MeetingTimeSlot { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
