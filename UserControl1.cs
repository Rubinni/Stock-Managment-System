using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SMTS
{


    public partial class UserControl1: UserControl
    {

        EmployeeRepo employeeRepo = new EmployeeRepo();

        public UserControl1()  
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //the method will check the user cridentials and opens a new window 

            this.login();
            

        }

        private void login()
        {
            dbConnection connection = new dbConnection();

            string username = userName.Text;
            string password = userPassword.Text;


            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //will exit the code
            Application.Exit();
        }

        private void UserPassword_TextChanged(object sender, EventArgs e)
        {
            //will hide the password 
            userPassword.UseSystemPasswordChar = true;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
