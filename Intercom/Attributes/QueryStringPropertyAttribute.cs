using System;

namespace Intercom.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class QueryStringPropertyAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the name of the property.
        /// </summary>
        /// <value>The name of the property.</value>
        public string PropertyName { get; set; }

        public QueryStringPropertyAttribute()
        {
        }

        public QueryStringPropertyAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}
