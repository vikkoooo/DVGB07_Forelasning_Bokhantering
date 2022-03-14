using System;
using System.Windows.Forms;

namespace DVGB07_Bokhantering
{
	public partial class AddBookForm : Form
	{
		public Book Book { get; set; }
		
		public AddBookForm()
		{
			InitializeComponent();
		}
		
		private void cancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			Book = new Book();
			Book.Title = titleTextBox.Text;
			Book.Author = authorTextBox.Text;
			Book.ISBN = isbnTextBox.Text;
			Book.Description = descriptionTextBox.Text;
			
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}