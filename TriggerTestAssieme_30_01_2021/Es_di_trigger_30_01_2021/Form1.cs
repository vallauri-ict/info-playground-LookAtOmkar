using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace Es_di_trigger_30_01_2021
{
    public partial class Form1 : Form
    {
        public const string WORKING_PATH = @"C:\Users\Rathore\Es_di_trigger_30_01_2021\Es_di_trigger_30_01_2021\bin\Debug\";
        public const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename"+WORKING_PATH+@"DriverDB.mdf;Integrated Security=True;";
        public DataTable datatable;

        private BindingSource bsDriver = new BindingSource();
        private BindingSource bsStoricoCancellazioni = new BindingSource();
        private BindingSource bsStoricoAggiornamenti = new BindingSource();
        private DataTable dtDriver, dtStoricoCancellazioni, dtStoricoAggiornamenti;
        private SqlDataAdapter daDriver, daStoricoCancellazioni, daStoricoAggiornamenti;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            string[] tables = { "Driver", "StoricoCancellazioni" };
            dgvTable.DataSource = GetDataTable(tables[0]);
            */
            PopulateDGV(0);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            daDriver.Update(dtDriver);
            PopulateDGV(0);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(Interaction.InputBox("Inserisci Data: "));
            using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
            {
                string sql = "RecordInserted_Aggiornamenti";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter data = new SqlParameter();
                data.ParameterName = "data";
                data.Direction = ParameterDirection.Input;
                data.DbType = DbType.DateTime;
                data.Value = dt;
                cmd.Parameters.Add(data);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader  = cmd.ExecuteReader();
                dtStoricoAggiornamenti.Load(reader);
                dgvStoricoAggiornamenti.DataSource = dtStoricoAggiornamenti;


                sql = "RecordInserted_Cancellazioni";
                cmd = new SqlCommand(sql, con);
                data = new SqlParameter();
                data.ParameterName = "data";
                data.Direction = ParameterDirection.Input;
                data.DbType = DbType.DateTime;
                data.Value = dt;
                cmd.Parameters.Add(data);

                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
                dtStoricoCancellazioni.Load(reader);
                dgvStoricoCancellazioni.DataSource = dtStoricoCancellazioni;
            }
        }

        private void OnRowsDeletedDriver(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            daDriver.Update(dtDriver);
            //MessageBox.Show("Riga cancellata su DB");
            PopulateDGV(2);
        }



        private void PopulateDGV(int tables)
        {
            switch (tables)
            {
                case 0:
                    dgvDriver.DataSource = bsDriver;
                    Query("SELECT * FROM Driver", out daDriver);
                    if (daDriver != null)
                    {
                        dtDriver = new DataTable();
                        daDriver.Fill(dtDriver);
                        bsDriver.DataSource = dtDriver;
                    }
                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                    dgvStoricoCancellazioni.DataSource = bsStoricoCancellazioni;
                    Query("SELECT * FROM StoricoCancellazioni", out daStoricoCancellazioni);
                    if (daStoricoCancellazioni != null)
                    {
                        dtStoricoCancellazioni = new DataTable();
                        daStoricoCancellazioni.Fill(dtStoricoCancellazioni);
                        bsStoricoCancellazioni.DataSource = dtStoricoCancellazioni;
                    }

                    dgvStoricoCancellazioni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                    dgvStoricoAggiornamenti.DataSource = bsStoricoAggiornamenti;
                    Query("SELECT * FROM StoricoAggiornamenti", out daStoricoAggiornamenti);
                    if (daStoricoAggiornamenti != null)
                    {
                        dtStoricoAggiornamenti = new DataTable();
                        daStoricoAggiornamenti.Fill(dtStoricoAggiornamenti);
                        bsStoricoAggiornamenti.DataSource = dtStoricoAggiornamenti;
                    }

                    dgvStoricoAggiornamenti.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
                case 1:
                    dgvDriver.DataSource = bsDriver;
                    Query("SELECT * FROM Driver", out daDriver);
                    if (daDriver != null)
                    {
                        dtDriver = new DataTable();
                        daDriver.Fill(dtDriver);
                        bsDriver.DataSource = dtDriver;
                    }
                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
                case 2:
                    dgvStoricoCancellazioni.DataSource = bsStoricoCancellazioni;
                    Query("SELECT * FROM StoricoCancellazioni", out daStoricoCancellazioni);
                    if (daStoricoCancellazioni != null)
                    {
                        dtStoricoCancellazioni = new DataTable();
                        daStoricoCancellazioni.Fill(dtStoricoCancellazioni);
                        bsStoricoCancellazioni.DataSource = dtStoricoCancellazioni;
                    }

                    dgvStoricoCancellazioni.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
                case 3:
                    dgvStoricoAggiornamenti.DataSource = bsStoricoAggiornamenti;
                    Query("SELECT * FROM StoricoAggiornamenti", out daStoricoAggiornamenti);
                    if (daStoricoAggiornamenti != null)
                    {
                        dtStoricoAggiornamenti = new DataTable();
                        daStoricoAggiornamenti.Fill(dtStoricoAggiornamenti);
                        bsStoricoAggiornamenti.DataSource = dtStoricoAggiornamenti;
                    }

                    dgvStoricoAggiornamenti.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
            }
        }

        private void Query (string selectCommand,out SqlDataAdapter da)
        {
            da = null;
            try
            {
                //Creo un nuovo data adapter basato su selectCommand
                da = new SqlDataAdapter(selectCommand, CONNECTION_STRING);

                //Creo un commandBuilder per generare un comando SQL
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message) ;
            }

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
    }
}
