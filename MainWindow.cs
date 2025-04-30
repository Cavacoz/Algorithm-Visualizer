using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmVisualizer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            SortAlgorithm algorithmWindow = new SortAlgorithm(listBox1.SelectedItem as string);
            algorithmWindow.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    listBox1.Items.AddRange(new string[] { "Bubble Sort", "Merge Sort" });
                    break;
                case 1:
                    listBox1.Items.AddRange(new string[] { "Binary Search" });
                    break;
                case 2:
                    listBox1.Items.AddRange(new string[] { "A*" });
                    break;
                default:
                    break;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectButton.Enabled = true;
        }
    }
}