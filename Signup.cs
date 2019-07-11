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

namespace task1
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            string uname,pos, pw,cpw;

            try
            {
                uname = txtName.Text;
                pos = txtPos.Text;
                pw = txtPw.Text;
                cpw = txtCpw.Text;

                if(uname!="" || pos!="" || pw!="" || cpw!="")
                {
                    if(pw==cpw)
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database\Task1\task.mdf;Integrated Security=True;Connect Timeout=30");
                        string qry = "INSERT INTO signup VALUES('" + uname + "','" + pos + "','" + pw + "','" + cpw + "')";
                        SqlCommand cmd = new SqlCommand(qry, con);

                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Your signIn Successfully");

                            txtName.Clear();
                            txtPos.Clear();
                            txtPw.Clear();
                            txtCpw.Clear();

                            login lg = new login();
                            lg.Show();
                            this.Hide();

                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("" + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and Confirm Password Not Matched");
                    }
                }
                else
                {
                    MessageBox.Show("Complete All Fields ");
                }
            }
            catch (FormatException es)
            {
                MessageBox.Show("Complete  all Feilds!" + es);
            }
            catch(Exception ec)
            {
                MessageBox.Show("Invalid Inputs" + ec);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = null;
            txtPos.Text = null;
            txtPw.Text = null;
            txtCpw.Text = null;

        }

        private void MainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main mn = new main();
            mn.Show();
            this.Hide();
        }
    }
}
