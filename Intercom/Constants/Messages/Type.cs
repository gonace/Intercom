using System.Globalization;

namespace Intercom.Constants.Messages
{
    public class Type
    {
        public static readonly Type Email = new Type("email");
        public static readonly Type InApp = new Type("in_app");

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
