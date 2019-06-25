using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\purushottam\documents\visual studio 2010\Projects\WindowsFormsApplication1\WindowsFormsApplication1\b1.mdf;Integrated Security=True;User Instance=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Log1 where name='" + tb1.Text + "' and pass='" + tb2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                
            this.Hide();
            md1 ss = new md1();
            ss.Show();
            }
            else
            {
                MessageBox.Show("incorrect data");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";

        }

        private void l1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
