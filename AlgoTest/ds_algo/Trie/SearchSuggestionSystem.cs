using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Trie
{
    public class SearchSuggestionSystem
    {
        public static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            TrieNode root = new TrieNode();
            var res = new List<IList<string>>();
            Array.Sort(products);

            foreach (var product in products)
            {
                var node = root;
                foreach(char c in product)
                {
                    if (!node.Children.ContainsKey(c))
                        node.Children.Add(c, new TrieNode());

                    node = node.Children[c];
                }

                node.IsWord = true;
            }

            var currentPrefix = new StringBuilder();
            var currentNode = root;

            foreach (char c in searchWord)
            {
                currentPrefix.Append(c);
                if (currentNode.Children.ContainsKey(c))
                {
                    currentNode = currentNode.Children[c];
                    var suggestions = new List<string>();

                    FindSuggestions(currentNode, currentPrefix, suggestions);

                    res.Add(suggestions.Take(3).ToList());
                }
                else
                {
                    res.Add(new List<string>());
                    currentNode = new TrieNode();
                }
            }

            return res;
        }

        private static void FindSuggestions(TrieNode node, StringBuilder currentPrefix, List<string> suggestions)
        {
            if (node.IsWord)
                suggestions.Add(currentPrefix.ToString());

            foreach (var child in node.Children.OrderBy(c => c.Key))
            {
                FindSuggestions(child.Value, currentPrefix.Append(child.Key), suggestions);
                currentPrefix.Length--;
            }
        }
    }
}
