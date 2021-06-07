using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diplim_app { 

using MySql.Data.MySqlClient;

public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
           
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
          
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO users (firstname, lastname, email, login, parola) VALUES (@nume, @prenume, @mail, @log, @pass)", dB.getConnection());
            mySqlCommand.Parameters.Add("@nume", MySqlDbType.VarChar).Value= name.Text;
            mySqlCommand.Parameters.Add("@prenume", MySqlDbType.VarChar).Value = lastname.Text;
            mySqlCommand.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail.Text;
            mySqlCommand.Parameters.Add("@log", MySqlDbType.VarChar).Value = login.Text;
            mySqlCommand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passw.Text;
             dB.OpenConnection();


             if (mySqlCommand.ExecuteNonQuery() == 1)
                     MessageBox.Show("Succesful");
                 else
                     MessageBox.Show("Try again");



                 dB.CloseConnection();
            

           
        }
    }
}
