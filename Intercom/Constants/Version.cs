using System;

namespace Intercom.Constants
{
    public static class ApiVersion
    {
        public static Version Latest => Version_2_9;

        public static Version Version_2_7 => new Version(2, 7);
        public static Version Version_2_8 => new Version(2, 8);
        public static Version Version_2_9 => new Version(2, 9);
    }
}
