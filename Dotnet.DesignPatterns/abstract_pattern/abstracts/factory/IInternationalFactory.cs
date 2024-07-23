using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.DesignPatterns.abstract_pattern.abstracts.factory
{
    public interface IInternationalFactory
    {
        ILanguage CreateLanguage();

        ICapitalCity CreateCapital();
    }
}
