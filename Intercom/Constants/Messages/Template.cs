using System.Globalization;

namespace Intercom.Constants.Messages
{
    public class Template
    {
        public static readonly Template Personal = new Template("personal");
        public static readonly Template Plain = new Template("plain");

        public string Name { get; set; }

        public Template(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name.ToLower(CultureInfo.InvariantCulture);
        }
    }
}
