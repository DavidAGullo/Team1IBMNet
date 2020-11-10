using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixisAirDatabase
{
    //Main Form Created By David
    public partial class mainForm : Form
    {
        
        
        
        
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DavidForm dForm = new DavidForm();
            dForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeanForm sForm = new SeanForm();
            sForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlexisForm aForm = new AlexisForm();
            aForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JoshuaForm jForm = new JoshuaForm();
            jForm.Show();
        }
    }
}
