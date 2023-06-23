using System.Globalization;

namespace Intercom.Constants.Messages
{
    public class From
    {
        public static readonly From Admin = new From("admin");

        public string Name { get; set; }

        public From(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name.ToLower(CultureInfo.InvariantCulture);
        }

    }
}
