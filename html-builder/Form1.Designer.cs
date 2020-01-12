namespace html_builder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreatePage = new System.Windows.Forms.Button();
            this.txtFamilyIntro = new Zoople.HTMLEditControl();
            this.txtPageWidth = new System.Windows.Forms.TextBox();
            this.gbTop = new System.Windows.Forms.GroupBox();
            this.txtBannerT = new System.Windows.Forms.TextBox();
            this.rbCodeT = new System.Windows.Forms.RadioButton();
            this.rbImageT = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBannerM = new System.Windows.Forms.TextBox();
            this.rbCodeM = new System.Windows.Forms.RadioButton();
            this.rbImageM = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBannerB = new System.Windows.Forms.TextBox();
            this.rbCodeB = new System.Windows.Forms.RadioButton();
            this.rbImageB = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBannerL = new System.Windows.Forms.TextBox();
            this.rbCodeL = new System.Windows.Forms.RadioButton();
            this.rbImageL = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBannerR = new System.Windows.Forms.TextBox();
            this.rbCodeR = new System.Windows.Forms.RadioButton();
            this.rbImageR = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.gbTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Family Name";
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Location = new System.Drawing.Point(107, 18);
            this.txtFamilyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(520, 22);
            this.txtFamilyName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 1475);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Family Introduction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Page Width";
            // 
            // btnCreatePage
            // 
            this.btnCreatePage.Location = new System.Drawing.Point(936, 13);
            this.btnCreatePage.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreatePage.Name = "btnCreatePage";
            this.btnCreatePage.Size = new System.Drawing.Size(100, 28);
            this.btnCreatePage.TabIndex = 9;
            this.btnCreatePage.Text = "&Create Page";
            this.btnCreatePage.UseVisualStyleBackColor = true;
            this.btnCreatePage.Click += new System.EventHandler(this.btnCreatePage_Click);
            // 
            // txtFamilyIntro
            // 
            this.txtFamilyIntro.BaseURL = null;
            this.txtFamilyIntro.CleanMSWordHTMLOnPaste = true;
            this.txtFamilyIntro.CSSText = null;
            this.txtFamilyIntro.DocumentHTML = null;
            this.txtFamilyIntro.FontsList = null;
            this.txtFamilyIntro.HiddenButtons = null;
            this.txtFamilyIntro.ImageStorageLocation = null;
            this.txtFamilyIntro.InCodeView = false;
            this.txtFamilyIntro.LanguageFile = null;
            this.txtFamilyIntro.LicenceKey = null;
            this.txtFamilyIntro.Location = new System.Drawing.Point(335, 72);
            this.txtFamilyIntro.Margin = new System.Windows.Forms.Padding(5);
            this.txtFamilyIntro.Name = "txtFamilyIntro";
            this.txtFamilyIntro.Size = new System.Drawing.Size(842, 577);
            this.txtFamilyIntro.TabIndex = 10;
            this.txtFamilyIntro.ToolstripImageScalingSize = new System.Drawing.Size(16, 16);
            this.txtFamilyIntro.UseParagraphAsDefault = true;
            // 
            // txtPageWidth
            // 
            this.txtPageWidth.Location = new System.Drawing.Point(742, 18);
            this.txtPageWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtPageWidth.Name = "txtPageWidth";
            this.txtPageWidth.Size = new System.Drawing.Size(74, 22);
            this.txtPageWidth.TabIndex = 1;
            this.txtPageWidth.Text = "700";
            this.txtPageWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPageWidth_KeyPress);
            // 
            // gbTop
            // 
            this.gbTop.Controls.Add(this.txtBannerT);
            this.gbTop.Controls.Add(this.rbCodeT);
            this.gbTop.Controls.Add(this.rbImageT);
            this.gbTop.Location = new System.Drawing.Point(14, 51);
            this.gbTop.Name = "gbTop";
            this.gbTop.Size = new System.Drawing.Size(313, 100);
            this.gbTop.TabIndex = 3;
            this.gbTop.TabStop = false;
            this.gbTop.Text = "Top Placeholder";
            // 
            // txtBannerT
            // 
            this.txtBannerT.Location = new System.Drawing.Point(16, 49);
            this.txtBannerT.Multiline = true;
            this.txtBannerT.Name = "txtBannerT";
            this.txtBannerT.Size = new System.Drawing.Size(229, 43);
            this.txtBannerT.TabIndex = 2;
            // 
            // rbCodeT
            // 
            this.rbCodeT.AutoSize = true;
            this.rbCodeT.Location = new System.Drawing.Point(93, 21);
            this.rbCodeT.Name = "rbCodeT";
            this.rbCodeT.Size = new System.Drawing.Size(59, 20);
            this.rbCodeT.TabIndex = 1;
            this.rbCodeT.TabStop = true;
            this.rbCodeT.Text = "Code";
            this.rbCodeT.UseVisualStyleBackColor = true;
            // 
            // rbImageT
            // 
            this.rbImageT.AutoSize = true;
            this.rbImageT.Location = new System.Drawing.Point(16, 22);
            this.rbImageT.Name = "rbImageT";
            this.rbImageT.Size = new System.Drawing.Size(64, 20);
            this.rbImageT.TabIndex = 0;
            this.rbImageT.TabStop = true;
            this.rbImageT.Text = "Image";
            this.rbImageT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBannerM);
            this.groupBox1.Controls.Add(this.rbCodeM);
            this.groupBox1.Controls.Add(this.rbImageM);
            this.groupBox1.Location = new System.Drawing.Point(14, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Middle Placeholder";
            // 
            // txtBannerM
            // 
            this.txtBannerM.Location = new System.Drawing.Point(16, 49);
            this.txtBannerM.Multiline = true;
            this.txtBannerM.Name = "txtBannerM";
            this.txtBannerM.Size = new System.Drawing.Size(229, 43);
            this.txtBannerM.TabIndex = 2;
            // 
            // rbCodeM
            // 
            this.rbCodeM.AutoSize = true;
            this.rbCodeM.Location = new System.Drawing.Point(93, 21);
            this.rbCodeM.Name = "rbCodeM";
            this.rbCodeM.Size = new System.Drawing.Size(59, 20);
            this.rbCodeM.TabIndex = 1;
            this.rbCodeM.TabStop = true;
            this.rbCodeM.Text = "Code";
            this.rbCodeM.UseVisualStyleBackColor = true;
            // 
            // rbImageM
            // 
            this.rbImageM.AutoSize = true;
            this.rbImageM.Location = new System.Drawing.Point(16, 22);
            this.rbImageM.Name = "rbImageM";
            this.rbImageM.Size = new System.Drawing.Size(64, 20);
            this.rbImageM.TabIndex = 0;
            this.rbImageM.TabStop = true;
            this.rbImageM.Text = "Image";
            this.rbImageM.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBannerB);
            this.groupBox2.Controls.Add(this.rbCodeB);
            this.groupBox2.Controls.Add(this.rbImageB);
            this.groupBox2.Location = new System.Drawing.Point(14, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bottom Placeholder";
            // 
            // txtBannerB
            // 
            this.txtBannerB.Location = new System.Drawing.Point(16, 49);
            this.txtBannerB.Multiline = true;
            this.txtBannerB.Name = "txtBannerB";
            this.txtBannerB.Size = new System.Drawing.Size(229, 43);
            this.txtBannerB.TabIndex = 2;
            // 
            // rbCodeB
            // 
            this.rbCodeB.AutoSize = true;
            this.rbCodeB.Location = new System.Drawing.Point(93, 21);
            this.rbCodeB.Name = "rbCodeB";
            this.rbCodeB.Size = new System.Drawing.Size(59, 20);
            this.rbCodeB.TabIndex = 1;
            this.rbCodeB.TabStop = true;
            this.rbCodeB.Text = "Code";
            this.rbCodeB.UseVisualStyleBackColor = true;
            // 
            // rbImageB
            // 
            this.rbImageB.AutoSize = true;
            this.rbImageB.Location = new System.Drawing.Point(16, 22);
            this.rbImageB.Name = "rbImageB";
            this.rbImageB.Size = new System.Drawing.Size(64, 20);
            this.rbImageB.TabIndex = 0;
            this.rbImageB.TabStop = true;
            this.rbImageB.Text = "Image";
            this.rbImageB.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBannerL);
            this.groupBox3.Controls.Add(this.rbCodeL);
            this.groupBox3.Controls.Add(this.rbImageL);
            this.groupBox3.Location = new System.Drawing.Point(14, 524);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Left Placeholder";
            // 
            // txtBannerL
            // 
            this.txtBannerL.Location = new System.Drawing.Point(16, 49);
            this.txtBannerL.Multiline = true;
            this.txtBannerL.Name = "txtBannerL";
            this.txtBannerL.Size = new System.Drawing.Size(229, 43);
            this.txtBannerL.TabIndex = 2;
            // 
            // rbCodeL
            // 
            this.rbCodeL.AutoSize = true;
            this.rbCodeL.Location = new System.Drawing.Point(93, 21);
            this.rbCodeL.Name = "rbCodeL";
            this.rbCodeL.Size = new System.Drawing.Size(59, 20);
            this.rbCodeL.TabIndex = 1;
            this.rbCodeL.TabStop = true;
            this.rbCodeL.Text = "Code";
            this.rbCodeL.UseVisualStyleBackColor = true;
            // 
            // rbImageL
            // 
            this.rbImageL.AutoSize = true;
            this.rbImageL.Location = new System.Drawing.Point(16, 22);
            this.rbImageL.Name = "rbImageL";
            this.rbImageL.Size = new System.Drawing.Size(64, 20);
            this.rbImageL.TabIndex = 0;
            this.rbImageL.TabStop = true;
            this.rbImageL.Text = "Image";
            this.rbImageL.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBannerR);
            this.groupBox4.Controls.Add(this.rbCodeR);
            this.groupBox4.Controls.Add(this.rbImageR);
            this.groupBox4.Location = new System.Drawing.Point(14, 408);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Right Placeholder";
            // 
            // txtBannerR
            // 
            this.txtBannerR.Location = new System.Drawing.Point(16, 49);
            this.txtBannerR.Multiline = true;
            this.txtBannerR.Name = "txtBannerR";
            this.txtBannerR.Size = new System.Drawing.Size(229, 43);
            this.txtBannerR.TabIndex = 2;
            // 
            // rbCodeR
            // 
            this.rbCodeR.AutoSize = true;
            this.rbCodeR.Location = new System.Drawing.Point(93, 21);
            this.rbCodeR.Name = "rbCodeR";
            this.rbCodeR.Size = new System.Drawing.Size(59, 20);
            this.rbCodeR.TabIndex = 1;
            this.rbCodeR.TabStop = true;
            this.rbCodeR.Text = "Code";
            this.rbCodeR.UseVisualStyleBackColor = true;
            // 
            // rbImageR
            // 
            this.rbImageR.AutoSize = true;
            this.rbImageR.Location = new System.Drawing.Point(16, 22);
            this.rbImageR.Name = "rbImageR";
            this.rbImageR.Size = new System.Drawing.Size(64, 20);
            this.rbImageR.TabIndex = 0;
            this.rbImageR.TabStop = true;
            this.rbImageR.Text = "Image";
            this.rbImageR.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Family Introduction";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1202, 680);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbTop);
            this.Controls.Add(this.txtFamilyIntro);
            this.Controls.Add(this.btnCreatePage);
            this.Controls.Add(this.txtPageWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFamilyName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 18, 20, 40);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HTML Builder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gbTop.ResumeLayout(false);
            this.gbTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreatePage;
        private Zoople.HTMLEditControl txtFamilyIntro;
        private System.Windows.Forms.TextBox txtPageWidth;
        private System.Windows.Forms.GroupBox gbTop;
        private System.Windows.Forms.RadioButton rbCodeT;
        private System.Windows.Forms.RadioButton rbImageT;
        private System.Windows.Forms.TextBox txtBannerT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBannerM;
        private System.Windows.Forms.RadioButton rbCodeM;
        private System.Windows.Forms.RadioButton rbImageM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBannerB;
        private System.Windows.Forms.RadioButton rbCodeB;
        private System.Windows.Forms.RadioButton rbImageB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBannerL;
        private System.Windows.Forms.RadioButton rbCodeL;
        private System.Windows.Forms.RadioButton rbImageL;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBannerR;
        private System.Windows.Forms.RadioButton rbCodeR;
        private System.Windows.Forms.RadioButton rbImageR;
        private System.Windows.Forms.Label label4;
    }
}

