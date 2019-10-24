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
    
    public partial class Third : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database\Task1\task.mdf;Integrated Security=True;Connect Timeout=30");
        public Third()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string b_id= batchid.Text;
            string p_name = productname.Text;
            string qun= quntity.Text;
            string rec_date = dateTimePicker1.Text;
            string rel_date = dateTimePicker2.Text;
            string visco = visco.Text;
            string ph = phvalue.Text;
            string density = density.Text;
            string solid = solid.Text;
            string color = color.Text;
            string wash="";
            string crocking="";
            string result="";
           
            if (radioButton1.Checked)
            {
                wash = "Pass";
            }
            if(radioButton2.Checked)
            {
                wash = "Fail";
            }
            if (radioButton3.Checked)
            {
                crocking = "Fail";
            }
            if (radioButton4.Checked) 
            {
                crocking = "Pass";
            }
            if (radioButton5.Checked)
            {
                result = "Reject";
            }
            if (radioButton6.Checked)
            {
                result = "Approved";
            }



            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO product VALUES('" + b_id + "','" + p_name + "','" +qun+ "','"+rec_date+ "','"+rel_date+ "','"+visco+ "','"+ph+ "','"+density+ "','"+solid+ "','"+color+ "','"+wash+"','"+crocking+"','"+result+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();
                MessageBox.Show("Insert data successfully");

            }
            catch(SqlException es)
            {
                MessageBox.Show("" + es);
            }
            
        }

        public void disp_data()
        {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM product";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text=null;
            textBox2.Text = null;
            textBox3.Text = null;
            dateTimePicker1.Text = null;
            dateTimePicker2.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox9.Text = null;
            textBox10.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked =  false;
            radioButton6.Checked = false;
        }
    }
}
