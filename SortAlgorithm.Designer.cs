namespace AlgorithmVisualizer
{
    partial class SortAlgorithm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericMin = new System.Windows.Forms.NumericUpDown();
            this.numericMax = new System.Windows.Forms.NumericUpDown();
            this.numericBars = new System.Windows.Forms.NumericUpDown();
            this.generateButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBars)).BeginInit();
            this.SuspendLayout();
            // 
            // numericMin
            // 
            this.numericMin.Location = new System.Drawing.Point(90, 356);
            this.numericMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMin.Name = "numericMin";
            this.numericMin.Size = new System.Drawing.Size(40, 20);
            this.numericMin.TabIndex = 0;
            this.numericMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericMax
            // 
            this.numericMax.Location = new System.Drawing.Point(147, 356);
            this.numericMax.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMax.Name = "numericMax";
            this.numericMax.Size = new System.Drawing.Size(40, 20);
            this.numericMax.TabIndex = 1;
            this.numericMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericBars
            // 
            this.numericBars.Location = new System.Drawing.Point(343, 356);
            this.numericBars.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericBars.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericBars.Name = "numericBars";
            this.numericBars.Size = new System.Drawing.Size(40, 20);
            this.numericBars.TabIndex = 2;
            this.numericBars.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(549, 353);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(630, 353);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "# of bars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Max #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Min #";
            // 
            // SortAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.numericBars);
            this.Controls.Add(this.numericMax);
            this.Controls.Add(this.numericMin);
            this.Name = "SortAlgorithm";
            this.Text = "Algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericMin;
        private System.Windows.Forms.NumericUpDown numericMax;
        private System.Windows.Forms.NumericUpDown numericBars;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}