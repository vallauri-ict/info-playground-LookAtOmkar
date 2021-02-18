using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualBasic;


namespace ES_Funzione_06_02_21
{
    public partial class Form1 : Form
    {
        public static string WORKING_PATH = @"D:\SCUOLA\5B INF\Informatica\ES_Funzione_06_02_21\ESFunzione_DB.mdf";
        public static string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+WORKING_PATH+";Integrated Security=True;Connect Timeout=30";

        public DataTable datatable;
        public SqlDataAdapter daDriver;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDriver.DataSource = null;
        }

        private DataTable GetDataTable(string table)
        {
            datatable = new DataTable();
            SqlConnection con = new SqlConnection(CONNECTION_STRING);
            string sql = "SELECT * FROM " + table;
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(datatable);
            con.Close();
            da.Dispose();

            return datatable;
        }

        private void Query(string selectCommand, out SqlDataAdapter da)
        {
            da = null;
            try
            {
                //Creo un nuovo data adapter basato su selectCommand
                da = new SqlDataAdapter(selectCommand, CONNECTION_STRING);

                //Creo un commandBuilder per generare un comando SQL
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnDB_Click(object sender, EventArgs e)
        {
            dgvDriver.DataSource = null;
            dgvDriver.DataSource = GetDataTable("Driver");
        }

        private void btnFunzione1_Click(object sender, EventArgs e)
        {
            dgvDriver.DataSource = null;
            string country = Interaction.InputBox("Inserisci una nazione: ", "FUNZIONE 1");
            Query("SELECT * FROM dbo.Function_1('"+country.ToUpper()+"') AS Country;", out daDriver);
            if(daDriver !=null)
            {
                datatable = new DataTable();
                daDriver.Fill(datatable);
                dgvDriver.DataSource = datatable;
            }
            else
                MessageBox.Show("Errore Server/ nazione inesistente, riprova");
        }

        private void btnFunzione2_Click(object sender, EventArgs e)
        {
            dgvDriver.DataSource = null;
            int numPodi = Convert.ToInt32(Interaction.InputBox("Inserisci un numero di podi : ","FUNZIONE 2"));
            Query("SELECT dbo.Function_ES2('" + numPodi + "') as N_Piloti", out daDriver);
            try
            {
                if (daDriver != null)
                {
                    datatable = new DataTable();
                    daDriver.Fill(datatable);
                    dgvDriver.DataSource = datatable;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error : "+exp.Message);
            }
           
        }
    }
}
