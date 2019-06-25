using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=PURU;Initial Catalog=demo;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demoDataSet.demodatatable1' table. You can move, or remove it, as needed.
       //     this.demodatatable1TableAdapter.Fill(this.demoDataSet.demodatatable1);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             con.Open();
            var query = "";
            query = "INSERT into demodatatable1 VALUES(@name)";  
                                      
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted Successfully!!");  
                 
                    SqlCommand cmd1 = new SqlCommand( "SELECT * FROM demodatatable1", con);
                   cmd1.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                    sda.Fill(dt);
                    DataView dv = new DataView(dt);
                    gv.DataSource = dv;
            con.Close();




        }
    }
}
