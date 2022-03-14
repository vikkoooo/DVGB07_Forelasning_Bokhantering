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
		public MainForm()
		{
			InitializeComponent();
		}


		private void MainForm_Load(object sender, EventArgs e)
		{
			// Add controller to Management tab on startup
			ManagementControl management = new ManagementControl();
			management.Dock = DockStyle.Fill;
			managementTab.Controls.Add(management);
		}
	}
}