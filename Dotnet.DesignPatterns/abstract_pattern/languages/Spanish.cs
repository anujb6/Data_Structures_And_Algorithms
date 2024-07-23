using Dotnet.DesignPatterns.abstract_pattern.abstracts;

namespace Dotnet.DesignPatterns.abstract_pattern.Languages
{
    public class Spanish : ILanguage
    {
        public void Greet()
        {
            Console.WriteLine("Hola! Buenos dias");
        }
    }
}
