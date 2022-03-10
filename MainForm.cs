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

namespace LoginApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            load_record();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=LoginDB;Integrated Security=True");
            string query = "INSERT INTO [dbo].[Student_Data] ([StudentId],[studnetName],[course],[timetable],[sex],[contactNumber],[EmailId],[GPA],[Result]) VALUES('"+txtStudentId.Text+"','"+txtStudentName.Text+"', '"+txtCourse.Text+"','"+ txtTimeTable.Text + "','" + txtSex.Text + "','" + txtContactNumber.Text + "','" + txtEmailId.Text + "','" + txtGPA.Text + "','" + txtResult.Text + "')";
            var cmd = new SqlDataAdapter();
            SqlCommand s = new SqlCommand(query);
            s.Connection = sqlcon;
            cmd.InsertCommand = s;
            sqlcon.Open();
            cmd.InsertCommand.ExecuteNonQuery();
           // s.ExecuteNonQuery();
            sqlcon.Close();
            load_record();
        }
        void load_record()
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=LoginDB;Integrated Security=True");

            SqlCommand comm = new SqlCommand("select [StudentId],[studnetName],[course],[timetable],[sex],[contactNumber],[EmailId],[GPA],[Result] from Student_Data", sqlcon);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
           // dataGridView1.DataBindings();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
