using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace diplim_app
{
    public partial class autoriz : Form
    {
        public autoriz()
        {
            InitializeComponent();
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            // вызываем главную форму приложения, которая открыла текущую форму Form2, главная форма всегда = 0
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void buttonAvtoriz_Click(object sender, EventArgs e)
        {
            


        }
    }
}
