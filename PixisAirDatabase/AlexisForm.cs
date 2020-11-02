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
   /*
    * Author: Alexis J. Varas
    * Program: Search Staff by Flight Number
    * Date: 11/2/2020
    * 
    * This application is programmed to take an input from tge user
    * (flight number) and display all of the staff that is assigned
    * to that flight. It aslo has functionality to access the other
    * form applications on this project
    */
    public partial class AlexisForm : Form
    {
        public AlexisForm()
        {
            InitializeComponent();
        }

        private void AlexisForm_Load(object sender, EventArgs e)
        {

        }

        //Exit Button
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();    //Closes the form
        }
        //Exit Menu Item
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Employees/Job Form Button (Sean's Form)
        private void employeeFormButton_Click(object sender, EventArgs e)
        {
            SeanForm sForm = new SeanForm();    //Instantiate Form
            sForm.Show();   //Opens Employees/Job Form
            Close();        //Closes Staff by Flight Number Form
        }
        ////Employees/Job Form Menu Item (Sean's Form)
        private void employeesFormMenuItem_Click(object sender, EventArgs e)
        {
            SeanForm sForm = new SeanForm();
            sForm.Show();
            Close();
        }
        
        //Regional Employees Form Button (Joshua's Form)
        private void regionalFormButton_Click(object sender, EventArgs e)
        {
            JoshuaForm jForm = new JoshuaForm();
            jForm.Show();
            Close();
        }
        //Regional Employees Form Menu Item (Joshua's Form)
        private void regionalFormMenuItem_Click(object sender, EventArgs e)
        {
            JoshuaForm jForm = new JoshuaForm();
            jForm.Show();
            Close();
        }

        //Employee's State Form Button (Daid's Form)
        private void stateFormButton_Click(object sender, EventArgs e)
        {
            DavidForm dForm = new DavidForm();
            dForm.Show();
            Close();
        }
        //Employee's State Form Menu Item (Daid's Form)
        private void stateFormMenuItem_Click(object sender, EventArgs e)
        {
            DavidForm dForm = new DavidForm();
            dForm.Show();
            Close();
        }
    }
}
