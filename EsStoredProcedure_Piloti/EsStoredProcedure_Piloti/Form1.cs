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

namespace EsStoredProcedure_Piloti
{
    public partial class Form1 : Form
    {
        public static string WORKING_PATH = @"C:\Users\Rathore\GitHub - Projects\info-playground-LookAtOmkar\EsStoredProcedure_Piloti\ES_StoredProcedure_Piloti.mdf";
        public static string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+WORKING_PATH+";Integrated Security = True; Connect Timeout = 30";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                string sql = "ES1";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter teamcode = new SqlParameter();
                teamcode.ParameterName = "code";
                teamcode.Direction = ParameterDirection.Input;
                teamcode.DbType = DbType.String; // Tipo di dato
                teamcode.Size = 50;  //Dimensione del dato
                teamcode.Value = "IT";
                cmd.Parameters.Add(teamcode);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                MessageBox.Show("Result--->  ok" );
            }
           
        }
    }
}
