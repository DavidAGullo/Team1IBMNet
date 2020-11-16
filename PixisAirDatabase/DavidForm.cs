using IBM.Data.DB2.iSeries;
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
    public partial class DavidForm : Form
    {
        iDB2Connection connection;
        iDB2DataAdapter dataAdapter;
        DataSet dataset;

        string sql;
        string connectionString;

        public DavidForm()
        {
            InitializeComponent();
        }

        private void DavidForm_Load(object sender, EventArgs e)
        {
            try
            {
                lBoxData.Items.Add("Data Load was Successful");
                //Connection string
                connectionString = "Data Source = deathstar.gtc.edu; User ID = itpa452; Initial Catalog = S101FF5C";
                //SQL Statement
                sql = "SELECT * FROM EMPLOYEES";
                connection = new iDB2Connection(connectionString);  //Assign connection string to the idb2 connection object
                dataAdapter = new iDB2DataAdapter(sql, connection); //Assign idb2 connection and sql statement to the data adapter

                dataset = new DataSet();    //New DataSet
                dataAdapter.Fill(dataset);  //Fill data adapter with data set

                foreach (DataRow data in dataset.Tables[0].Rows)
                {
                    lBoxData.Items.Add("Name: " + data[1] + data[2] + " | Employee Number: " + data[0]);
                }
            }
            catch(Exception ee)
            {
                Console.WriteLine("Error Code");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            string listInd = lBoxData.SelectedIndex.ToString();
            int listIndInt = Convert.ToInt32(listInd);

            try
            {
                //Connection string
                connectionString = "Data Source = deathstar.gtc.edu; User ID = itpa452; Initial Catalog = S101FF5C";
                //SQL Statement
                sql = "SELECT * FROM EMPLOYEES";
                connection = new iDB2Connection(connectionString);  //Assign connection string to the idb2 connection object
                dataAdapter = new iDB2DataAdapter(sql, connection); //Assign idb2 connection and sql statement to the data adapter

                dataset = new DataSet();    //New DataSet
                dataAdapter.Fill(dataset);  //Fill data adapter with data set

                DataRow data = dataset.Tables[0].Rows[listIndInt];
                tBoxState.Text = data[5].ToString();
                
            }
            catch(Exception ee) { Console.WriteLine("How'd dis Happen, like you loaded the page just fine?"); }
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlexisForm aForm = new AlexisForm();
            aForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JoshuaForm jForm = new JoshuaForm();
            jForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeanForm sForm = new SeanForm();
            sForm.Show();
        }
    }
}
