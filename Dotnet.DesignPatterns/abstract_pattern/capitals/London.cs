using Dotnet.DesignPatterns.abstract_pattern.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.DesignPatterns.abstract_pattern.capitals
{
    public class London : ICapitalCity
    {
        public int GetPopulation()
        {
            Console.WriteLine("London's Population is 89.8 lakhs");
            return 0;
        }

        public List<string> ListTopAttractions()
        {
            List<string> topAttractions = new List<string>
            {
                "British Museum",
                "Tower of London",
                "Buckingham Palace",
                "London Eye",
                "The Shard",
                "Tower Bridge",
                "Big Ben and the Houses of Parliament",
                "St. Paul's Cathedral",
                "Tate Modern",
                "Westminster Abbey",
                "Natural History Museum",
                "Victoria and Albert Museum",
                "Covent Garden",
                "Hyde Park",
                "Camden Market"
            };

            return topAttractions;
        }
    }
}
