namespace CrmManager
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lstEntities = new System.Windows.Forms.ListBox();
            this.listMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.getDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateCSharpClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateCSharpConstantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.listMenuStrip.SuspendLayout();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblStatus);
            this.splitContainer1.Panel1.Controls.Add(this.btnExec);
            this.splitContainer1.Panel1.Controls.Add(this.tbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.lstEntities);
            this.splitContainer1.Panel1.Controls.Add(this.btnConnect);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabs);
            this.splitContainer1.Size = new System.Drawing.Size(908, 467);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Yellow;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(4, 452);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 4;
            // 
            // btnExec
            // 
            this.btnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExec.Location = new System.Drawing.Point(175, 42);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(31, 26);
            this.btnExec.TabIndex = 3;
            this.btnExec.Text = "!";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(3, 42);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(168, 26);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lstEntities
            // 
            this.lstEntities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstEntities.ContextMenuStrip = this.listMenuStrip;
            this.lstEntities.FormattingEnabled = true;
            this.lstEntities.Location = new System.Drawing.Point(2, 71);
            this.lstEntities.Name = "lstEntities";
            this.lstEntities.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstEntities.Size = new System.Drawing.Size(205, 381);
            this.lstEntities.TabIndex = 1;
            this.lstEntities.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstEntities_KeyDown);
            this.lstEntities.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstEntities_MouseDoubleClick);
            // 
            // listMenuStrip
            // 
            this.listMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getDataToolStripMenuItem,
            this.showFieldsToolStripMenuItem,
            this.generateCSharpClassToolStripMenuItem,
            this.generateCSharpConstantsToolStripMenuItem});
            this.listMenuStrip.Name = "listMenuStrip";
            this.listMenuStrip.Size = new System.Drawing.Size(219, 92);
            // 
            // getDataToolStripMenuItem
            // 
            this.getDataToolStripMenuItem.Name = "getDataToolStripMenuItem";
            this.getDataToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.getDataToolStripMenuItem.Text = "Get  &Data";
            this.getDataToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // showFieldsToolStripMenuItem
            // 
            this.showFieldsToolStripMenuItem.Name = "showFieldsToolStripMenuItem";
            this.showFieldsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.showFieldsToolStripMenuItem.Text = "Show &Fields";
            this.showFieldsToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // generateCSharpClassToolStripMenuItem
            // 
            this.generateCSharpClassToolStripMenuItem.Name = "generateCSharpClassToolStripMenuItem";
            this.generateCSharpClassToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.generateCSharpClassToolStripMenuItem.Text = "&Generate CSharp Class";
            this.generateCSharpClassToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // generateCSharpConstantsToolStripMenuItem
            // 
            this.generateCSharpConstantsToolStripMenuItem.Name = "generateCSharpConstantsToolStripMenuItem";
            this.generateCSharpConstantsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.generateCSharpConstantsToolStripMenuItem.Text = "Generate CSharp &Constants";
            this.generateCSharpConstantsToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(205, 34);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(694, 467);
            this.tabs.TabIndex = 0;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Query1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "+";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 467);
            this.Controls.Add(this.splitContainer1);
            this.Icon = global::CrmManager.Properties.Resources.favicon;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "CRM Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.listMenuStrip.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.ListBox lstEntities;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnExec;
		private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip listMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem getDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateCSharpClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateCSharpConstantsToolStripMenuItem;
    }
}

