using System.Globalization;

namespace Intercom.Constants
{
    public class Order
    {
        public static readonly Order Asc = new Order("asc");
        public static readonly Order Desc = new Order("desc");

        public string Name { get; }

        private Order(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name.ToLower(CultureInfo.InvariantCulture);
        }
    }
}
