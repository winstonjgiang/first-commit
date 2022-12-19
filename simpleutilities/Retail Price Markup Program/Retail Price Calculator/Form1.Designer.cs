namespace Retail_Price_Calculator
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.itemCostLabel = new System.Windows.Forms.Label();
            this.itemCostTextBox = new System.Windows.Forms.TextBox();
            this.markupLabel = new System.Windows.Forms.Label();
            this.markupTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.retailPriceLabel = new System.Windows.Forms.Label();
            this.totalRetailPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(60, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(111, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Retail Price Calculator";
            // 
            // itemCostLabel
            // 
            this.itemCostLabel.AutoSize = true;
            this.itemCostLabel.Location = new System.Drawing.Point(12, 53);
            this.itemCostLabel.Name = "itemCostLabel";
            this.itemCostLabel.Size = new System.Drawing.Size(112, 13);
            this.itemCostLabel.TabIndex = 1;
            this.itemCostLabel.Text = "Enter Wholesale Cost:";
            // 
            // itemCostTextBox
            // 
            this.itemCostTextBox.Location = new System.Drawing.Point(130, 50);
            this.itemCostTextBox.Name = "itemCostTextBox";
            this.itemCostTextBox.Size = new System.Drawing.Size(89, 20);
            this.itemCostTextBox.TabIndex = 2;
            this.itemCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // markupLabel
            // 
            this.markupLabel.AutoSize = true;
            this.markupLabel.Location = new System.Drawing.Point(2, 83);
            this.markupLabel.Name = "markupLabel";
            this.markupLabel.Size = new System.Drawing.Size(132, 13);
            this.markupLabel.TabIndex = 3;
            this.markupLabel.Text = "Enter Markup Percentage:";
            // 
            // markupTextBox
            // 
            this.markupTextBox.Location = new System.Drawing.Point(140, 80);
            this.markupTextBox.Name = "markupTextBox";
            this.markupTextBox.Size = new System.Drawing.Size(79, 20);
            this.markupTextBox.TabIndex = 4;
            this.markupTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(15, 152);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(66, 47);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(88, 152);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 47);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(160, 152);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 47);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // retailPriceLabel
            // 
            this.retailPriceLabel.AutoSize = true;
            this.retailPriceLabel.Location = new System.Drawing.Point(85, 110);
            this.retailPriceLabel.Name = "retailPriceLabel";
            this.retailPriceLabel.Size = new System.Drawing.Size(61, 13);
            this.retailPriceLabel.TabIndex = 9;
            this.retailPriceLabel.Text = "Retail Price";
            // 
            // totalRetailPriceLabel
            // 
            this.totalRetailPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRetailPriceLabel.Location = new System.Drawing.Point(71, 123);
            this.totalRetailPriceLabel.Name = "totalRetailPriceLabel";
            this.totalRetailPriceLabel.Size = new System.Drawing.Size(83, 26);
            this.totalRetailPriceLabel.TabIndex = 10;
            this.totalRetailPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 211);
            this.Controls.Add(this.totalRetailPriceLabel);
            this.Controls.Add(this.retailPriceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.markupTextBox);
            this.Controls.Add(this.markupLabel);
            this.Controls.Add(this.itemCostTextBox);
            this.Controls.Add(this.itemCostLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label itemCostLabel;
        private System.Windows.Forms.TextBox itemCostTextBox;
        private System.Windows.Forms.Label markupLabel;
        private System.Windows.Forms.TextBox markupTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label retailPriceLabel;
        private System.Windows.Forms.Label totalRetailPriceLabel;
    }
}

