using Intercom.Attributes;
using Intercom.Constants;

namespace Intercom.Abstractions
{
    public abstract class PlainRequest
    {
        #region Pagination

        [QueryStringProperty("page")]
        public int? Page { get; set; } = null;
        [QueryStringProperty("per_page")]
        public int? Limit { get; set; } = null;
        [QueryStringProperty("order")]
        public Order Order { get; set; } = null;

        #endregion

        public abstract string Uri { get; }
    }
}
