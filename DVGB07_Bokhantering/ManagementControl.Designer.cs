using System.ComponentModel;

namespace DVGB07_Bokhantering
{
	partial class ManagementControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
			this.buttonSplitContainer = new System.Windows.Forms.SplitContainer();
			this.addButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.bookDataGridView = new System.Windows.Forms.DataGridView();
			this.cancelButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.isbnTextBox = new System.Windows.Forms.TextBox();
			this.authorTextBox = new System.Windows.Forms.TextBox();
			this.titleTextBox = new System.Windows.Forms.TextBox();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.isbnLabel = new System.Windows.Forms.Label();
			this.authorLabel = new System.Windows.Forms.Label();
			this.titleLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) (this.mainSplitContainer)).BeginInit();
			this.mainSplitContainer.Panel1.SuspendLayout();
			this.mainSplitContainer.Panel2.SuspendLayout();
			this.mainSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.buttonSplitContainer)).BeginInit();
			this.buttonSplitContainer.Panel1.SuspendLayout();
			this.buttonSplitContainer.Panel2.SuspendLayout();
			this.buttonSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.bookDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// mainSplitContainer
			// 
			this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainSplitContainer.IsSplitterFixed = true;
			this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.mainSplitContainer.Name = "mainSplitContainer";
			// 
			// mainSplitContainer.Panel1
			// 
			this.mainSplitContainer.Panel1.Controls.Add(this.buttonSplitContainer);
			this.mainSplitContainer.Panel1.Controls.Add(this.bookDataGridView);
			// 
			// mainSplitContainer.Panel2
			// 
			this.mainSplitContainer.Panel2.Controls.Add(this.cancelButton);
			this.mainSplitContainer.Panel2.Controls.Add(this.saveButton);
			this.mainSplitContainer.Panel2.Controls.Add(this.descriptionTextBox);
			this.mainSplitContainer.Panel2.Controls.Add(this.isbnTextBox);
			this.mainSplitContainer.Panel2.Controls.Add(this.authorTextBox);
			this.mainSplitContainer.Panel2.Controls.Add(this.titleTextBox);
			this.mainSplitContainer.Panel2.Controls.Add(this.descriptionLabel);
			this.mainSplitContainer.Panel2.Controls.Add(this.isbnLabel);
			this.mainSplitContainer.Panel2.Controls.Add(this.authorLabel);
			this.mainSplitContainer.Panel2.Controls.Add(this.titleLabel);
			this.mainSplitContainer.Size = new System.Drawing.Size(653, 417);
			this.mainSplitContainer.SplitterDistance = 375;
			this.mainSplitContainer.TabIndex = 0;
			// 
			// buttonSplitContainer
			// 
			this.buttonSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSplitContainer.IsSplitterFixed = true;
			this.buttonSplitContainer.Location = new System.Drawing.Point(3, 358);
			this.buttonSplitContainer.Name = "buttonSplitContainer";
			// 
			// buttonSplitContainer.Panel1
			// 
			this.buttonSplitContainer.Panel1.Controls.Add(this.addButton);
			// 
			// buttonSplitContainer.Panel2
			// 
			this.buttonSplitContainer.Panel2.Controls.Add(this.removeButton);
			this.buttonSplitContainer.Size = new System.Drawing.Size(369, 59);
			this.buttonSplitContainer.SplitterDistance = 191;
			this.buttonSplitContainer.TabIndex = 1;
			// 
			// addButton
			// 
			this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addButton.Location = new System.Drawing.Point(0, 0);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(191, 59);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "Add Book";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// removeButton
			// 
			this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.removeButton.Location = new System.Drawing.Point(0, 0);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(174, 59);
			this.removeButton.TabIndex = 3;
			this.removeButton.Text = "Remove Book";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// bookDataGridView
			// 
			this.bookDataGridView.AllowUserToAddRows = false;
			this.bookDataGridView.AllowUserToDeleteRows = false;
			this.bookDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bookDataGridView.Location = new System.Drawing.Point(3, 3);
			this.bookDataGridView.MultiSelect = false;
			this.bookDataGridView.Name = "bookDataGridView";
			this.bookDataGridView.ReadOnly = true;
			this.bookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.bookDataGridView.ShowCellErrors = false;
			this.bookDataGridView.ShowCellToolTips = false;
			this.bookDataGridView.ShowEditingIcon = false;
			this.bookDataGridView.ShowRowErrors = false;
			this.bookDataGridView.Size = new System.Drawing.Size(369, 352);
			this.bookDataGridView.TabIndex = 0;
			this.bookDataGridView.SelectionChanged += new System.EventHandler(this.bookDataGridView_SelectionChanged);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.Enabled = false;
			this.cancelButton.Location = new System.Drawing.Point(87, 358);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 56);
			this.cancelButton.TabIndex = 8;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.Enabled = false;
			this.saveButton.Location = new System.Drawing.Point(168, 358);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 56);
			this.saveButton.TabIndex = 9;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionTextBox.Location = new System.Drawing.Point(12, 107);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(231, 248);
			this.descriptionTextBox.TabIndex = 7;
			this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
			// 
			// isbnTextBox
			// 
			this.isbnTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.isbnTextBox.Location = new System.Drawing.Point(118, 57);
			this.isbnTextBox.Name = "isbnTextBox";
			this.isbnTextBox.Size = new System.Drawing.Size(125, 20);
			this.isbnTextBox.TabIndex = 6;
			this.isbnTextBox.TextChanged += new System.EventHandler(this.isbnTextBox_TextChanged);
			// 
			// authorTextBox
			// 
			this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.authorTextBox.Location = new System.Drawing.Point(118, 34);
			this.authorTextBox.Name = "authorTextBox";
			this.authorTextBox.Size = new System.Drawing.Size(125, 20);
			this.authorTextBox.TabIndex = 5;
			this.authorTextBox.TextChanged += new System.EventHandler(this.authorTextBox_TextChanged);
			// 
			// titleTextBox
			// 
			this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.titleTextBox.Location = new System.Drawing.Point(118, 11);
			this.titleTextBox.Name = "titleTextBox";
			this.titleTextBox.Size = new System.Drawing.Size(125, 20);
			this.titleTextBox.TabIndex = 4;
			this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.descriptionLabel.Location = new System.Drawing.Point(12, 81);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(100, 23);
			this.descriptionLabel.TabIndex = 0;
			this.descriptionLabel.Text = "Description";
			// 
			// isbnLabel
			// 
			this.isbnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.isbnLabel.Location = new System.Drawing.Point(12, 58);
			this.isbnLabel.Name = "isbnLabel";
			this.isbnLabel.Size = new System.Drawing.Size(100, 23);
			this.isbnLabel.TabIndex = 0;
			this.isbnLabel.Text = "ISBN";
			// 
			// authorLabel
			// 
			this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.authorLabel.Location = new System.Drawing.Point(12, 35);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(100, 23);
			this.authorLabel.TabIndex = 0;
			this.authorLabel.Text = "Author";
			// 
			// titleLabel
			// 
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.titleLabel.Location = new System.Drawing.Point(12, 12);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(100, 23);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "Title";
			// 
			// ManagementControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.mainSplitContainer);
			this.Location = new System.Drawing.Point(15, 15);
			this.Name = "ManagementControl";
			this.Size = new System.Drawing.Size(653, 417);
			this.mainSplitContainer.Panel1.ResumeLayout(false);
			this.mainSplitContainer.Panel2.ResumeLayout(false);
			this.mainSplitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.mainSplitContainer)).EndInit();
			this.mainSplitContainer.ResumeLayout(false);
			this.buttonSplitContainer.Panel1.ResumeLayout(false);
			this.buttonSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.buttonSplitContainer)).EndInit();
			this.buttonSplitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.bookDataGridView)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button cancelButton;

		private System.Windows.Forms.Button saveButton;

		private System.Windows.Forms.Label authorLabel;
		private System.Windows.Forms.Label isbnLabel;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.TextBox titleTextBox;
		private System.Windows.Forms.TextBox authorTextBox;
		private System.Windows.Forms.TextBox isbnTextBox;
		private System.Windows.Forms.TextBox descriptionTextBox;

		private System.Windows.Forms.Label titleLabel;

		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button removeButton;

		private System.Windows.Forms.SplitContainer buttonSplitContainer;

		private System.Windows.Forms.DataGridView bookDataGridView;

		private System.Windows.Forms.SplitContainer mainSplitContainer;

		#endregion
	}
}