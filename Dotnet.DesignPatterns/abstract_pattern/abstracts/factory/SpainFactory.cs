using Dotnet.DesignPatterns.abstract_pattern.capitals;
using Dotnet.DesignPatterns.abstract_pattern.Languages;

namespace Dotnet.DesignPatterns.abstract_pattern.abstracts.factory
{
    public class SpainFactory : IInternationalFactory
    {
        public ICapitalCity CreateCapital()
        {
            return new Madrid();
        }

        public ILanguage CreateLanguage()
        {
            return new Spanish();
        }
    }
}
