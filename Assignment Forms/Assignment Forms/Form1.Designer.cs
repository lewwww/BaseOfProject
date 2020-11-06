namespace Assignment_Forms
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
            this.ProgramWindow = new System.Windows.Forms.RichTextBox();
            this.DrawingBox = new System.Windows.Forms.PictureBox();
            this.OutputWindow = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgramWindow
            // 
            this.ProgramWindow.Location = new System.Drawing.Point(12, 390);
            this.ProgramWindow.Name = "ProgramWindow";
            this.ProgramWindow.Size = new System.Drawing.Size(388, 48);
            this.ProgramWindow.TabIndex = 0;
            this.ProgramWindow.Text = "";
            this.ProgramWindow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // DrawingBox
            // 
            this.DrawingBox.Location = new System.Drawing.Point(412, 12);
            this.DrawingBox.Name = "DrawingBox";
            this.DrawingBox.Size = new System.Drawing.Size(376, 426);
            this.DrawingBox.TabIndex = 1;
            this.DrawingBox.TabStop = false;
            this.DrawingBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingBox_Paint);
            // 
            // OutputWindow
            // 
            this.OutputWindow.Location = new System.Drawing.Point(12, 12);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(388, 372);
            this.OutputWindow.TabIndex = 2;
            this.OutputWindow.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputWindow);
            this.Controls.Add(this.DrawingBox);
            this.Controls.Add(this.ProgramWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrawingBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ProgramWindow;
        private System.Windows.Forms.PictureBox DrawingBox;
        private System.Windows.Forms.RichTextBox OutputWindow;
    }
}

