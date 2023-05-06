namespace INQ.Inquisitor.WinForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBox_News_Query = new System.Windows.Forms.RichTextBox();
            this.txtBox_News_Results = new System.Windows.Forms.RichTextBox();
            this.lbl_News_ResultAmount = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_News_ResultAmount);
            this.tabPage1.Controls.Add(this.txtBox_News_Results);
            this.tabPage1.Controls.Add(this.txtBox_News_Query);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "News search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBox_News_Query
            // 
            this.txtBox_News_Query.Location = new System.Drawing.Point(0, 0);
            this.txtBox_News_Query.Name = "txtBox_News_Query";
            this.txtBox_News_Query.Size = new System.Drawing.Size(667, 38);
            this.txtBox_News_Query.TabIndex = 0;
            this.txtBox_News_Query.Text = "";
            this.txtBox_News_Query.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_News_Query_KeyPress);
            // 
            // txtBox_News_Results
            // 
            this.txtBox_News_Results.Location = new System.Drawing.Point(0, 44);
            this.txtBox_News_Results.Name = "txtBox_News_Results";
            this.txtBox_News_Results.Size = new System.Drawing.Size(667, 358);
            this.txtBox_News_Results.TabIndex = 1;
            this.txtBox_News_Results.Text = "";
            // 
            // lbl_News_ResultAmount
            // 
            this.lbl_News_ResultAmount.AutoSize = true;
            this.lbl_News_ResultAmount.Location = new System.Drawing.Point(690, 380);
            this.lbl_News_ResultAmount.Name = "lbl_News_ResultAmount";
            this.lbl_News_ResultAmount.Size = new System.Drawing.Size(50, 15);
            this.lbl_News_ResultAmount.TabIndex = 2;
            this.lbl_News_ResultAmount.Text = "0 results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lbl_News_ResultAmount;
        private RichTextBox txtBox_News_Results;
        private RichTextBox txtBox_News_Query;
    }
}