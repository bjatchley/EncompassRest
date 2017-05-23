using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class PreliminaryConditionLog
    {
        public string AddedBy { get; set; }
        public JsonNullable<List<LogAlert>> Alerts { get; set; }
        public string AlertsXml { get; set; }
        public string Category { get; set; }
        public JsonNullable<List<LogComment>> CommentList { get; set; }
        public string CommentListXml { get; set; }
        public string Comments { get; set; }
        public JsonNullable<DateTime?> DateAddedUtc { get; set; }
        public JsonNullable<DateTime?> DateExpected { get; set; }
        public JsonNullable<DateTime?> DateFulfilled { get; set; }
        public JsonNullable<DateTime?> DateReceived { get; set; }
        public JsonNullable<DateTime?> DateRequestedUtc { get; set; }
        public JsonNullable<DateTime?> DateRerequestedUtc { get; set; }
        public JsonNullable<DateTime?> DateUtc { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public bool? Expected { get; set; }
        public JsonNullable<bool?> FileAttachmentsMigrated { get; set; }
        public bool? Fulfilled { get; set; }
        public string FulfilledBy { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public bool? IsPastDue { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public int? LogRecordIndex { get; set; }
        public string PairId { get; set; }
        public string PriorTo { get; set; }
        public bool? Received { get; set; }
        public string ReceivedBy { get; set; }
        public bool? Requested { get; set; }
        public string RequestedBy { get; set; }
        public bool? Rerequested { get; set; }
        public string RerequestedBy { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public JsonNullable<string> SystemId { get; set; }
        public string Title { get; set; }
        public JsonNullable<bool?> UnderwriterAccessIndicator { get; set; }
    }
}