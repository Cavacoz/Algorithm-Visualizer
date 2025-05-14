using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortVisualization
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;
        public Point Position; // For visualization

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            Value = val;
            Left = left;
            Right = right;
        }
    }
}
