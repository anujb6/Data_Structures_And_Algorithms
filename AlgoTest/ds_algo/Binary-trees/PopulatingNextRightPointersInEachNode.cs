using AlgoTest.Models;
using AlgoTest.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgoTest.DataStructureAndAlgorithms.Binary_trees
{
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node(int _val, Node? _left=null, Node? _right=null, Node _next=null)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    public class PopulatingNextRightPointersInEachNode
    {
        public static Node Connect(Node root)
        {
            Dictionary<int, List<Node>> map = new();

            void Preorder(Node root, Dictionary<int, List<Node>> map, int level)
            {
                if(root == null)
                    return;

                if (map.ContainsKey(level))
                    map[level].Add(root);
                else
                    map.Add(level, new List<Node> { root });

                Preorder(root.left, map, level + 1);
                Preorder(root.right, map, level + 1);

            }

            Preorder(root, map, 0);

            foreach(var key in map.Keys)
            {
                for(int i=0; i < map[key].Count; i++)
                {
                    if (i == map[key].Count - 1)
                        map[key][i].next = null;
                    else
                        map[key][i].next = map[key][i+1];
                }
            }

            return root;
        }
    }
}
