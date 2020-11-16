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
    public partial class JoshuaForm : Form
    {
        iDB2Connection connection;
        iDB2DataAdapter dataAdapter;
        DataSet EMPLOYEE;

        public JoshuaForm()
        {
            InitializeComponent();
        }

        private void JoshuaForm_Load(object sender, EventArgs e)
        {
            string sql;
            string connectionString;
            try
            {
                connectionString = "Data Source = deathstar.gtc.edu; User ID = ITPA485; Initial Catalog = S101FF5C";
                sql = "SELECT * FROM EMPLOYEE";

                connection = new iDB2Connection(connectionString);

                dataAdapter = new iDB2DataAdapter(sql, connection);

                EMPLOYEE = new DataSet();
                dataAdapter.Fill(EMPLOYEE);
                
                foreach (DataRow pRow in EMPLOYEE.Tables[0].Rows)
                    listBox1.Items.Add(pRow[1] + "    " + pRow[2] + "     " + pRow[17]);


                connection.Close();

            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }

        }
    }
}
