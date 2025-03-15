namespace Zad3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelCpu = new Label();
            labelMemory = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            labelCpu.AutoSize = true;
            labelCpu.Location = new Point(12, 9);
            labelCpu.Name = "label1";
            labelCpu.Size = new Size(38, 15);
            labelCpu.TabIndex = 3;
            labelCpu.Text = "label1";
            // 
            // label2
            // 
            labelMemory.AutoSize = true;
            labelMemory.Location = new Point(12, 39);
            labelMemory.Name = "label2";
            labelMemory.Size = new Size(38, 15);
            labelMemory.TabIndex = 4;
            labelMemory.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 66);
            Controls.Add(labelMemory);
            Controls.Add(labelCpu);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelCpu;
        private Label labelMemory;
    }
}
