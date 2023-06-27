using System.Globalization;

namespace Intercom.Constants
{
    public class Url
    {
        public static Url Production => new Url("https://api.intercom.io/");
        public static Url ProductionAustralia => new Url("https://api.au.intercom.io/");
        public static Url ProductionEurope => new Url("https://api.eu.intercom.io/");

        public string Value { get; }

        public Url(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToLower(CultureInfo.InvariantCulture);
        }
    }
}
