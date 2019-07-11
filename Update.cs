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
    public partial class Update : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database\Task1\task.mdf;Integrated Security=True;Connect Timeout=30");
        public Update()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int b_id = int.Parse(textBox1.Text);
            string p_name = textBox2.Text;
            string qun = textBox3.Text;
            string rec_date = textBox4.Text;
            string rel_date = textBox5.Text;
            string visco = textBox6.Text;
            string ph = textBox7.Text;
            string density = textBox8.Text;
            string solid = textBox9.Text;
            string color = textBox10.Text;
            //string wash;
            //string crocking;
            //string result;

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE product SET p_name='" +p_name+ "' , quntity='"+qun+ "',rec_date='"+rec_date+"',rel_date='"+rel_date+"',viscosity='"+visco+"',ph='"+ph+"',density='"+density+"',solid='"+solid+"',color='"+color+"' WHERE batch_no='" + b_id + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();
                MessageBox.Show("Update data successfully");
            }
            catch (SqlException es)
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

        private void Button2_Click(object sender, EventArgs e)
        {
            
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
