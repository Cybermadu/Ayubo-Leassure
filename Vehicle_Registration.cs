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

namespace Ayubo_Leassure
{
    public partial class Vehicle_Registration : Form
    {
        public Vehicle_Registration()
        {
            InitializeComponent();
        }

        private void Vehicle_Registration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=admin-pc\\sqlexpress;Initial Catalog=AYUBO_DRIVE;Integrated Security=True");

            string qry = "insert into VEHICLE_TABLE (Reg_no, Vehicle_type, model, brand, seating_cap, date) values('" + txtregno.Text + "', '" + txtvtyp.Text + "', '" + txtvmod.Text + "', '" + cmbvbrnd.SelectedItem + "', '" + txtstcap.Text+  "', '" + dateTimePicker1.Value + "')";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qry, cn);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Insertion Success");
            else
                MessageBox.Show("Error");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=admin-pc\\sqlexpress;Initial Catalog=AYUBO_DRIVE;Integrated Security=True");
            string qry = "Update VEHICLE_TABLE set vehicle_type = '" + txtvtyp.Text + "', model = '" + txtvmod.Text + "', brand = '" + cmbvbrnd.SelectedItem + "', seating_cap = '" + int.Parse(txtstcap.Text) + "', date = '" + dateTimePicker1.Value + "'where reg_no = '" + txtregno.Text + "' ;";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qry, cn);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Successfully Updated");
            else
                MessageBox.Show("Error");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=admin-pc\\sqlexpress;Initial Catalog=AYUBO_DRIVE;Integrated Security=True");
            string qry = "Delete from VEHICLE_TABLE where reg_no = '" + txtregno.Text + "';";
            cn.Open();
            SqlCommand cmd = new SqlCommand(qry, cn);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Successfully Deleted");
            else
                MessageBox.Show("Error");
        }
    }
} 