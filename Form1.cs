using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid_term
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8FG361C;Initial Catalog=\"mid term\";Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(" insert into ut value(@id,@name, @age)", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
        
            con.Close();

            MessageBox.Show("successfully saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8FG361C;Initial Catalog=\"mid term\";Integrated Security=True;");

            con.Open();
            SqlCommand cmd = new SqlCommand(" update ut set name=@name, age=@age, where id=@id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@age", double.Parse(textBox3.Text));
      
            con.Close();

            MessageBox.Show("successfully update");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8FG361C;Initial Catalog=\"mid term\";Integrated Security=True;");

            con.Open();
            SqlCommand cmd = new SqlCommand("delete ut where id=@id" ,con);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
          
            con.Close();

            MessageBox.Show("successfully delete");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8FG361C;Initial Catalog=\"mid term\";Integrated Security=True;");

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ut", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        
    }
}
