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
            this.txtBox_Image_Query = new System.Windows.Forms.RichTextBox();
            this.tabControl_Images = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBox_Telephone_Results = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Telephone_Query = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtBox_Twitter_Results = new System.Windows.Forms.RichTextBox();
            this.txtBox_Twitter_Query = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtBox_FB_Query = new System.Windows.Forms.RichTextBox();
            this.txtBox_FB_Results = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
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
            this.tabPage2.Controls.Add(this.txtBox_Image_Query);
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
            // txtBox_Image_Query
            // 
            this.txtBox_Image_Query.Location = new System.Drawing.Point(0, 0);
            this.txtBox_Image_Query.Name = "txtBox_Image_Query";
            this.txtBox_Image_Query.Size = new System.Drawing.Size(667, 38);
            this.txtBox_Image_Query.TabIndex = 1;
            this.txtBox_Image_Query.Text = "";
            this.txtBox_Image_Query.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_Image_Query_KeyPress);
            // 
            // tabControl_Images
            // 
            this.tabControl_Images.Location = new System.Drawing.Point(0, 44);
            this.tabControl_Images.Name = "tabControl_Images";
            this.tabControl_Images.SelectedIndex = 0;
            this.tabControl_Images.Size = new System.Drawing.Size(667, 348);
            this.tabControl_Images.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtBox_Telephone_Results);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtBox_Telephone_Query);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Telephone lookup";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtBox_Telephone_Results
            // 
            this.txtBox_Telephone_Results.Location = new System.Drawing.Point(3, 40);
            this.txtBox_Telephone_Results.Name = "txtBox_Telephone_Results";
            this.txtBox_Telephone_Results.Size = new System.Drawing.Size(671, 353);
            this.txtBox_Telephone_Results.TabIndex = 7;
            this.txtBox_Telephone_Results.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telephone number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "0 results found";
            // 
            // txtBox_Telephone_Query
            // 
            this.txtBox_Telephone_Query.Location = new System.Drawing.Point(118, 0);
            this.txtBox_Telephone_Query.Name = "txtBox_Telephone_Query";
            this.txtBox_Telephone_Query.Size = new System.Drawing.Size(556, 38);
            this.txtBox_Telephone_Query.TabIndex = 4;
            this.txtBox_Telephone_Query.Text = "";
            this.txtBox_Telephone_Query.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBox_Telephone_Query_KeyPress);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtBox_Twitter_Results);
            this.tabPage4.Controls.Add(this.txtBox_Twitter_Query);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 398);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Twitter search";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtBox_Twitter_Results
            // 
            this.txtBox_Twitter_Results.Location = new System.Drawing.Point(0, 40);
            this.txtBox_Twitter_Results.Name = "txtBox_Twitter_Results";
            this.txtBox_Twitter_Results.Size = new System.Drawing.Size(772, 358);
            this.txtBox_Twitter_Results.TabIndex = 1;
            this.txtBox_Twitter_Results.Text = "";
            // 
            // txtBox_Twitter_Query
            // 
            this.txtBox_Twitter_Query.Location = new System.Drawing.Point(0, 0);
            this.txtBox_Twitter_Query.Name = "txtBox_Twitter_Query";
            this.txtBox_Twitter_Query.Size = new System.Drawing.Size(772, 43);
            this.txtBox_Twitter_Query.TabIndex = 0;
            this.txtBox_Twitter_Query.Text = "";
            this.txtBox_Twitter_Query.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Twitter_Query_KeyPress);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtBox_FB_Results);
            this.tabPage5.Controls.Add(this.txtBox_FB_Query);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(768, 398);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Facebook search";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtBox_FB_Query
            // 
            this.txtBox_FB_Query.Location = new System.Drawing.Point(0, 0);
            this.txtBox_FB_Query.Name = "txtBox_FB_Query";
            this.txtBox_FB_Query.Size = new System.Drawing.Size(768, 44);
            this.txtBox_FB_Query.TabIndex = 0;
            this.txtBox_FB_Query.Text = "";
            this.txtBox_FB_Query.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_FB_Query_KeyPress);
            // 
            // txtBox_FB_Results
            // 
            this.txtBox_FB_Results.Location = new System.Drawing.Point(3, 50);
            this.txtBox_FB_Results.Name = "txtBox_FB_Results";
            this.txtBox_FB_Results.Size = new System.Drawing.Size(762, 345);
            this.txtBox_FB_Results.TabIndex = 1;
            this.txtBox_FB_Results.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Inquisitor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
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
        private RichTextBox txtBox_Image_Query;
        private TabPage tabPage3;
        private Label label1;
        private RichTextBox txtBox_Telephone_Query;
        private Label label2;
        private RichTextBox txtBox_Telephone_Results;
        private TabPage tabPage4;
        private RichTextBox txtBox_Twitter_Query;
        private RichTextBox txtBox_Twitter_Results;
        private TabPage tabPage5;
        private RichTextBox txtBox_FB_Results;
        private RichTextBox txtBox_FB_Query;
    }
}