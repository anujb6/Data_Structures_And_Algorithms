using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Trie
{
    public class Trie
    {
        private readonly TrieNode root;

        public Trie()
        {
            root = new();
        }

        public void Insert(string word)
        {
            var node = root;
            foreach(char c in word)
            {
                if(!node.Children.ContainsKey(c))
                    node.Children.Add(c, new TrieNode());

                node = node.Children[c];
            }

            node.IsWord = true;
        }

        public bool Search(string word)
        {
            var node = root;
            foreach(char c in word)
            {
                if (!node.Children.ContainsKey(c))
                    return false;

                node = node.Children[c];
            }

            return node.IsWord;
        }

        public bool StartsWith(string prefix)
        {
            var node = root;
            foreach(char c in prefix)
            {
                if (!node.Children.ContainsKey(c))
                    return false;

                node = node.Children[c];
            }

            return true;
        }
    }
}
