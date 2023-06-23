using System.Globalization;

namespace Intercom.Constants.Articles
{
    public class State
    {
        public static readonly State Draft = new State("draft");
        public static readonly State Published = new State("published");

        public string Name { get; set; }

        public State(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name.ToLower(CultureInfo.InvariantCulture);
        }
    }
}
