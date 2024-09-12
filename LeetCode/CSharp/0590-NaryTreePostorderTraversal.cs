using LeetCode.CSharp.Shared;
using LeetCode.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class Solution0590 : IRunProgram
    {
        public void Run()
        {
            
        }
        public IList<int> Postorder(Node root)
        {
            var output = new List<int>();

            Helper(root, output);

            return output;
        }

        private void Helper(Node root, List<int> output)
        {
            if (root is null)
            {
                return;
            }

            foreach (var child in root.children)
            {
                Helper(child, output);
            }

            output.Add(root.val);
        }
    }
}
