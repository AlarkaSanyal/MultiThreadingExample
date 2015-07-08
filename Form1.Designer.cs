namespace MultiThreadingExample
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
            this.Numbers = new System.Windows.Forms.ListBox();
            this.timeConsumingButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numbers
            // 
            this.Numbers.FormattingEnabled = true;
            this.Numbers.ItemHeight = 16;
            this.Numbers.Location = new System.Drawing.Point(46, 109);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(194, 132);
            this.Numbers.TabIndex = 0;
            //this.Numbers.SelectedIndexChanged += new System.EventHandler(this.Numbers_SelectedIndexChanged);
            // 
            // timeConsumingButton
            // 
            this.timeConsumingButton.Location = new System.Drawing.Point(45, 16);
            this.timeConsumingButton.Name = "timeConsumingButton";
            this.timeConsumingButton.Size = new System.Drawing.Size(195, 35);
            this.timeConsumingButton.TabIndex = 1;
            this.timeConsumingButton.Text = "TimeConsuming";
            this.timeConsumingButton.UseVisualStyleBackColor = true;
            this.timeConsumingButton.Click += new System.EventHandler(this.timeConsumingButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(46, 57);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(193, 35);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.timeConsumingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Numbers;
        private System.Windows.Forms.Button timeConsumingButton;
        private System.Windows.Forms.Button printButton;
    }
}

