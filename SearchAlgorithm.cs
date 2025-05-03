using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSortVisualization
{
    public partial class SearchAlgorithm : Form
    {

        private int[] barArray;
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
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            if (numericMax.Value < numericMin.Value)
            {
                MessageBox.Show("The Max number cannot be lower then the Min number!", "Invalid number.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                GenerateArrayValues();
                this.DoubleBuffered = true;
                this.Paint += new PaintEventHandler(Algorithm_Paint);
            }
        }
        private void GenerateArrayValues()
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

        private void Algorithm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int barCount = barArray.Length;
            float drawableWidth = Size.Width - 2 * windowPadding;
            float barWidth = drawableWidth / (barCount + (barCount - 1) * gapRatio);
            float gapWidth = barWidth * gapRatio;

            for (int i = 0; i < barArray.Length; i++)
            {
                float x = 2 + i * (barWidth + gapWidth);
                float y = 300 - barArray[i];
                float height = barArray[i];

                if (this.Text == "Binary Search")
                {
                    if (i == currentIndexLeft || i == currentIndexRight)
                        g.FillRectangle(Brushes.Red, x, y, barWidth, height);
                    else if (isFound && i == indexFound)
                        g.FillRectangle(Brushes.Green, x, y, barWidth, height);
                    else
                        g.FillRectangle(Brushes.Blue, x, y, barWidth, height);
                }
                else
                {
                    if (i >= currentIndexLeft && i < currentIndexRight)
                        g.FillRectangle(Brushes.Red, x, y, barWidth, height);
                    else if (isFound)
                        g.FillRectangle(Brushes.Green, x, y, barWidth, height);
                    else
                        g.FillRectangle(Brushes.Blue, x, y, barWidth, height);
                }
            }
            Invalidate();
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
    }
}
