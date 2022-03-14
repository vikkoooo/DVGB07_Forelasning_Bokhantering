using System.ComponentModel;

namespace DVGB07_Bokhantering
{
	partial class LendingControl
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
			this.isbnTextBox = new System.Windows.Forms.TextBox();
			this.isbnLabel = new System.Windows.Forms.Label();
			this.addToCartLabel = new System.Windows.Forms.Label();
			this.addToCartButton = new System.Windows.Forms.Button();
			this.lendingSplitContainer = new System.Windows.Forms.SplitContainer();
			this.lendingSplitContainer2 = new System.Windows.Forms.SplitContainer();
			this.radioReturn = new System.Windows.Forms.RadioButton();
			this.radioLend = new System.Windows.Forms.RadioButton();
			this.finishButton = new System.Windows.Forms.Button();
			this.cartListBox = new System.Windows.Forms.ListBox();
			this.bookListDataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize) (this.lendingSplitContainer)).BeginInit();
			this.lendingSplitContainer.Panel1.SuspendLayout();
			this.lendingSplitContainer.Panel2.SuspendLayout();
			this.lendingSplitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.lendingSplitContainer2)).BeginInit();
			this.lendingSplitContainer2.Panel1.SuspendLayout();
			this.lendingSplitContainer2.Panel2.SuspendLayout();
			this.lendingSplitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.bookListDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// isbnTextBox
			// 
			this.isbnTextBox.Location = new System.Drawing.Point(105, 26);
			this.isbnTextBox.Name = "isbnTextBox";
			this.isbnTextBox.Size = new System.Drawing.Size(125, 20);
			this.isbnTextBox.TabIndex = 8;
			// 
			// isbnLabel
			// 
			this.isbnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.isbnLabel.Location = new System.Drawing.Point(0, 27);
			this.isbnLabel.Name = "isbnLabel";
			this.isbnLabel.Size = new System.Drawing.Size(100, 23);
			this.isbnLabel.TabIndex = 7;
			this.isbnLabel.Text = "ISBN";
			// 
			// addToCartLabel
			// 
			this.addToCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.addToCartLabel.Location = new System.Drawing.Point(0, 0);
			this.addToCartLabel.Name = "addToCartLabel";
			this.addToCartLabel.Size = new System.Drawing.Size(134, 23);
			this.addToCartLabel.TabIndex = 7;
			this.addToCartLabel.Text = "Add book to cart";
			// 
			// addToCartButton
			// 
			this.addToCartButton.Location = new System.Drawing.Point(155, 52);
			this.addToCartButton.Name = "addToCartButton";
			this.addToCartButton.Size = new System.Drawing.Size(75, 23);
			this.addToCartButton.TabIndex = 9;
			this.addToCartButton.Text = "Add";
			this.addToCartButton.UseVisualStyleBackColor = true;
			this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
			// 
			// lendingSplitContainer
			// 
			this.lendingSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lendingSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.lendingSplitContainer.Name = "lendingSplitContainer";
			this.lendingSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// lendingSplitContainer.Panel1
			// 
			this.lendingSplitContainer.Panel1.Controls.Add(this.lendingSplitContainer2);
			// 
			// lendingSplitContainer.Panel2
			// 
			this.lendingSplitContainer.Panel2.Controls.Add(this.bookListDataGridView);
			this.lendingSplitContainer.Size = new System.Drawing.Size(453, 260);
			this.lendingSplitContainer.SplitterDistance = 130;
			this.lendingSplitContainer.TabIndex = 10;
			// 
			// lendingSplitContainer2
			// 
			this.lendingSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lendingSplitContainer2.Location = new System.Drawing.Point(0, 0);
			this.lendingSplitContainer2.Name = "lendingSplitContainer2";
			// 
			// lendingSplitContainer2.Panel1
			// 
			this.lendingSplitContainer2.Panel1.Controls.Add(this.radioReturn);
			this.lendingSplitContainer2.Panel1.Controls.Add(this.radioLend);
			this.lendingSplitContainer2.Panel1.Controls.Add(this.addToCartLabel);
			this.lendingSplitContainer2.Panel1.Controls.Add(this.isbnTextBox);
			this.lendingSplitContainer2.Panel1.Controls.Add(this.finishButton);
			this.lendingSplitContainer2.Panel1.Controls.Add(this.addToCartButton);
			this.lendingSplitContainer2.Panel1.Controls.Add(this.isbnLabel);
			// 
			// lendingSplitContainer2.Panel2
			// 
			this.lendingSplitContainer2.Panel2.Controls.Add(this.cartListBox);
			this.lendingSplitContainer2.Size = new System.Drawing.Size(453, 130);
			this.lendingSplitContainer2.SplitterDistance = 226;
			this.lendingSplitContainer2.TabIndex = 11;
			// 
			// radioReturn
			// 
			this.radioReturn.Location = new System.Drawing.Point(3, 80);
			this.radioReturn.Name = "radioReturn";
			this.radioReturn.Size = new System.Drawing.Size(104, 24);
			this.radioReturn.TabIndex = 10;
			this.radioReturn.Text = "Return";
			this.radioReturn.UseVisualStyleBackColor = true;
			this.radioReturn.CheckedChanged += new System.EventHandler(this.radioReturn_CheckedChanged);
			// 
			// radioLend
			// 
			this.radioLend.Checked = true;
			this.radioLend.Location = new System.Drawing.Point(3, 53);
			this.radioLend.Name = "radioLend";
			this.radioLend.Size = new System.Drawing.Size(104, 24);
			this.radioLend.TabIndex = 10;
			this.radioLend.TabStop = true;
			this.radioLend.Text = "Lend";
			this.radioLend.UseVisualStyleBackColor = true;
			this.radioLend.CheckedChanged += new System.EventHandler(this.radioLend_CheckedChanged);
			// 
			// finishButton
			// 
			this.finishButton.Location = new System.Drawing.Point(155, 81);
			this.finishButton.Name = "finishButton";
			this.finishButton.Size = new System.Drawing.Size(75, 23);
			this.finishButton.TabIndex = 9;
			this.finishButton.Text = "Lend Books";
			this.finishButton.UseVisualStyleBackColor = true;
			this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
			// 
			// cartListBox
			// 
			this.cartListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cartListBox.FormattingEnabled = true;
			this.cartListBox.Location = new System.Drawing.Point(0, 0);
			this.cartListBox.Name = "cartListBox";
			this.cartListBox.Size = new System.Drawing.Size(223, 130);
			this.cartListBox.TabIndex = 10;
			// 
			// bookListDataGridView
			// 
			this.bookListDataGridView.AllowUserToAddRows = false;
			this.bookListDataGridView.AllowUserToDeleteRows = false;
			this.bookListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bookListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bookListDataGridView.Location = new System.Drawing.Point(0, 0);
			this.bookListDataGridView.MultiSelect = false;
			this.bookListDataGridView.Name = "bookListDataGridView";
			this.bookListDataGridView.ReadOnly = true;
			this.bookListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.bookListDataGridView.Size = new System.Drawing.Size(453, 126);
			this.bookListDataGridView.TabIndex = 0;
			this.bookListDataGridView.SelectionChanged += new System.EventHandler(this.bookListDataGridView_SelectionChanged);
			// 
			// LendingControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lendingSplitContainer);
			this.Name = "LendingControl";
			this.Size = new System.Drawing.Size(453, 260);
			this.Load += new System.EventHandler(this.LendingControl_Load);
			this.lendingSplitContainer.Panel1.ResumeLayout(false);
			this.lendingSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.lendingSplitContainer)).EndInit();
			this.lendingSplitContainer.ResumeLayout(false);
			this.lendingSplitContainer2.Panel1.ResumeLayout(false);
			this.lendingSplitContainer2.Panel1.PerformLayout();
			this.lendingSplitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.lendingSplitContainer2)).EndInit();
			this.lendingSplitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.bookListDataGridView)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.RadioButton radioReturn;

		private System.Windows.Forms.RadioButton radioLend;

		private System.Windows.Forms.Button finishButton;

		private System.Windows.Forms.SplitContainer lendingSplitContainer2;

		private System.Windows.Forms.ListBox cartListBox;

		private System.Windows.Forms.DataGridView bookListDataGridView;

		private System.Windows.Forms.SplitContainer lendingSplitContainer;

		private System.Windows.Forms.Button addToCartButton;

		private System.Windows.Forms.Label addToCartLabel;

		private System.Windows.Forms.TextBox isbnTextBox;
		private System.Windows.Forms.Label isbnLabel;

		#endregion
	}
}