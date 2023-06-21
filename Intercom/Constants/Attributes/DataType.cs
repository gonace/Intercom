using System.Globalization;

namespace Intercom.Constants.Attributes
{
    public class DataType
    {
        public static readonly DataType String = new DataType("string");
        public static readonly DataType Integer = new DataType("integer");
        public static readonly DataType Float = new DataType("float");
        public static readonly DataType Boolean = new DataType("boolean");
        public static readonly DataType Datetime = new DataType("datetime");
        public static readonly DataType Date = new DataType("date");

        public string Name { get; set; }

        public DataType(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name.ToLower(CultureInfo.InvariantCulture);
        }
    }
}
