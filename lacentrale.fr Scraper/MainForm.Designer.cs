﻿
namespace lacentrale.fr_Scraper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stopB = new MetroFramework.Controls.MetroButton();
            this.startB = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.DebugT = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.threadsI = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.inputI = new MetroFramework.Controls.MetroTextBox();
            this.outputI = new MetroFramework.Controls.MetroTextBox();
            this.loadInputB = new MetroFramework.Controls.MetroButton();
            this.loadOutputB = new MetroFramework.Controls.MetroButton();
            this.openInputB = new MetroFramework.Controls.MetroButton();
            this.openOutputB = new MetroFramework.Controls.MetroButton();
            this.logToUII = new MetroFramework.Controls.MetroCheckBox();
            this.logToFileI = new MetroFramework.Controls.MetroCheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.displayT = new System.Windows.Forms.Label();
            this.ProgressB = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadsI)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(941, 497);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 16;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroTabPage1.Controls.Add(this.panel2);
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.ForeColor = System.Drawing.Color.Black;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 0;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(933, 452);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Options";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.stopB);
            this.panel1.Controls.Add(this.startB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(763, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 452);
            this.panel1.TabIndex = 6;
            // 
            // stopB
            // 
            this.stopB.Location = new System.Drawing.Point(34, 365);
            this.stopB.Name = "stopB";
            this.stopB.Size = new System.Drawing.Size(111, 43);
            this.stopB.Style = MetroFramework.MetroColorStyle.Orange;
            this.stopB.TabIndex = 24;
            this.stopB.Text = "Stop";
            this.stopB.UseSelectable = true;
            this.stopB.UseStyleColors = true;
            // 
            // startB
            // 
            this.startB.Location = new System.Drawing.Point(34, 309);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(111, 43);
            this.startB.Style = MetroFramework.MetroColorStyle.Orange;
            this.startB.TabIndex = 23;
            this.startB.Text = "Start";
            this.startB.UseSelectable = true;
            this.startB.UseStyleColors = true;
            this.startB.Click += new System.EventHandler(this.startB_Click_1);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroPanel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = false;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 0;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(933, 509);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Logs";
            this.metroTabPage2.VerticalScrollbarBarColor = false;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 0;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.DebugT);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(933, 509);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // DebugT
            // 
            this.DebugT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DebugT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DebugT.Cursor = System.Windows.Forms.Cursors.Default;
            this.DebugT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebugT.Location = new System.Drawing.Point(0, 0);
            this.DebugT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DebugT.Name = "DebugT";
            this.DebugT.ReadOnly = true;
            this.DebugT.Size = new System.Drawing.Size(933, 509);
            this.DebugT.TabIndex = 1;
            this.DebugT.Text = "";
            this.DebugT.WordWrap = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::lacentrale.fr_Scraper.Properties.Resources.clipart196740;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(20, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // threadsI
            // 
            this.threadsI.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threadsI.Location = new System.Drawing.Point(165, 38);
            this.threadsI.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.threadsI.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadsI.Name = "threadsI";
            this.threadsI.Size = new System.Drawing.Size(58, 21);
            this.threadsI.TabIndex = 6;
            this.threadsI.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Number of threads";
            // 
            // inputI
            // 
            // 
            // 
            // 
            this.inputI.CustomButton.Image = null;
            this.inputI.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.inputI.CustomButton.Name = "";
            this.inputI.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.inputI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputI.CustomButton.TabIndex = 1;
            this.inputI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputI.CustomButton.UseSelectable = true;
            this.inputI.CustomButton.Visible = false;
            this.inputI.Lines = new string[0];
            this.inputI.Location = new System.Drawing.Point(32, 86);
            this.inputI.MaxLength = 32767;
            this.inputI.Name = "inputI";
            this.inputI.PasswordChar = '\0';
            this.inputI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputI.SelectedText = "";
            this.inputI.SelectionLength = 0;
            this.inputI.SelectionStart = 0;
            this.inputI.ShortcutsEnabled = true;
            this.inputI.Size = new System.Drawing.Size(421, 23);
            this.inputI.Style = MetroFramework.MetroColorStyle.Orange;
            this.inputI.TabIndex = 20;
            this.inputI.UseSelectable = true;
            this.inputI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // outputI
            // 
            // 
            // 
            // 
            this.outputI.CustomButton.Image = null;
            this.outputI.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.outputI.CustomButton.Name = "";
            this.outputI.CustomButton.Size = new System.Drawing.Size(16, 17);
            this.outputI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.outputI.CustomButton.TabIndex = 1;
            this.outputI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.outputI.CustomButton.UseSelectable = true;
            this.outputI.CustomButton.Visible = false;
            this.outputI.Lines = new string[0];
            this.outputI.Location = new System.Drawing.Point(32, 126);
            this.outputI.MaxLength = 32767;
            this.outputI.Name = "outputI";
            this.outputI.PasswordChar = '\0';
            this.outputI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.outputI.SelectedText = "";
            this.outputI.SelectionLength = 0;
            this.outputI.SelectionStart = 0;
            this.outputI.ShortcutsEnabled = true;
            this.outputI.Size = new System.Drawing.Size(421, 23);
            this.outputI.Style = MetroFramework.MetroColorStyle.Orange;
            this.outputI.TabIndex = 21;
            this.outputI.UseSelectable = true;
            this.outputI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.outputI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loadInputB
            // 
            this.loadInputB.Location = new System.Drawing.Point(488, 86);
            this.loadInputB.Name = "loadInputB";
            this.loadInputB.Size = new System.Drawing.Size(111, 23);
            this.loadInputB.Style = MetroFramework.MetroColorStyle.Orange;
            this.loadInputB.TabIndex = 22;
            this.loadInputB.Text = "Input File";
            this.loadInputB.UseSelectable = true;
            this.loadInputB.UseStyleColors = true;
            this.loadInputB.Click += new System.EventHandler(this.loadInputB_Click_1);
            // 
            // loadOutputB
            // 
            this.loadOutputB.Location = new System.Drawing.Point(488, 123);
            this.loadOutputB.Name = "loadOutputB";
            this.loadOutputB.Size = new System.Drawing.Size(111, 23);
            this.loadOutputB.Style = MetroFramework.MetroColorStyle.Orange;
            this.loadOutputB.TabIndex = 23;
            this.loadOutputB.Text = "Output File";
            this.loadOutputB.UseSelectable = true;
            this.loadOutputB.UseStyleColors = true;
            this.loadOutputB.Click += new System.EventHandler(this.loadOutputB_Click_1);
            // 
            // openInputB
            // 
            this.openInputB.Location = new System.Drawing.Point(618, 86);
            this.openInputB.Name = "openInputB";
            this.openInputB.Size = new System.Drawing.Size(111, 23);
            this.openInputB.Style = MetroFramework.MetroColorStyle.Orange;
            this.openInputB.TabIndex = 24;
            this.openInputB.Text = "Open Input";
            this.openInputB.UseSelectable = true;
            this.openInputB.UseStyleColors = true;
            this.openInputB.Click += new System.EventHandler(this.openInputB_Click_1);
            // 
            // openOutputB
            // 
            this.openOutputB.Location = new System.Drawing.Point(618, 123);
            this.openOutputB.Name = "openOutputB";
            this.openOutputB.Size = new System.Drawing.Size(111, 23);
            this.openOutputB.Style = MetroFramework.MetroColorStyle.Orange;
            this.openOutputB.TabIndex = 25;
            this.openOutputB.Text = "Open Output";
            this.openOutputB.UseSelectable = true;
            this.openOutputB.UseStyleColors = true;
            this.openOutputB.Click += new System.EventHandler(this.openOutputB_Click_1);
            // 
            // logToUII
            // 
            this.logToUII.AutoSize = true;
            this.logToUII.Location = new System.Drawing.Point(32, 337);
            this.logToUII.Name = "logToUII";
            this.logToUII.Size = new System.Drawing.Size(72, 15);
            this.logToUII.Style = MetroFramework.MetroColorStyle.Orange;
            this.logToUII.TabIndex = 26;
            this.logToUII.Text = "Log To UI";
            this.logToUII.UseSelectable = true;
            // 
            // logToFileI
            // 
            this.logToFileI.AutoSize = true;
            this.logToFileI.Location = new System.Drawing.Point(32, 374);
            this.logToFileI.Name = "logToFileI";
            this.logToFileI.Size = new System.Drawing.Size(79, 15);
            this.logToFileI.Style = MetroFramework.MetroColorStyle.Orange;
            this.logToFileI.TabIndex = 27;
            this.logToFileI.Text = "Log To File";
            this.logToFileI.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.logToFileI);
            this.panel2.Controls.Add(this.logToUII);
            this.panel2.Controls.Add(this.openOutputB);
            this.panel2.Controls.Add(this.openInputB);
            this.panel2.Controls.Add(this.loadOutputB);
            this.panel2.Controls.Add(this.loadInputB);
            this.panel2.Controls.Add(this.outputI);
            this.panel2.Controls.Add(this.inputI);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.threadsI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 452);
            this.panel2.TabIndex = 14;
            // 
            // displayT
            // 
            this.displayT.AutoSize = true;
            this.displayT.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayT.ForeColor = System.Drawing.Color.Black;
            this.displayT.Location = new System.Drawing.Point(22, 10);
            this.displayT.Name = "displayT";
            this.displayT.Size = new System.Drawing.Size(91, 16);
            this.displayT.TabIndex = 2;
            this.displayT.Text = "Bot Started";
            // 
            // ProgressB
            // 
            this.ProgressB.Location = new System.Drawing.Point(4, 35);
            this.ProgressB.Name = "ProgressB";
            this.ProgressB.Size = new System.Drawing.Size(933, 14);
            this.ProgressB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressB.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.ProgressB);
            this.panel3.Controls.Add(this.displayT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(20, 557);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 57);
            this.panel3.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 634);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "         My Bot 1.00";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadsI)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        internal System.Windows.Forms.RichTextBox DebugT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton stopB;
        private MetroFramework.Controls.MetroButton startB;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroCheckBox logToFileI;
        private MetroFramework.Controls.MetroCheckBox logToUII;
        private MetroFramework.Controls.MetroButton openOutputB;
        private MetroFramework.Controls.MetroButton openInputB;
        private MetroFramework.Controls.MetroButton loadOutputB;
        private MetroFramework.Controls.MetroButton loadInputB;
        private MetroFramework.Controls.MetroTextBox outputI;
        private MetroFramework.Controls.MetroTextBox inputI;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.NumericUpDown threadsI;
        private System.Windows.Forms.Label displayT;
        private System.Windows.Forms.ProgressBar ProgressB;
        private System.Windows.Forms.Panel panel3;
    }
}

