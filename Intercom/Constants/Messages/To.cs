using System.Globalization;

namespace Intercom.Constants.Messages
{
    public class To
    {
        public static readonly To Lead = new To("lead");
        public static readonly To User = new To("user");

        public string Name { get; set; }

        public To(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name.ToLower(CultureInfo.InvariantCulture);
        }
    }
}
