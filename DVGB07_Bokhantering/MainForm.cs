using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVGB07_Bokhantering
{
	public partial class MainForm : Form
	{
		private Library myLibrary;
		private BindingSource bookListSource;
		
		public MainForm()
		{
			InitializeComponent();
			bookListSource = new BindingSource();
			myLibrary = new Library();
			myLibrary.LoadFile();
			bookListSource.DataSource = myLibrary.BookList;
		}
		
		private void MainForm_Load(object sender, EventArgs e)
		{
			// Add controller to Management tab on startup
			ManagementControl management = new ManagementControl(myLibrary, bookListSource);
			management.Dock = DockStyle.Fill;
			managementTab.Controls.Add(management);
			
			LendingControl lending = new LendingControl(myLibrary, bookListSource);
			lending.Dock = DockStyle.Fill;
			lendingTab.Controls.Add(lending);
			AcceptButton = lending.AddToCartButton; //enter button makes us press the add to cart button
		}
	}
	
}