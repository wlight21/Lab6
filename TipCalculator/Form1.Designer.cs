namespace TipCalculator
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
            this.tipButton = new System.Windows.Forms.Button();
            this.billLabel = new System.Windows.Forms.Label();
            this.billBox = new System.Windows.Forms.TextBox();
            this.tipBox = new System.Windows.Forms.TextBox();
            this.tipPercentageLabel = new System.Windows.Forms.Label();
            this.tipPercentageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tipButton
            // 
            this.tipButton.Location = new System.Drawing.Point(111, 175);
            this.tipButton.Name = "tipButton";
            this.tipButton.Size = new System.Drawing.Size(104, 23);
            this.tipButton.TabIndex = 0;
            this.tipButton.Text = "Calculate Tip";
            this.tipButton.UseVisualStyleBackColor = true;
            this.tipButton.Click += new System.EventHandler(this.tipButton_Click);
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Location = new System.Drawing.Point(108, 76);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(66, 17);
            this.billLabel.TabIndex = 1;
            this.billLabel.Text = "Total Bill:";
            // 
            // billBox
            // 
            this.billBox.Location = new System.Drawing.Point(235, 76);
            this.billBox.Name = "billBox";
            this.billBox.Size = new System.Drawing.Size(100, 22);
            this.billBox.TabIndex = 2;
            this.billBox.TextChanged += new System.EventHandler(this.billBox_TextChanged);
            // 
            // tipBox
            // 
            this.tipBox.Location = new System.Drawing.Point(235, 176);
            this.tipBox.Name = "tipBox";
            this.tipBox.Size = new System.Drawing.Size(100, 22);
            this.tipBox.TabIndex = 3;
            // 
            // tipPercentageLabel
            // 
            this.tipPercentageLabel.AutoSize = true;
            this.tipPercentageLabel.Location = new System.Drawing.Point(111, 128);
            this.tipPercentageLabel.Name = "tipPercentageLabel";
            this.tipPercentageLabel.Size = new System.Drawing.Size(48, 17);
            this.tipPercentageLabel.TabIndex = 4;
            this.tipPercentageLabel.Text = "Tip %:";
            // 
            // tipPercentageBox
            // 
            this.tipPercentageBox.Location = new System.Drawing.Point(235, 128);
            this.tipPercentageBox.Name = "tipPercentageBox";
            this.tipPercentageBox.Size = new System.Drawing.Size(100, 22);
            this.tipPercentageBox.TabIndex = 5;
            this.tipPercentageBox.TextChanged += new System.EventHandler(this.tipPercentageBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 318);
            this.Controls.Add(this.tipPercentageBox);
            this.Controls.Add(this.tipPercentageLabel);
            this.Controls.Add(this.tipBox);
            this.Controls.Add(this.billBox);
            this.Controls.Add(this.billLabel);
            this.Controls.Add(this.tipButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tipButton;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.TextBox billBox;
        private System.Windows.Forms.TextBox tipBox;
        private System.Windows.Forms.Label tipPercentageLabel;
        private System.Windows.Forms.TextBox tipPercentageBox;
    }
}

