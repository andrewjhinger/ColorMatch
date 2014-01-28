namespace ColorMatch
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.singleMatchesToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mixMatchesToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.matchToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.primaryColorsPanel = new System.Windows.Forms.Panel();
            this.complementaryColorsPanel = new System.Windows.Forms.Panel();
            this.colorsPictureBox = new System.Windows.Forms.PictureBox();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(560, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleMatchesToolStripStatusLabel,
            this.mixMatchesToolStripStatusLabel,
            this.matchToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 394);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(560, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // singleMatchesToolStripStatusLabel
            // 
            this.singleMatchesToolStripStatusLabel.Name = "singleMatchesToolStripStatusLabel";
            this.singleMatchesToolStripStatusLabel.Size = new System.Drawing.Size(181, 17);
            this.singleMatchesToolStripStatusLabel.Spring = true;
            this.singleMatchesToolStripStatusLabel.Text = "Single Matches: 0";
            // 
            // mixMatchesToolStripStatusLabel
            // 
            this.mixMatchesToolStripStatusLabel.Name = "mixMatchesToolStripStatusLabel";
            this.mixMatchesToolStripStatusLabel.Size = new System.Drawing.Size(181, 17);
            this.mixMatchesToolStripStatusLabel.Spring = true;
            this.mixMatchesToolStripStatusLabel.Text = "Mix Matches: 0";
            // 
            // matchToolStripStatusLabel
            // 
            this.matchToolStripStatusLabel.Name = "matchToolStripStatusLabel";
            this.matchToolStripStatusLabel.Size = new System.Drawing.Size(181, 17);
            this.matchToolStripStatusLabel.Spring = true;
            this.matchToolStripStatusLabel.Text = "Match!";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.10577F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.89423F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel.Controls.Add(this.primaryColorsPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.complementaryColorsPanel, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.colorsPictureBox, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(560, 370);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // primaryColorsPanel
            // 
            this.primaryColorsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryColorsPanel.Location = new System.Drawing.Point(3, 3);
            this.primaryColorsPanel.Name = "primaryColorsPanel";
            this.primaryColorsPanel.Size = new System.Drawing.Size(165, 364);
            this.primaryColorsPanel.TabIndex = 0;
            // 
            // complementaryColorsPanel
            // 
            this.complementaryColorsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complementaryColorsPanel.Location = new System.Drawing.Point(419, 3);
            this.complementaryColorsPanel.Name = "complementaryColorsPanel";
            this.complementaryColorsPanel.Size = new System.Drawing.Size(138, 364);
            this.complementaryColorsPanel.TabIndex = 1;
            // 
            // colorsPictureBox
            // 
            this.colorsPictureBox.Location = new System.Drawing.Point(174, 3);
            this.colorsPictureBox.Name = "colorsPictureBox";
            this.colorsPictureBox.Size = new System.Drawing.Size(100, 50);
            this.colorsPictureBox.TabIndex = 2;
            this.colorsPictureBox.TabStop = false;
            this.colorsPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.colorsPictureBox_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 416);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Match";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel singleMatchesToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel mixMatchesToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel matchToolStripStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel primaryColorsPanel;
        private System.Windows.Forms.Panel complementaryColorsPanel;
        private System.Windows.Forms.PictureBox colorsPictureBox;
    }
}

