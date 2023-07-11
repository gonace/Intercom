using System;

namespace Intercom.Exceptions
{
    public class NotConfiguredException : Exception
    {
        public NotConfiguredException()
            : base("You need to run .Configure(...) before accessing properties on Intercom.")
        {
        }
    }
}
