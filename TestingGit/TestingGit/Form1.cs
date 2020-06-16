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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void MyButton_Click(object sender, EventArgs e)
		{
            MessageBox.Show("Fahad's Form Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Fahad's Form Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
