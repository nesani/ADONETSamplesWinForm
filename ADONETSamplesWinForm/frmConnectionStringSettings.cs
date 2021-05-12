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

namespace ADONETSamplesWinForm
{
    public partial class frmConnectionStringSettings : Form
    {
        public frmConnectionStringSettings()
        {
            InitializeComponent();
        }

        private void btnOpenConnection_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(tbConnectionString.Text);

                sqlConnection.Open();

                rtbDisplay.Text = GetConnectionInformation(sqlConnection);

                sqlConnection.Close();
                sqlConnection.Dispose();
            }

            catch(Exception ex)
            {
                rtbDisplay.Text = ex.ToString();
            }

        }


        private string GetConnectionInformation(SqlConnection sqlConnection)
        {
            StringBuilder stringBuilder = new StringBuilder(1024);

            stringBuilder.AppendLine($"Connection String: {sqlConnection.ConnectionString}");
            stringBuilder.AppendLine($"State: {sqlConnection.State.ToString()}");
            stringBuilder.AppendLine($"ConnectionTimeout: {sqlConnection.ConnectionTimeout.ToString()}");
            stringBuilder.AppendLine($"Database: {sqlConnection.Database}");
            stringBuilder.AppendLine($"Datasource: {sqlConnection.DataSource}");
            stringBuilder.AppendLine($"Server Version: {sqlConnection.ServerVersion}");
            stringBuilder.AppendLine($"Workstation ID: {sqlConnection.WorkstationId}");

            return stringBuilder.ToString();
        }

        private void frmOpenConnectionUsingBLocks_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(tbConnectionString.Text))
                {
                    sqlConnection.Open();
                    rtbDisplay.Text = GetConnectionInformation(sqlConnection);
                }
            }

            catch (Exception ex)
            {
                rtbDisplay.Text = ex.ToString();
            }

        }

        private void btnOpenConnectionWithErrors_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(tbConnectionString.Text))
                {
                    //sqlConnection.Open();
                    rtbDisplay.Text = GetConnectionInformation(sqlConnection);
                }
            }

            catch (Exception ex)
            {
                rtbDisplay.Text = ex.ToString();
            }
        }
    }
}
