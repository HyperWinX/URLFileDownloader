namespace URLFileDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(383, 175);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroProgressBar1);
            this.metroTabPage1.Controls.Add(this.metroButton3);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.metroTextBox2);
            this.metroTabPage1.Controls.Add(this.metroTextBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(375, 136);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "             File download        ";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(8, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "[IDLE]";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(8, 66);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(359, 32);
            this.metroProgressBar1.TabIndex = 10;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressBar1.Visible = false;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(8, 67);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(359, 32);
            this.metroButton3.TabIndex = 9;
            this.metroButton3.Text = "Start download";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.Visible = false;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(346, 41);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(21, 19);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "...";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(8, 41);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PromptText = "Save file";
            this.metroTextBox2.Size = new System.Drawing.Size(333, 19);
            this.metroTextBox2.TabIndex = 7;
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(8, 16);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PromptText = "URL";
            this.metroTextBox1.Size = new System.Drawing.Size(359, 19);
            this.metroTextBox1.TabIndex = 6;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroLabel1);
            this.metroTabPage3.Controls.Add(this.metroProgressBar2);
            this.metroTabPage3.Controls.Add(this.metroButton2);
            this.metroTabPage3.Controls.Add(this.metroButton4);
            this.metroTabPage3.Controls.Add(this.metroTextBox3);
            this.metroTabPage3.Controls.Add(this.metroTextBox4);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(375, 136);
            this.metroTabPage3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabPage3.TabIndex = 1;
            this.metroTabPage3.Text = "       Youtube download        ";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(8, 102);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "[IDLE]";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroProgressBar2
            // 
            this.metroProgressBar2.Location = new System.Drawing.Point(8, 66);
            this.metroProgressBar2.Name = "metroProgressBar2";
            this.metroProgressBar2.Size = new System.Drawing.Size(359, 32);
            this.metroProgressBar2.TabIndex = 15;
            this.metroProgressBar2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressBar2.Visible = false;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(8, 67);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(359, 32);
            this.metroButton2.TabIndex = 14;
            this.metroButton2.Text = "Start download";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(346, 41);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(21, 19);
            this.metroButton4.TabIndex = 13;
            this.metroButton4.Text = "...";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(8, 41);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PromptText = "Save file";
            this.metroTextBox3.Size = new System.Drawing.Size(333, 19);
            this.metroTextBox3.TabIndex = 12;
            this.metroTextBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.Location = new System.Drawing.Point(8, 16);
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PromptText = "URL";
            this.metroTextBox4.Size = new System.Drawing.Size(359, 19);
            this.metroTextBox4.TabIndex = 11;
            this.metroTextBox4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(0, 0);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(200, 100);
            this.metroTabPage2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabPage2.TabIndex = 0;
            this.metroTabPage2.Text = "Youtube download";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(383, 175);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "URLFileDownloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

