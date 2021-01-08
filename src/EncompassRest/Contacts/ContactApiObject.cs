﻿using EncompassRest.Utilities;

namespace EncompassRest.Contacts
{
    /// <summary>
    /// Base Contact Api Interface.
    /// </summary>
    public interface IContactApiObject : IApiObject
    {
        /// <summary>
        /// The contact id associated with the Api.
        /// </summary>
        string ContactId { get; }
    }

    /// <summary>
    /// Base Contact Api Class.
    /// </summary>
    public abstract class ContactApiObject : ApiObject, IContactApiObject
    {
        /// <summary>
        /// The contact id associated with the Api.
        /// </summary>
        public string ContactId { get; }

        internal ContactApiObject(IEncompassRestClient client, string contactId, string baseApiPath)
            : base(client, baseApiPath)
        {
            ContactId = contactId;
        }

        internal override string CreateErrorMessage(string methodName, string? resourceId = null) => base.CreateErrorMessage(methodName, $"{ContactId}{resourceId?.PrecedeWith("/")}");
    }
}