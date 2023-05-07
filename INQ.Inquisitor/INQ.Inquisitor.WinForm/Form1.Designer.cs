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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBtn_Headlines = new System.Windows.Forms.RadioButton();
            this.rBtn_News_Articles = new System.Windows.Forms.RadioButton();
            this.lbl_News_ResultFilteredAmount = new System.Windows.Forms.Label();
            this.lbl_News_ResultFoundAmount = new System.Windows.Forms.Label();
            this.txtBox_News_Results = new System.Windows.Forms.RichTextBox();
            this.txtBox_News_Query = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_Images_Amount = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl_Images = new System.Windows.Forms.TabControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lbl_News_ResultFilteredAmount);
            this.tabPage1.Controls.Add(this.lbl_News_ResultFoundAmount);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtn_Headlines);
            this.panel1.Controls.Add(this.rBtn_News_Articles);
            this.panel1.Location = new System.Drawing.Point(672, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 47);
            this.panel1.TabIndex = 6;
            // 
            // rBtn_Headlines
            // 
            this.rBtn_Headlines.AutoSize = true;
            this.rBtn_Headlines.Location = new System.Drawing.Point(3, 3);
            this.rBtn_Headlines.Name = "rBtn_Headlines";
            this.rBtn_Headlines.Size = new System.Drawing.Size(77, 19);
            this.rBtn_Headlines.TabIndex = 5;
            this.rBtn_Headlines.TabStop = true;
            this.rBtn_Headlines.Text = "Headlines";
            this.rBtn_Headlines.UseVisualStyleBackColor = true;
            // 
            // rBtn_News_Articles
            // 
            this.rBtn_News_Articles.AutoSize = true;
            this.rBtn_News_Articles.Location = new System.Drawing.Point(3, 22);
            this.rBtn_News_Articles.Name = "rBtn_News_Articles";
            this.rBtn_News_Articles.Size = new System.Drawing.Size(64, 19);
            this.rBtn_News_Articles.TabIndex = 4;
            this.rBtn_News_Articles.TabStop = true;
            this.rBtn_News_Articles.Text = "Articles";
            this.rBtn_News_Articles.UseVisualStyleBackColor = true;
            // 
            // lbl_News_ResultFilteredAmount
            // 
            this.lbl_News_ResultFilteredAmount.AutoSize = true;
            this.lbl_News_ResultFilteredAmount.Location = new System.Drawing.Point(672, 380);
            this.lbl_News_ResultFilteredAmount.Name = "lbl_News_ResultFilteredAmount";
            this.lbl_News_ResultFilteredAmount.Size = new System.Drawing.Size(90, 15);
            this.lbl_News_ResultFilteredAmount.TabIndex = 3;
            this.lbl_News_ResultFilteredAmount.Text = "0 results filtered";
            // 
            // lbl_News_ResultFoundAmount
            // 
            this.lbl_News_ResultFoundAmount.AutoSize = true;
            this.lbl_News_ResultFoundAmount.Location = new System.Drawing.Point(672, 365);
            this.lbl_News_ResultFoundAmount.Name = "lbl_News_ResultFoundAmount";
            this.lbl_News_ResultFoundAmount.Size = new System.Drawing.Size(85, 15);
            this.lbl_News_ResultFoundAmount.TabIndex = 2;
            this.lbl_News_ResultFoundAmount.Text = "0 results found";
            // 
            // txtBox_News_Results
            // 
            this.txtBox_News_Results.Location = new System.Drawing.Point(0, 44);
            this.txtBox_News_Results.Name = "txtBox_News_Results";
            this.txtBox_News_Results.Size = new System.Drawing.Size(667, 358);
            this.txtBox_News_Results.TabIndex = 1;
            this.txtBox_News_Results.Text = "";
            // 
            // txtBox_News_Query
            // 
            this.txtBox_News_Query.Location = new System.Drawing.Point(0, 0);
            this.txtBox_News_Query.Name = "txtBox_News_Query";
            this.txtBox_News_Query.Size = new System.Drawing.Size(667, 38);
            this.txtBox_News_Query.TabIndex = 0;
            this.txtBox_News_Query.Text = "";
            this.txtBox_News_Query.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_News_Query_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_Images_Amount);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.tabControl_Images);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_Images_Amount
            // 
            this.lbl_Images_Amount.AutoSize = true;
            this.lbl_Images_Amount.Location = new System.Drawing.Point(669, 375);
            this.lbl_Images_Amount.Name = "lbl_Images_Amount";
            this.lbl_Images_Amount.Size = new System.Drawing.Size(85, 15);
            this.lbl_Images_Amount.TabIndex = 2;
            this.lbl_Images_Amount.Text = "0 results found";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(667, 38);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RichTextBox1_KeyPressAsync);
            // 
            // tabControl_Images
            // 
            this.tabControl_Images.Location = new System.Drawing.Point(6, 52);
            this.tabControl_Images.Name = "tabControl_Images";
            this.tabControl_Images.SelectedIndex = 0;
            this.tabControl_Images.Size = new System.Drawing.Size(661, 340);
            this.tabControl_Images.TabIndex = 0;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lbl_News_ResultFoundAmount;
        private RichTextBox txtBox_News_Results;
        private RichTextBox txtBox_News_Query;
        private Label lbl_News_ResultFilteredAmount;
        private Panel panel1;
        private RadioButton rBtn_Headlines;
        private RadioButton rBtn_News_Articles;
        private TabControl tabControl_Images;
        private Label lbl_Images_Amount;
        private RichTextBox richTextBox1;
    }
}