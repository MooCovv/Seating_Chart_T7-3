namespace Seating_Chart_T7_3
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
            this.rowTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.TextBox();
            this.displayPriceButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rowTextBox
            // 
            this.rowTextBox.Location = new System.Drawing.Point(100, 19);
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.Size = new System.Drawing.Size(100, 20);
            this.rowTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a Row:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter a Column:";
            // 
            // colTextBox
            // 
            this.colTextBox.Location = new System.Drawing.Point(100, 59);
            this.colTextBox.Name = "colTextBox";
            this.colTextBox.Size = new System.Drawing.Size(100, 20);
            this.colTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seat Price:";
            // 
            // priceLabel
            // 
            this.priceLabel.Enabled = false;
            this.priceLabel.Location = new System.Drawing.Point(297, 39);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(100, 20);
            this.priceLabel.TabIndex = 5;
            // 
            // displayPriceButton
            // 
            this.displayPriceButton.Location = new System.Drawing.Point(100, 110);
            this.displayPriceButton.Name = "displayPriceButton";
            this.displayPriceButton.Size = new System.Drawing.Size(75, 43);
            this.displayPriceButton.TabIndex = 6;
            this.displayPriceButton.Text = "Display Price";
            this.displayPriceButton.UseVisualStyleBackColor = true;
            this.displayPriceButton.Click += new System.EventHandler(this.displayPriceButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(235, 110);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 43);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 174);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayPriceButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rowTextBox);
            this.Name = "Form1";
            this.Text = "Seating Chart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rowTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox colTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceLabel;
        private System.Windows.Forms.Button displayPriceButton;
        private System.Windows.Forms.Button exitButton;
    }
}

