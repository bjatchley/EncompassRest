﻿namespace EncompassRest.Company
{
    /// <summary>
    /// Global Custom Data Objects Apis
    /// </summary>
    public interface IGlobalCustomDataObjects : CustomDataObjects.ICustomDataObjects
    {
    }

    /// <summary>
    /// Global Custom Data Objects Apis
    /// </summary>
    public sealed class GlobalCustomDataObjects : CustomDataObjects.CustomDataObjects, IGlobalCustomDataObjects
    {
        internal GlobalCustomDataObjects(IEncompassRestClient client)
            : base(client, "encompass/v1/company/customObjects")
        {
        }
    }
}