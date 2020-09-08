namespace FixedDebugThree2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.helloButton = new System.Windows.Forms.Button();
            this.goodbyeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloButton
            // 
            this.helloButton.Location = new System.Drawing.Point(56, 150);
            this.helloButton.Margin = new System.Windows.Forms.Padding(4);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(100, 28);
            this.helloButton.TabIndex = 0;
            this.helloButton.Text = "Hello";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.Click += new System.EventHandler(this.HelloButton_Click);
            // 
            // goodbyeButton
            // 
            this.goodbyeButton.Location = new System.Drawing.Point(209, 150);
            this.goodbyeButton.Margin = new System.Windows.Forms.Padding(4);
            this.goodbyeButton.Name = "goodbyeButton";
            this.goodbyeButton.Size = new System.Drawing.Size(100, 28);
            this.goodbyeButton.TabIndex = 1;
            this.goodbyeButton.Text = "Goodbye";
            this.goodbyeButton.UseVisualStyleBackColor = true;
            this.goodbyeButton.Click += new System.EventHandler(this.GoodbyeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a button to see a Hello greeting\r\nor a Goodbye greeting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your name: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "JoJo";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(100, 225);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 17);
            this.outputLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goodbyeButton);
            this.Controls.Add(this.helloButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Two Greetings";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Button goodbyeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label outputLabel;
    }
}

