namespace WindowsFormsApplication1
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
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(11, 47);
            this.richTextBoxInput.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(796, 161);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(11, 235);
            this.richTextBoxOutput.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(796, 161);
            this.richTextBoxOutput.TabIndex = 1;
            this.richTextBoxOutput.Text = "";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(12, 12);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFileName.TabIndex = 2;
            this.textBoxFileName.Text = "index.html";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(814, 407);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxInput);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Lab1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.TextBox textBoxFileName;
    }
}

