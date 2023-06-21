using System.Globalization;

namespace Intercom.Constants.Attributes
{
    public class Model
    {
        public static readonly Model Contact = new Model("contact");
        public static readonly Model Company = new Model("company");
        public static readonly Model Conversation = new Model("conversation");

        public string Name { get; set; }

        public Model(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name.ToLower(CultureInfo.InvariantCulture);
        }
    }
}
