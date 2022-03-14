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
		private BindingList<Book> bookList;
		private BindingSource bookListSource;
		
		public MainForm()
		{
			InitializeComponent();
			bookList = new BindingList<Book>()
			{
				new Book() { Title = "Linear Algebra", Author = "Poole", ISBN = "123", Description = "" },
				new Book() { Title = "The Invisible Computer", Author = "Donald Norman", ISBN = "234", Description = "" },
				new Book() { Title = "Datorsystem", Author = "Mats Brorsson", ISBN = "345", Description = "" }
			};
			bookListSource = new BindingSource();
			bookListSource.DataSource = bookList;
		}
		
		private void MainForm_Load(object sender, EventArgs e)
		{
			// Add controller to Management tab on startup
			ManagementControl management = new ManagementControl(bookListSource);
			management.Dock = DockStyle.Fill;
			managementTab.Controls.Add(management);
		}
	}
	
}