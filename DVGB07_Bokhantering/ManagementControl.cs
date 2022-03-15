using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVGB07_Bokhantering
{
	public partial class ManagementControl : UserControl
	{
		
		private BindingSource bookListSource;
		private Book selectedItem;
		private Library myLibrary;

		public ManagementControl(Library myLibrary, BindingSource bookListSource)
		{
			InitializeComponent();
			
			// gets the list from the main form
			this.bookListSource = bookListSource;
			this.myLibrary = myLibrary;
			
			bookDataGridView.DataSource = this.bookListSource;
		}

		// To display the content on our selected row in the display field to the right
		private void bookDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			if (bookDataGridView.SelectedRows.Count < 1)
			{
				SetTextEnabled(false);
				return;
			}
			// Get the item in the view that we have selected
			var book = (Book)bookDataGridView.SelectedRows[0].DataBoundItem;
			
			titleTextBox.Text = book.Title;
			authorTextBox.Text = book.Author;
			isbnTextBox.Text = book.ISBN;
			descriptionTextBox.Text = book.Description;
			
			selectedItem = book;
			saveButton.Enabled = false;
			cancelButton.Enabled = false;
			SetTextEnabled(true);
		}

		private void titleTextBox_TextChanged(object sender, EventArgs e)
		{
			saveButton.Enabled = true;
			cancelButton.Enabled = true;
		}

		private void authorTextBox_TextChanged(object sender, EventArgs e)
		{
			saveButton.Enabled = true;
			cancelButton.Enabled = true;
		}

		private void isbnTextBox_TextChanged(object sender, EventArgs e)
		{
			saveButton.Enabled = true;
			cancelButton.Enabled = true;
		}

		private void descriptionTextBox_TextChanged(object sender, EventArgs e)
		{
			saveButton.Enabled = true;
			cancelButton.Enabled = true;
		}
		
		private void cancelButton_Click(object sender, EventArgs e)
		{
			bookDataGridView_SelectionChanged(sender, null);
		}
		
		private void saveButton_Click(object sender, EventArgs e)
		{
			// update the book
			selectedItem.Author = authorTextBox.Text;
			selectedItem.Title = titleTextBox.Text;
			selectedItem.ISBN = isbnTextBox.Text;
			selectedItem.Description = descriptionTextBox.Text;
			
			// update ui
			bookListSource.ResetCurrentItem();
			
			// saveButton.Enabled = false;
			// cancelButton.Enabled = false;
			bookDataGridView_SelectionChanged(sender, null);
			myLibrary.SaveFile();


		}

		private void removeButton_Click(object sender, EventArgs e)
		{
			if (bookDataGridView.SelectedRows.Count < 1)
			{
				return;
			}
			// Get the item in the view that we have selected
			var book = (Book)bookDataGridView.SelectedRows[0].DataBoundItem;			
			
			// remove from the source
			bookListSource.Remove(book);
			authorTextBox.Text = String.Empty;
			titleTextBox.Text = String.Empty;
			isbnTextBox.Text = String.Empty;
			descriptionTextBox.Text = String.Empty;
			
			saveButton.Enabled = false;
			cancelButton.Enabled = false;
			bookDataGridView_SelectionChanged(sender, null);
			myLibrary.SaveFile();
		}

		private void SetTextEnabled(bool state)
		{
			titleTextBox.Enabled = state;
			authorTextBox.Enabled = state;
			isbnTextBox.Enabled = state;
			descriptionTextBox.Enabled = state;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			AddBookForm addBookForm = new AddBookForm();
			addBookForm.StartPosition = FormStartPosition.CenterParent;

			if (addBookForm.ShowDialog() == DialogResult.OK)
			{
				bookListSource.Add(addBookForm.Book);
				myLibrary.SaveFile();
			}
			else
			{
				return;
			}
			
		}
	}
}