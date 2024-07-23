using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.DesignPatterns.abstract_pattern.abstracts
{
    public interface ICapitalCity
    {
        int GetPopulation();

        List<string> ListTopAttractions();
    }
}
