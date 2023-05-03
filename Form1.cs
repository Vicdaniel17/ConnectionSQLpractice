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

namespace PracticeConnectionSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = ASSMCA43532;Initial Catalog = DWQueue; Integrated Security= true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string query = "Select * from MessageQueue";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string output = "Output = " + reader.GetValue(0) + "-" + reader.GetValue(1) + "-" + reader.GetValue(2);
                MessageBox.Show(output);
            }
        }
    }
}
