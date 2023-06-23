using System.Globalization;

namespace Intercom.Constants.Conversations
{
    public class Type
    {
        public static readonly Type Contact = new Type("contact");
        public static readonly Type Lead = new Type("lead");
        public static readonly Type User = new Type("user");

        public string Name { get; set; }

        public Type(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name.ToLower(CultureInfo.InvariantCulture);
        }
    }
}
