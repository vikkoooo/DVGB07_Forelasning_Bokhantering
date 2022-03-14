using System.Windows.Forms;

namespace DVGB07_Bokhantering
{
	public partial class ManagementControl : UserControl
	{
		private BindingSource bookListSource;
		
		public ManagementControl(BindingSource bookListSource)
		{
			InitializeComponent();
			this.bookListSource = bookListSource;
			bookDataGridView.DataSource = this.bookListSource;
		}

	}
}