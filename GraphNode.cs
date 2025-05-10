using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortVisualization
{
    public class GraphNode
    {
        public string Label;
        public Point Position;
        public List<GraphNode> Neighbors = new List<GraphNode>();
    }
}
