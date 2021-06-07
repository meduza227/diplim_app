using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplim_app
{
    public partial class start : Form
    {
        
        public start()
        {
            InitializeComponent();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            registration form2 = new registration();
            form2.Show();
            
            

           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            autoriz form3 = new autoriz();
            form3.Show();
           
           
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("fhjdhfkjdhfsd");
        }
    }
}
