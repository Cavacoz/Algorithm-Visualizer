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

namespace AlgorithmVisualizer
{
    public partial class SortAlgorithm : Form
    {

        private int[] barArray;
        private Random random = new Random();
        private readonly int windowPadding = 10;
        private readonly float gapRatio = 0.2f;

        private bool isSorted = false;

        private int currentIndexLeft = -1;
        private int currentIndexRight = -1;


        public SortAlgorithm(string algorithmName)
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
            isSorted = false;
            barArray = new int[(int)numericBars.Value];
            for (int i = 0; i < barArray.Length; i++)
            {
                barArray[i] = random.Next((int)numericMin.Value, (int)numericMax.Value);
            }
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

                if (this.Text == "Bubble Sort")
                {
                    if (i == currentIndexLeft || i == currentIndexRight)
                        g.FillRectangle(Brushes.Red, x, y, barWidth, height);
                    else if (isSorted)
                        g.FillRectangle(Brushes.Green, x, y, barWidth, height);
                    else
                        g.FillRectangle(Brushes.Blue, x, y, barWidth, height);

                    // make it paint green when its finished
                }
                if (this.Text == "Merge Sort")
                    if (i >= currentIndexLeft && i < currentIndexRight)
                        g.FillRectangle(Brushes.Red, x, y, barWidth, height);
                    else if (isSorted)
                        g.FillRectangle(Brushes.Green, x, y, barWidth, height);
                    else
                        g.FillRectangle(Brushes.Blue, x, y, barWidth, height);
            }
            Invalidate();
        }

        private async void sortButton_Click(object sender, EventArgs e)
        {
            generateButton.Enabled = false;
            sortButton.Enabled = false;

            if (this.Text == "Bubble Sort")
            {
                await bubbleSortMyArray();
            }
            else
            {
                mergeSortMyArray();
            }

            generateButton.Enabled = true;
            sortButton.Enabled = true;
        }

        private async Task bubbleSortMyArray()
        {
            int holdNumber;
            bool didSwitch;

            for (int i = 0; i < barArray.Length - 1; i++)
            {
                didSwitch = false;
                for (int j = 0; j < barArray.Length - 1; j++)
                {
                    if (barArray[j] > barArray[j + 1])
                    {
                        currentIndexLeft = j;
                        currentIndexRight = j + 1;
                        holdNumber = barArray[j];
                        barArray[j] = barArray[j + 1];
                        barArray[j + 1] = holdNumber;
                        didSwitch = true;
                        await Task.Delay(200);
                    }
                    Invalidate();
                }
                if (!didSwitch)
                {
                    isSorted = true;
                    break;
                }
            }
            currentIndexLeft = -1;
            currentIndexRight = -1;
        }
        private async void mergeSortMyArray()
        {
            barArray = await mergeSort(barArray, 0);
            isSorted = true;
            currentIndexLeft = -1;
            currentIndexRight = -1;
        }

        private async Task<int[]> mergeSort(int[] arrayToSort, int startingPaintIndex)
        {
            if (arrayToSort.Length == 1)
                return arrayToSort;

            int middlePoint = arrayToSort.Length / 2;

            int[] leftArray = new int[middlePoint];
            int[] rightArray = new int[arrayToSort.Length - middlePoint];

            Array.Copy(arrayToSort, 0, leftArray, 0, middlePoint);
            Array.Copy(arrayToSort, middlePoint, rightArray, 0, arrayToSort.Length - middlePoint);

            int[] sortedLeftArray = await mergeSort(leftArray, startingPaintIndex);
            int[] sortedRightArray = await mergeSort(rightArray, startingPaintIndex + middlePoint);
                        
            return await mergeArrays(sortedLeftArray, sortedRightArray, startingPaintIndex);
        }

        private async Task<int[]> mergeArrays(int[] leftArray, int[] rightArray, int startingPaintIndex)
        {
            int i = 0, j = 0;
            
            List<int> mergedArray = new List<int>();
            while ( i < leftArray.Length && j < rightArray.Length)
            { 
                if (leftArray[i] < rightArray[j])
                {
                    mergedArray.Add(leftArray[i]);
                    i++;
                }
                else
                {
                    mergedArray.Add(rightArray[j]);
                    j++;
                }
            }

            mergedArray.AddRange(leftArray.Skip(i));
            mergedArray.AddRange(rightArray.Skip(j));

            // this part needs to be fixed its correct but should be in the correct indexes of the original array.
            //int n = leftArray.Length + rightArray.Length;
            currentIndexLeft = startingPaintIndex;
            currentIndexRight = startingPaintIndex + mergedArray.Count;

            Array.Copy(mergedArray.ToArray<int>(), 0, barArray, startingPaintIndex, mergedArray.Count);
            await Task.Delay(200);
            Invalidate();

            return mergedArray.ToArray<int>();
        }
    }
}
