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

        private void button1_Click(object sender, EventArgs e)
        {
            Label l1 = new Label();
            l1.Text = "Button has not been clicked";
            l1.Visible = true;
        }
    }
}
