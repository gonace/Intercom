using Intercom.Abstractions;
using Intercom.Constants;
using System;

namespace Intercom.Clients
{
    public interface ITagsClient
    {
    }

    public class TagsClient : BaseClient<TagsClient>, ITagsClient
    {
        public TagsClient(string baseUri, string bearerToken, Version apiVersion)
            : base(baseUri, bearerToken, apiVersion)
        {
        }

        public TagsClient(string baseUri, string bearerToken)
            : base(baseUri, bearerToken, ApiVersion.Latest)
        {
        }
    }
}
