using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectPart1
{
    public partial class Form3 : Form
    {
        public bool IsAdmin { get; private set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string pass;
            string data;
            string connectionString = @"Data Source=LAB108PC18\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString)) {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT pass, date_ from User_Profiles where username = @username", con);
                    cmd.Parameters.AddWithValue("@username", username);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable resultTable = new DataTable();
                    adapter.Fill(resultTable);
                    if (resultTable.Rows.Count > 0)
                    {
                        pass = (string)resultTable.Rows[0]["pass"];
                        data = (string)resultTable.Rows[0]["date_"];
                    }
                    else{
                        MessageBox.Show("No such user!");

                    }
                } catch (Exception ex) {
                    MessageBox.Show("Error");
                
                }
                
            
            
            }
            if (username == "Daniel" && password == "123456789")
            {
                IsAdmin = true;
                DialogResult = DialogResult.OK;
                Form2 forma2 = new Form2(true);
                forma2.Show();
            }
            else
            {
                
                IsAdmin = false;
                DialogResult = DialogResult.OK;
                Form2 forma2 = new Form2(false);
                forma2.Show();
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string password1 = passwordTextBox.Text;
            string password2 = textBox1.Text;

            string Pattern = "^(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_&?*])[A-Za-z0-9!@#$%_&?*]{8,}$";
            if (Regex.IsMatch(password1, Pattern) && password1.Equals(password2))
            {
                MessageBox.Show("Valid");
                string salt = "";
                string salt1;
                salt = DateTime.Now.ToString();
                salt1 = salt;
                string password = textBox1.Text;
                string hashedpass = hashpassword($"{password}{salt}");
                MessageBox.Show(hashedpass);
                SqlConnection con = new SqlConnection(@"Data Source=LAB108PC18\SQLEXPRESS;Initial Catalog=Tourism;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO User_Profiles (Personid, username, date_, pass) VALUES (2,@username, @salt, @hashedpass)", con);
                        cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@salt", salt);
                cmd.Parameters.AddWithValue("@hashedpass", hashedpass);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Added to the Database");

                    
                
            }
            else {
                MessageBox.Show("Invalid");
            }


        }
        string hashpassword(string text) { 
        SHA256 hashAlgorithm = SHA256.Create();
        var bytes = Encoding.Default.GetBytes(text);
        var hash = hashAlgorithm.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
        }
    }
}
    