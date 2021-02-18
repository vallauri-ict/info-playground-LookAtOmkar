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

namespace EsStoredProcedure01
{
    public partial class Form1 : Form
    {

        public static string WORKING_PATH = @"D:\SCUOLA\5B INF\Informatica\EsStoredProcedure01\StoredProcedure_DB.mdf";
        public static string CONNECTION_STRING= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+WORKING_PATH+";Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection())
            {
                string sql = "CercaFiliali";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql,con);
                SqlParameter nomeBanca = new SqlParameter();
                nomeBanca.ParameterName = "nomeBanca";
                nomeBanca.Direction = ParameterDirection.Input;
                nomeBanca.DbType = DbType.String; // Tipo di dato
                nomeBanca.Size = 50;  //Dimensione del dato
                nomeBanca.Value = "CRF";
                cmd.Parameters.Add(nomeBanca);

                SqlParameter comune = new SqlParameter();
                nomeBanca.ParameterName = "comune";
                nomeBanca.Direction = ParameterDirection.Input;
                nomeBanca.DbType = DbType.String; // Tipo di dato
                nomeBanca.Size = 50;  //Dimensione del dato
                nomeBanca.Value = "GENOLA";
                cmd.Parameters.Add(comune);

                cmd.CommandType = CommandType.StoredProcedure;
                int ris = cmd.ExecuteNonQuery();

                MessageBox.Show("Result: "+ris);
            }
        }
    }
}
