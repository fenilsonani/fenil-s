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
using System.Data.Sql;
namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SAKIP02;Initial Catalog=fenil;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fenilDataSet.state' table. You can move, or remove it, as needed.
            this.stateTableAdapter.Fill(this.fenilDataSet.state);
            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from country", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["name"]);
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedCountry = comboBox1.SelectedItem.ToString();

            con.Close();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from country c inner join state s on c.con_id=s.con_id where c.name='" + selectedCountry + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["name"]);
            }
            con.Close();
        }
    }
}
