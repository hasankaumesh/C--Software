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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Third thrd = new Third();
            thrd.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Second snd = new Second();
            snd.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            First fst = new First();
            fst.Show();
            this.Hide();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void InsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Third fm = new Third();
            fm.Show();
            this.Hide();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete dl = new delete();
            dl.Show();
            this.Hide();
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }
    }
}
