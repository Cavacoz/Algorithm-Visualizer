using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BubbleSortVisualization
{
    public partial class SearchAlgorithm : Form
    {

        private int[] barArray;

        private TreeNode treeRoot;

        private Random random = new Random();
        private readonly int windowPadding = 10;
        private readonly float gapRatio = 0.2f;

        private bool isFound = false;

        private int currentIndexLeft = -1;
        private int currentIndexRight = -1;
        private int indexFound = -1;

        public SearchAlgorithm(string algorithmName)
        {
            InitializeComponent();
            this.Text = algorithmName;
            if (algorithmName != "Binary Search") numericBars.Maximum = 31;
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            if (numericMax.Value < numericMin.Value)
            {
                MessageBox.Show("The Max number cannot be lower then the Min number!", "Invalid number.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GenerateValuesValues();
                this.DoubleBuffered = true;
                this.Paint += new PaintEventHandler(Algorithm_Paint);
                //Invalidate();
            }
        }
        private void GenerateValuesValues()
        {
            if (this.Text == "Binary Search")
            {
                isFound = false;
                barArray = new int[(int)numericBars.Value];
                for (int i = 0; i < barArray.Length; i++)
                {
                    barArray[i] = random.Next((int)numericMin.Value, (int)numericMax.Value);
                }
                // The array must be already sorted. We use the Array.Sort(); because we already demonstrated we could sort the Arrays before.
                Array.Sort(barArray);
            }
            else
            {
                isFound = false;
                treeRoot = null;
                int count = (int)numericBars.Value;
                int min = (int)numericMin.Value;
                int max = (int)numericMax.Value;

                if(max-min < count)
                {
                    MessageBox.Show("The difference between max number and min must be equal or higher than the number of nodes.", "Invalid number.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    List<int> values = new List<int>();

                    while (values.Count < count)
                    {
                        int randomValue = random.Next(min, max+1);
                        while (values.Contains(randomValue))
                            randomValue = random.Next(min, max+1);

                        values.Add(randomValue);
                    }

                    values.Sort();

                    // Build a balanced tree using the random values
                    treeRoot = BuildBalancedTree(values, 0, values.Count - 1);

                    AssignNodePositions(treeRoot, this.Width / 2, 50, 175);
                }
            }
            Invalidate();
        }

        private TreeNode BuildBalancedTree(List<int> values, int start, int end)
        {
            if (start > end) return null;

            int mid = (start + end) / 2;
            TreeNode node = new TreeNode(values[mid]);

            // Recursively build the left and right subtrees
            node.Left = BuildBalancedTree(values, start, mid - 1);
            node.Right = BuildBalancedTree(values, mid + 1, end);

            return node;
        }

        private void AssignNodePositions(TreeNode node, int x, int y, int xSpacing)
        {
            if (node == null) return;

            node.Position = new Point(x, y);
            AssignNodePositions(node.Left, x - xSpacing, y + 60, xSpacing / 2);
            AssignNodePositions(node.Right, x + xSpacing, y + 60, xSpacing / 2);
        }
        private void Algorithm_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            if(this.Text == "Binary Search")
            {
                int barCount = barArray.Length;
                float drawableWidth = Size.Width - 2 * windowPadding;
                float barWidth = drawableWidth / (barCount + (barCount - 1) * gapRatio);
                float gapWidth = barWidth * gapRatio;

                for (int i = 0; i < barArray.Length; i++)
                {
                    float x = 2 + i * (barWidth + gapWidth);
                    float y = 300 - barArray[i];
                    float height = barArray[i];

                    if (i == currentIndexLeft || i == currentIndexRight)
                        g.FillRectangle(Brushes.Red, x, y, barWidth, height);
                    else if (isFound && i == indexFound)
                        g.FillRectangle(Brushes.Green, x, y, barWidth, height);
                    else
                        g.FillRectangle(Brushes.Blue, x, y, barWidth, height);
                }
            }
            else
            {
                DrawTree(e.Graphics, treeRoot);
            }
        }
        private void DrawTree(Graphics g, TreeNode node)
        {
            if (node == null) return;

            var pen = Pens.Black;
            var brush = Brushes.LightBlue;
            var textBrush = Brushes.Black;
            var font = new Font("Arial", 10);

            if (node.Left != null)
            {
                g.DrawLine(pen, node.Position, node.Left.Position);
                DrawTree(g, node.Left);
            }

            if (node.Right != null)
            {
                g.DrawLine(pen, node.Position, node.Right.Position);
                DrawTree(g, node.Right);
            }

            var rect = new Rectangle(node.Position.X - 15, node.Position.Y - 15, 30, 30);
            g.FillEllipse(brush, rect);
            g.DrawEllipse(pen, rect);
            g.DrawString(node.Value.ToString(), font, textBrush, node.Position.X - 8, node.Position.Y - 8);
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            generateButton.Enabled = false;
            searchButton.Enabled = false;

            if (this.Text == "Binary Search")
            {
                await binarySearch();
            }
            else
            {
                await DepthFirstSearch();
            }

            generateButton.Enabled = true;
            searchButton.Enabled = true;
    }

        private async Task binarySearch()
        {
            indexFound = -1;
            currentIndexLeft = 0;
            currentIndexRight = barArray.Length - 1;

            while (currentIndexLeft <= currentIndexRight)
            {
                int mid = (currentIndexLeft + currentIndexRight) / 2;

                if (barArray[mid] == numberToSearch.Value)
                {
                    indexFound = mid;
                    isFound = true;
                    await Task.Delay(100);
                    Invalidate();
                    break;
                }

                if (numberToSearch.Value < barArray[mid])
                {
                    currentIndexRight = mid - 1;
                }
                else
                {
                    currentIndexLeft = mid + 1;
                }
                await Task.Delay(100);
                Invalidate();
            }
            currentIndexLeft = -1;
            currentIndexRight = -1;
        }

        private async Task DepthFirstSearch()
        {
            while(treeRoot.Left != null || treeRoot.Right != null)
            {
                if (treeRoot.Value == numberToSearch.Value)
                {
                    isFound = true;
                    break;
                }

                if(numberToSearch.Value < treeRoot.Value)
                {
                    treeRoot = treeRoot.Left;
                }
                else
                {
                    treeRoot = treeRoot.Right;
                }
                await Task.Delay(200);
                Invalidate();
            }
        }
    }
}
