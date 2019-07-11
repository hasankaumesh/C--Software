using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void SignInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signup sp = new Signup();
            sp.Show();
            this.Hide();
        }
    }
}
