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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private const string ConnectionString = "Data Source=(local);Initial Catalog=SurveyDB;Integrated Security=True";

        private void Form3_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                connection.Open();


                string countQuery         = "SELECT COUNT(*) FROM SurveyData";
                string avgAgeQuery        = "SELECT AVG(Age) FROM SurveyData";
                string maxAgeQuery        = "SELECT MAX(Age) FROM SurveyData";
                string minAgeQuery        = "SELECT MIN(Age) FROM SurveyData";
                string likesPizzaQuery    = "SELECT COUNT(*) FROM SurveyData WHERE LikesPizza = 1";
                string averageRatingQuery = "SELECT AVG(Rating) FROM SurveyData";

                using (SqlCommand command = new SqlCommand(countQuery, connection))
                {
                    int totalCount = (int)command.ExecuteScalar();
                    lblTotalSurveys.Text = totalCount.ToString();
                }

                using (SqlCommand command = new SqlCommand(avgAgeQuery, connection))
                {
                    double averageAge = (double)command.ExecuteScalar();
                    lblAvgAge.Text = averageAge.ToString("F1");
                }

                using (SqlCommand command = new SqlCommand(maxAgeQuery, connection))
                {
                    int maxAge = (int)command.ExecuteScalar();
                    lblOldest.Text = maxAge.ToString();
                }

                using (SqlCommand command = new SqlCommand(minAgeQuery, connection))
                {
                    int minAge = (int)command.ExecuteScalar();
                    lblYoungest.Text = minAge.ToString();
                }

                using (SqlCommand command = new SqlCommand(likesPizzaQuery, connection))
                {
                    int totalCount = (int)command.ExecuteScalar();
                    int pizzaCount = (int)command.ExecuteScalar();
                    double pizzaPercentage = (pizzaCount / ((double)totalCount) * 100);
                    lblPizzaPercentage.Text = pizzaPercentage.ToString("F1") + "%";
                }

                using (SqlCommand command = new SqlCommand(averageRatingQuery, connection))
                {
                    double averageRating = (double)command.ExecuteScalar();
                    lblAvgRating.Text = averageRating.ToString("F1");
                }
            }
        }
    }
}
