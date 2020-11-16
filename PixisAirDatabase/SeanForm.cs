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
    public partial class SeanForm : Form
    {
        IDbConnection connection;
        IDbDataAdapter dataAdapter;
        DataSet Employee;
        DataSet Job;
        string sql;
        string connectionString;

        public SeanForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connectionString = "Data Source=deathstar.gtc.edu;User ID=ITPA448;Initial Catalog=S101FF5C";
                //   sql = "SELECT EMPLOYEE.EFNAME, EMPLOYEE.ELNAME, JOBTYPE.JTNM FROM EMPLOYEE INNER JOIN JOBTYPE ON EMPLOYEE.EMPNO = JOBTYPE.JTID";
                sql = "SELECT * FROM EMPLOYEE";
                connection = new iDB2Connection(connectionString);

                dataAdapter = new iDB2DataAdapter(sql, connection);

                Employee = new DataSet();
                dataAdapter.Fill(Employee);

                foreach (DataRow pRow in Employee.Tables[0].Rows)
                    listBox1.Items.Add(pRow[1] + " " + pRow[2]);

                connection.Close();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connectionString = "Data Source=deathstar.gtc.edu;User ID=ITPA448;Initial Catalog=S101FF5C";
                //   sql = "SELECT EMPLOYEE.EFNAME, EMPLOYEE.ELNAME, JOBTYPE.JTNM FROM EMPLOYEE INNER JOIN JOBTYPE ON EMPLOYEE.EMPNO = JOBTYPE.JTID";
                sql = "SELECT * FROM JOBTYPE";
                connection = new iDB2Connection(connectionString);

                dataAdapter = new iDB2DataAdapter(sql, connection);

                Job = new DataSet();
                dataAdapter.Fill(Job);

                foreach (DataRow pRow in Job.Tables[0].Rows)
                    listBox1.Items.Add(pRow[3] + " " + pRow[4]);

                connection.Close();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlexisForm aForm = new AlexisForm();
            aForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DavidForm dForm = new DavidForm();
            dForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            JoshuaForm jForm = new JoshuaForm();
            jForm.Show();
        }
    }
}
