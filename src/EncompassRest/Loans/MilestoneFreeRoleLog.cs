using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans
{
    /// <summary>
    /// MilestoneFreeRoleLog
    /// </summary>
    public sealed partial class MilestoneFreeRoleLog : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyList<LogAlert>? _alerts;
        private DirtyList<LogComment>? _commentList;
        private DirtyValue<string?>? _comments;
        private DirtyValue<DateTime?>? _dateUtc;
        private DirtyValue<bool?>? _fileAttachmentsMigrated;
        private DirtyValue<string?>? _guid;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _isSystemSpecificIndicator;
        private DirtyValue<LoanAssociate?>? _loanAssociate;
        private DirtyValue<int?>? _logRecordIndex;
        private DirtyValue<string?>? _systemId;
        private DirtyValue<DateTime?>? _updatedDateUtc;

        /// <summary>
        /// MilestoneFreeRoleLog Alerts
        /// </summary>
        [AllowNull]
        public IList<LogAlert> Alerts { get => GetField(ref _alerts); set => SetField(ref _alerts, value); }

        /// <summary>
        /// MilestoneFreeRoleLog CommentList
        /// </summary>
        [AllowNull]
        public IList<LogComment> CommentList { get => GetField(ref _commentList); set => SetField(ref _commentList, value); }

        /// <summary>
        /// MilestoneFreeRoleLog Comments
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// MilestoneFreeRoleLog DateUtc
        /// </summary>
        public DateTime? DateUtc { get => _dateUtc; set => SetField(ref _dateUtc, value); }

        /// <summary>
        /// MilestoneFreeRoleLog FileAttachmentsMigrated
        /// </summary>
        public bool? FileAttachmentsMigrated { get => _fileAttachmentsMigrated; set => SetField(ref _fileAttachmentsMigrated, value); }

        /// <summary>
        /// MilestoneFreeRoleLog Guid
        /// </summary>
        public string? Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// MilestoneFreeRoleLog Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// MilestoneFreeRoleLog IsSystemSpecificIndicator
        /// </summary>
        public bool? IsSystemSpecificIndicator { get => _isSystemSpecificIndicator; set => SetField(ref _isSystemSpecificIndicator, value); }

        /// <summary>
        /// MilestoneFreeRoleLog LoanAssociate
        /// </summary>
        public LoanAssociate? LoanAssociate { get => _loanAssociate; set => SetField(ref _loanAssociate, value); }

        /// <summary>
        /// MilestoneFreeRoleLog LogRecordIndex
        /// </summary>
        public int? LogRecordIndex { get => _logRecordIndex; set => SetField(ref _logRecordIndex, value); }

        /// <summary>
        /// MilestoneFreeRoleLog SystemId
        /// </summary>
        public string? SystemId { get => _systemId; set => SetField(ref _systemId, value); }

        /// <summary>
        /// MilestoneFreeRoleLog UpdatedDateUtc
        /// </summary>
        public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
    }
}