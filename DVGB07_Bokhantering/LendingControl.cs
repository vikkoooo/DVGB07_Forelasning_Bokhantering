using System;
using System.Windows.Forms;

namespace DVGB07_Bokhantering
{
	public partial class LendingControl : UserControl
	{
		public Button AddToCartButton { get { return addToCartButton; } }
		private BindingSource bookListSource;
		
		public LendingControl(BindingSource bookListSource)
		{
			InitializeComponent();
			this.bookListSource = bookListSource;
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
		}


	}
}