using Dotnet.DesignPatterns.abstract_pattern.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.DesignPatterns.abstract_pattern.capitals
{
    public class Madrid : ICapitalCity
    {
        public int GetPopulation()
        {
            Console.WriteLine("Madrid's population is around 32.2 lakhs");
            return 0;
        }

        public List<string> ListTopAttractions()
        {
            List<string> topAttractions = new List<string>
            {
                "Prado Museum",
                "Royal Palace of Madrid",
                "Retiro Park",
                "Puerta del Sol",
                "Plaza Mayor",
                "Gran Via",
                "Thyssen-Bornemisza Museum",
                "Santiago Bernabéu Stadium",
                "Temple of Debod",
                "Reina Sofia Museum",
                "El Rastro",
                "Cibeles Fountain",
                "Almudena Cathedral",
                "Puerta de Alcalá",
                "Plaza de España"
            };

            return topAttractions;
        }
    }
}
