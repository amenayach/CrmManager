namespace CrmManager.Controls
{
	partial class QueryUC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splContainer = new System.Windows.Forms.SplitContainer();
			this.tbQuery = new System.Windows.Forms.RichTextBox();
			this.grd = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.splContainer)).BeginInit();
			this.splContainer.Panel1.SuspendLayout();
			this.splContainer.Panel2.SuspendLayout();
			this.splContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
			this.SuspendLayout();
			// 
			// splContainer
			// 
			this.splContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splContainer.Location = new System.Drawing.Point(0, 0);
			this.splContainer.Name = "splContainer";
			this.splContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splContainer.Panel1
			// 
			this.splContainer.Panel1.Controls.Add(this.tbQuery);
			// 
			// splContainer.Panel2
			// 
			this.splContainer.Panel2.Controls.Add(this.grd);
			this.splContainer.Size = new System.Drawing.Size(746, 533);
			this.splContainer.SplitterDistance = 131;
			this.splContainer.TabIndex = 0;
			// 
			// tbQuery
			// 
			this.tbQuery.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbQuery.Location = new System.Drawing.Point(0, 0);
			this.tbQuery.Name = "tbQuery";
			this.tbQuery.Size = new System.Drawing.Size(746, 131);
			this.tbQuery.TabIndex = 0;
			this.tbQuery.Text = "";
			// 
			// grd
			// 
			this.grd.AllowUserToAddRows = false;
			this.grd.AllowUserToDeleteRows = false;
			this.grd.BackgroundColor = System.Drawing.Color.White;
			this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd.Location = new System.Drawing.Point(0, 0);
			this.grd.Name = "grd";
			this.grd.ReadOnly = true;
			this.grd.Size = new System.Drawing.Size(746, 398);
			this.grd.TabIndex = 0;
			// 
			// QueryUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splContainer);
			this.Name = "QueryUC";
			this.Size = new System.Drawing.Size(746, 533);
			this.splContainer.Panel1.ResumeLayout(false);
			this.splContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splContainer)).EndInit();
			this.splContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splContainer;
		private System.Windows.Forms.RichTextBox tbQuery;
		private System.Windows.Forms.DataGridView grd;
	}
}
