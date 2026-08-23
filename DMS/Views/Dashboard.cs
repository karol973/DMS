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

namespace DMS
{
    public partial class Dashboard : Form
    {
       // SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BISIMB9S\SQLEXPRESS;Initial Catalog=DentalMS;Integrated Security=true");
       // SqlCommand cmd;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            panel1.Visible = true; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BISIMB9S\SQLEXPRESS;Initial Catalog=Dental;Integrated Security=true");
                SqlCommand cmd;
                con.Open();
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string adress = txtAdress.Text;
                string gender = comboGender.Text;
                string blood = txtBloodGroup.Text;
                string info = txtAddInfo.Text;
                int age = Convert.ToInt32(txtAge.Text);
                int phone = Convert.ToInt32(txtPhone.Text);
                int pid = Convert.ToInt32(txtPid.Text);
                cmd = new SqlCommand ( "insert into AddPatient values ('" + name + "','" + surname + "','" + adress + "','" + gender + "','" + blood + "','" + info + "','" + age + "','" + phone + "','" + pid + "')",con);
               // cmd = new SqlCommand("insert into AddPatient values('" + txtName.Text + "','" + txtSurname.Text + "','" + txtAdress.Text + "','" + comboGender.Text + "','" + txtBloodGroup.Text + "','" + txtAge.Text + "','" + txtPhone.Text + "','" + txtAddInfo.Text + "','" + txtPid.Text + "')", con);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Dodano");
                con.Close();
                
               // SqlConnection con = new SqlConnection(@"data source = LAPTOP - BISIMB9S\SQLEXPRESS; database = DentalMS; integrated security = true;");
                //con.ConnectionString = "@"data source = LAPTOP - BISIMB9S\\SQLEXPRESS; database = DentalMS; integrated security = true;";
               // SqlCommand cmd = new SqlCommand();
               //SqlCommand cmd;
                // cmd.Connection = con;
               // con.Open();
                //cmd.CommandText="insert into AddPatient values ('" +name+ "','" + surname +"','"+ adress + "','" + gender + "','" + blood + "','" + info + "','" + age + "','" + phone + "','" +pid +"')",con);
                //cmd= new SqlCommand ( "insert into AddPatient values ('" + name + "','" + surname + "','" + adress + "','" + gender + "','" + blood + "','" + info + "','" + age + "','" + phone + "','" + pid + "')",con);
               // cmd = new SqlCommand("insert into AddPatient values ('" + txtName.Text + "','" + txtSurname.Text + "','" + txtAdress.Text + "','" + comboGender.Text + "','" + txtBloodGroup.Text + "','" + txtAddInfo.Text + "','" + txtAge.Text + "','" + txtPhone.Text + "','" + txtPid.Text + "')", con);
               // cmd.ExecuteNonQuery();

                //SqlDataAdapter DA = new SqlDataAdapter(cmd);
                //DataSet DS = new DataSet();
                //DA.Fill(DS);
                //con.Close();
                    }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            MessageBox.Show("Dane zostały zapisane");
            txtName.Clear();
            txtSurname.Clear();
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int pid = Convert.ToInt32(textBox1.Text);
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BISIMB9S\SQLEXPRESS;Initial Catalog=Dental;Integrated Security=true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddPatient where pid =" + pid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0]; 
               
            }
        }
    }
}
