using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVGB07_Bokhantering
{
	public partial class LendingControl : UserControl
	{
		public Button AddToCartButton { get { return addToCartButton; } }
		private BindingSource bookListSource;
		private Library myLibrary;
		
		public LendingControl(Library myLibrary, BindingSource bookListSource)
		{
			InitializeComponent();
			this.bookListSource = bookListSource;
			this.myLibrary = myLibrary;
			bookListDataGridView.DataSource = this.bookListSource;

		}

		private void LendingControl_Load(object sender, EventArgs e)
		{
			bookListDataGridView.ClearSelection();
			isbnTextBox.Text = String.Empty;
		}
		
		private void bookListDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			if (bookListDataGridView.SelectedRows.Count < 1)
			{
				return;
			}
			// Get the item in the view that we have selected
			var book = (Book)bookListDataGridView.SelectedRows[0].DataBoundItem;
			isbnTextBox.Text = book.ISBN;
			bookListDataGridView.ClearSelection();

			isbnTextBox.Focus();
			isbnTextBox.SelectAll();

		}

		private void addToCartButton_Click(object sender, EventArgs e)
		{
			foreach (var entry in (BindingList<Book>)bookListSource.DataSource)
			{
				if (entry.ISBN == isbnTextBox.Text.Trim())
				{
					
					cartListBox.Items.Add(entry);
				}
			}
		}

		private void finishButton_Click(object sender, EventArgs e)
		{
			foreach (var entry in cartListBox.Items)
			{
				var book = (Book) entry;
				book.Lended = radioLend.Checked;
			}
			bookListSource.ResetBindings(false);
			cartListBox.Items.Clear();
			isbnTextBox.Text = String.Empty;
			isbnTextBox.Focus();
			myLibrary.SaveFile();

		}

		private void radioLend_CheckedChanged(object sender, EventArgs e)
		{
			finishButton.Text = "Lend Books";
		}

		private void radioReturn_CheckedChanged(object sender, EventArgs e)
		{
			finishButton.Text = "Return Books";
		}
	}
}