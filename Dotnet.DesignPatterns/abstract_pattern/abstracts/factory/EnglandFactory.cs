using Dotnet.DesignPatterns.abstract_pattern.capitals;
using Dotnet.DesignPatterns.abstract_pattern.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.DesignPatterns.abstract_pattern.abstracts.factory
{
    public class EnglandFactory : IInternationalFactory
    {
        public ICapitalCity CreateCapital()
        {
            return new London();
        }

        public ILanguage CreateLanguage()
        {
            return new English();
        }
    }
}
