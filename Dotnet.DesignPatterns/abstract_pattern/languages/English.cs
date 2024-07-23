using Dotnet.DesignPatterns.abstract_pattern.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.DesignPatterns.abstract_pattern.Languages
{
    public class English : ILanguage
    {
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
    }
}
