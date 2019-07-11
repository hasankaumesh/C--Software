using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace task1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string uname, pw;

            try
            {
                uname = txtUname.Text;
                pw = txtPw.Text;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database\Task1\task.mdf;Integrated Security=True;Connect Timeout=30");
                string qry = "SELECT name,pass FROM signup WHERE name='"+uname+"' AND pass='"+pw+"'";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();

                    if(sdr.Read())
                    {
                        MessageBox.Show("Welcome!");

                        Home hm = new Home();
                        hm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect User Name or Passsword!");
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            catch(SqlException es)
            {
                MessageBox.Show("" + es);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtUname.Text = null;
            txtPw.Text = null;

        }

        private void SignUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signup sp = new Signup();
            sp.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you going to exit", "Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
                
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
