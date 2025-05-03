namespace BubbleSortVisualization
{
    partial class SearchAlgorithm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.numericBars = new System.Windows.Forms.NumericUpDown();
            this.numericMax = new System.Windows.Forms.NumericUpDown();
            this.numericMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numberToSearch = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericBars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberToSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "# of bars";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Max #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Min #";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(634, 352);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(553, 352);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 12;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // numericBars
            // 
            this.numericBars.Location = new System.Drawing.Point(300, 355);
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
            this.numericBars.TabIndex = 11;
            this.numericBars.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericMax
            // 
            this.numericMax.Location = new System.Drawing.Point(151, 355);
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
            this.numericMax.TabIndex = 10;
            this.numericMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericMin
            // 
            this.numericMin.Location = new System.Drawing.Point(94, 355);
            this.numericMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericMin.Name = "numericMin";
            this.numericMin.Size = new System.Drawing.Size(40, 20);
            this.numericMin.TabIndex = 9;
            this.numericMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "To find";
            // 
            // numberToSearch
            // 
            this.numberToSearch.Location = new System.Drawing.Point(403, 355);
            this.numberToSearch.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numberToSearch.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberToSearch.Name = "numberToSearch";
            this.numberToSearch.Size = new System.Drawing.Size(40, 20);
            this.numberToSearch.TabIndex = 18;
            this.numberToSearch.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SearchAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.numberToSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.numericBars);
            this.Controls.Add(this.numericMax);
            this.Controls.Add(this.numericMin);
            this.Name = "SearchAlgorithm";
            this.Text = "SearchAlgorithm";
            ((System.ComponentModel.ISupportInitialize)(this.numericBars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberToSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.NumericUpDown numericBars;
        private System.Windows.Forms.NumericUpDown numericMax;
        private System.Windows.Forms.NumericUpDown numericMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberToSearch;
    }
}