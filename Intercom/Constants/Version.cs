namespace Intercom.Constants
{
    public class Version
    {
        public static Version Latest => Version_2_9;

        public static Version Version_2_7 => new Version(System.Version.Parse("2.7"));
        public static Version Version_2_8 => new Version(System.Version.Parse("2.8"));
        public static Version Version_2_9 => new Version(System.Version.Parse("2.9"));

        public System.Version Value { get; }

        public Version(System.Version value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
