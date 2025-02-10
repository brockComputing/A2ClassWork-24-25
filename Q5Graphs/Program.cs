using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5Graphs
{
    internal class Program
    {
        class Node
        {
            public List<int> connectednodes;
            public Node(List<int> theConnected)
            {
                connectednodes = theConnected;
            }
        }
        static List<Node> theGraph = new List<Node>();
        static List<bool> visited = new List<bool>() { false, false, false, false };
        private static void ConnectNodes()
        {
            theGraph.Add(new Node(new List<int>() { 1, 2, 3 }));
            theGraph.Add(new Node(new List<int>() { 0, 3 }));
            theGraph.Add(new Node(new List<int>() { 0 }));
            theGraph.Add(new Node(new List<int>() { 0, 1 }));
        }
        static bool G(int v, int p)
        {
            visited[v] = true;
            foreach (var n in theGraph[v].connectednodes)
            {
                if (visited[n] == false)
                {
                    if (G(n, v) == true)
                    {
                        return true;
                    }
                }
                else if (n != p)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            ConnectNodes();
            if (G(0, -1))
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
            Console.ReadLine();
        }

    }
}
