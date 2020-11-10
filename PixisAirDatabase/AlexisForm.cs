using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

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
        iDB2Connection connection;
        iDB2DataAdapter dataAdapter;
        DataSet dataset;

        string sql;
        string connectionString;

        public AlexisForm()
        {
            InitializeComponent();
        }

        private void AlexisForm_Load(object sender, EventArgs e)
        {
            printInputStmt();   //Calling input statement method
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            staffListBox.Items.Clear();
            try
            {
                //Connection string
                connectionString = "Data Source = deathstar.gtc.edu; User ID = itpa472; Initial Catalog = S101FF5C";
                //SQL Statement
                    sql = "SELECT * FROM CREW";
                    connection = new iDB2Connection(connectionString);  //Assign connection string to the idb2 connection object
                dataAdapter = new iDB2DataAdapter(sql, connection); //Assign idb2 connection and sql statement to the data adapter

                dataset = new DataSet();    //New DataSet
                dataAdapter.Fill(dataset);  //Fill data adapter with data set

                string[] flights = new string[10];  //Array to hold valid flight numbers
                string number = flightTextBox.Text.ToUpper(); //initiate a variable with the value of the input textbox and convert to upper case
                int count = 0; //counter for the loop

                //Loop to add valid flight numbers into the flights array
                foreach (DataRow dataFields in dataset.Tables[0].Rows)
                {
                    flights[count] = dataFields[0].ToString();

                    if (number == flights[count])
                    {
                        sql = "SELECT * FROM CREW WHERE FLIGHTNO = " + number;
                        dataAdapter = new iDB2DataAdapter(sql, connection);
                        
                        staffListBox.Items.Add("Staff in Flight: " + number);
                        staffListBox.Items.Add("");
                        foreach (DataRow dataRow in dataset.Tables[0].Rows)
                        {
                            staffListBox.Items.Add("Pilots: " + dataFields[2]);
                            staffListBox.Items.Add("Attendants: " + dataFields[3]);
                            staffListBox.Items.Add("Clerk: " + dataFields[4]);
                            staffListBox.Items.Add("Maintenance: " + dataFields[5]);
                            staffListBox.Items.Add("Janitor: " + dataFields[6]);
                            staffListBox.Items.Add("Refueling: " + dataFields[7]);
                            staffListBox.Items.Add("");
                            break;
                        }
                        break;
                    }
                    else if (flights[count] != number && count == 9)
                    {
                        staffListBox.Items.Add("INVALID FLIGHT NUMBER!!!");
                        printInputStmt();
                    }
                    else
                        count++;
                }
                connection.Close(); //Close connection
            }
            catch (Exception ex)
            {
                staffListBox.Items.Add(ex.Message);
            }
        }

        public void printInputStmt()
        {
            //Loop to write input statement and valid flight numbers
            string[] inputStmt = {"", "Enter a flight number from the following list to view the Staff:", "",
                             "ATLORD5013", "ATLORD5015", "LAXLAS5021", "ORDATL5011",
                             "ORDATL5012", "ORDATL5013", "ORDATL5014", "ORDATL5015",
                             "ORDATL5016", "ORDATL5017" };

            for (int x = 0; x < inputStmt.Length; x++)
                staffListBox.Items.Add(inputStmt[x]);
        }
    }
}
