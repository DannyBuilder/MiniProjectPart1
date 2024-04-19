using System.Data.SqlClient;
using System.Drawing;

namespace MiniProjectPart1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAB108PC18\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True;Trusted_Connection=True;");

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateTownButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(townTextBox.Text) && !string.IsNullOrWhiteSpace(replacedTownTextBox.Text))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAB108PC18\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand("UPDATE Towns SET Town_Name = @city WHERE Town_Name = @replacedCity", con))
                    {
                        cmd.Parameters.AddWithValue("@city", townTextBox.Text);
                        cmd.Parameters.AddWithValue("@replacedCity", replacedTownTextBox.Text);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Town updated successfully");
                            townTextBox.Clear();
                            replacedTownTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Town not found for replacement");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid town names");
            }
        }

        private void AddTownButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(townTextBox.Text))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAB108PC18\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Towns VALUES (@city)", con))
                    {
                        cmd.Parameters.AddWithValue("@city", townTextBox.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Town added successfully");
                        townTextBox.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid town name");
            }
        }

        private void DeleteTownButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(townTextBox.Text))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=LAB108PC18\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Towns WHERE Town_Name = @city", con))
                    {
                        cmd.Parameters.AddWithValue("@city", townTextBox.Text);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Town deleted successfully");
                            townTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Town not found for deletion");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid town name");
            }
        }
    }
}