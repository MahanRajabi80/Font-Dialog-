namespace Example_14_5
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
            this.btnFont = new System.Windows.Forms.Button();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(170, 156);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(106, 26);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "Change Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(25, 25);
            this.txtFont.Multiline = true;
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(251, 125);
            this.txtFont.TabIndex = 0;
            // 
            // fontDialog1
            // 
            this.fontDialog1.FontMustExist = true;
            this.fontDialog1.ShowColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ctrl+Shift+F";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 210);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFont);
            this.Controls.Add(this.btnFont);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Example 14-5 (Font Dialog)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
    }
}

