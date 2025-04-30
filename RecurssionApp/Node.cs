using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurssionApp
{
    public class Node
    {
        public string Id;
        public string ParentId;
        public Node(string id, string parentId)
        {
            Id = id;
            ParentId = parentId;
        }
    }
}
