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

namespace Tshepo_Tladi
{
    public partial class Form2 : Form
    {
        private const string ConnectionString = "Data Source=(local);Initial Catalog=SurveyDB;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            this.Hide();
            F1.Show();

            string Sname = txtSurname.Text;
            string Fname = txtFname.Text;
            int Contact = int.Parse(txtCntct.Text);
            //int Date = dtPicker.Value();
            int Age = int.Parse(txtAge.Text);

            bool likesPizza = cBoxPizza.Checked;
            bool likesPasta = cBoxPasta.Checked;
            bool likesPap = cBoxPap.Checked;
            bool likesChicken = cBoxChicken.Checked;
            bool likesBeef = cBoxBeef.Checked;
            bool likesOther = cBoxOther.Checked;
           

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO SurveyData (Name, Surname, Contact, Age, Pizza, Pap, Chicken, Beef, Pasta, Other) " +
                               "VALUES (@Name, @Surname, @Contact, @Age, @LikesPizza, @LikesPap, @LikesChicken, @LikesBeef, @LikesPasta, @LikesOther)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", Fname);
                    command.Parameters.AddWithValue("@Surname", Sname);
                    command.Parameters.AddWithValue("@Contact", Contact);
                    command.Parameters.AddWithValue("@Age", Age);
                    command.Parameters.AddWithValue("@LikesPizza", likesPizza);
                    command.Parameters.AddWithValue("@LikesPap", likesPap);
                    command.Parameters.AddWithValue("@LikesChicken", likesChicken);
                    command.Parameters.AddWithValue("@LikesBeef", likesBeef);
                    command.Parameters.AddWithValue("@LikesPasta", likesPasta);
                    command.Parameters.AddWithValue("@LikesOther", likesOther);




                    command.ExecuteNonQuery();
                }

                // private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
               
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
