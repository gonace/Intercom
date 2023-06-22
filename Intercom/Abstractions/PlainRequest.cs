using Intercom.Attributes;
using Intercom.Constants;

namespace Intercom.Abstractions
{
    public abstract class PlainRequest
    {
        #region Pagination
        /// <summary>
        /// What page of results to fetch.
        ///
        /// Defaults to first page.
        /// </summary>
        [QueryStringProperty("page")]
        public int? Page { get; set; } = null;
        /// <summary>
        /// How many results per page.
        ///
        /// Defaults to 15.
        /// </summary>
        [QueryStringProperty("per_page")]
        public int? PerPage { get; set; } = null;
        /// <summary>
        /// asc or desc. Return the companies in ascending
        /// or descending order.
        ///
        /// Defaults to desc
        /// </summary>
        [QueryStringProperty("order")]
        public Order Order { get; set; } = null;

        #endregion

        public abstract string Uri { get; }
    }
}
