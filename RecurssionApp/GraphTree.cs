using System;
using System.Collections.Generic;
using System.Linq;

namespace RecurssionApp
{
    public class GraphTree
    {
        public IReadOnlyList<Node> Nodes { get; }

        public GraphTree(IReadOnlyList<Node> nodes)
        {
            Nodes = nodes ?? throw new ArgumentNullException(nameof(nodes));
        }

        public int MaxDepth()
        {
            var roots = Nodes.Where(n => string.IsNullOrEmpty(n.ParentId)).ToList();
            var initialRootDepth = 0;

            if (roots.Count == 0) 
                throw new InvalidOperationException("No roots found in the graph.");

            return roots.Max(root => GetDepth(root, initialRootDepth));
        }

        private int GetDepth(Node node, int currentDepth)
        {
            var children = Nodes.Where(n => n.ParentId == node.Id).ToList();

            if (children.Count == 0)
                return currentDepth;

            return children.Max(child => GetDepth(child, currentDepth + 1));
        }
    }
}
