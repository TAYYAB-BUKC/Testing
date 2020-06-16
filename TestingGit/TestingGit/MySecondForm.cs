using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingGit
{
	public partial class MySecondForm : Form
	{
		public MySecondForm()
		{
			InitializeComponent();
		}

		private void MyButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This is my Second Form and I build it during your work", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); 
		}
	}
}
