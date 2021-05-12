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
    public partial class frmExceptionHandling : Form
    {
        public frmExceptionHandling()
        {
            InitializeComponent();
        }

        private void btnSimpleException_Click(object sender, EventArgs e)
        {
            //Textbox output rows Affected
            rtbOutput.Text = "0";

            //Create Select Statment to submit
            //Misspeled product to generate error
            string sqlInsert = $"INSERT INTO dbo.Poduct VALUES('Error', '29/2/2021', 'www.DramaLamaError.com', '99', NULL)";


            try
            {
                //Create Connection
                using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {

                    using (SqlCommand sqlCommand = new SqlCommand(sqlInsert, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.Text;

                        //Open Connection
                        sqlConnection.Open();

                        rtbOutput.Text = "Rows affected: " + sqlCommand.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                rtbOutput.Text = ex.ToString();
            }
        }

        private void btnSQlException_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "0";

            //Create Select Statment to submit
            string sqlInsert = "ProductInsert";


            try
            {
                //Create Connection
                using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {

                    using (SqlCommand sqlCommand = new SqlCommand(sqlInsert, sqlConnection))
                    {
                        //Stored procedure
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        //Input Parameters
                        sqlCommand.Parameters.Add(new SqlParameter("@ProdutName", "SQL Exception"));
                        sqlCommand.Parameters.Add(new SqlParameter("@IntroductionDate", DateTime.Now));
                        sqlCommand.Parameters.Add(new SqlParameter("@URL", "www.SQLException.com"));
                        sqlCommand.Parameters.Add(new SqlParameter("@Price", 0));

                        //Output Parameter
                        sqlCommand.Parameters.Add(new SqlParameter { ParameterName = "@ProductId", Value = 5, IsNullable = false, DbType = DbType.Int32, Direction = ParameterDirection.Output });



                        //Open Connection
                        sqlConnection.Open();

                        rtbOutput.Text = "Rows affected: " + sqlCommand.ExecuteNonQuery();

                        //tbProductID.Text = sqlCommand.Parameters["@ProductId"].Value.ToString();
                    }
                }
            }

            catch (SqlException ex)
            {
                StringBuilder sb = new StringBuilder();

                for(int i = 0; i < ex.Errors.Count; i++)
                {
                    sb.AppendLine("Index #: " + i.ToString());
                    sb.AppendLine("Type: " + ex.Errors[i].GetType().FullName);
                    sb.AppendLine("Message: " + ex.Errors[i].Message);
                    sb.AppendLine("Source: " + ex.Errors[i].Source);
                    sb.AppendLine("Number: " + ex.Errors[i].Number.ToString());
                    sb.AppendLine("State: " + ex.Errors[i].State.ToString());
                    sb.AppendLine("Class: " + ex.Errors[i].Class.ToString());
                    sb.AppendLine("Server: " + ex.Errors[i].Server);
                    sb.AppendLine("Procedure: " + ex.Errors[i].Procedure);
                    sb.AppendLine("State: " + ex.Errors[i].LineNumber.ToString());

                }

                rtbOutput.Text = sb.ToString();
            }
        }

        private void btnSqlExceptionManager_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = null;
            SqlCommand sqlCommand = null;

            try
            {
                string sql = "Product_Insert";

                //Create SQL Connection
                sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);

                sqlCommand = new SqlCommand(sql, sqlConnection);


                //Stored procedure
                sqlCommand.CommandType = CommandType.StoredProcedure;

                //Input Parameters
                sqlCommand.Parameters.Add(new SqlParameter("@ProdutName", "SQL Exception"));
                sqlCommand.Parameters.Add(new SqlParameter("@IntroductionDate", DateTime.Now));
                sqlCommand.Parameters.Add(new SqlParameter("@URL", "www.SQLException.com"));
                sqlCommand.Parameters.Add(new SqlParameter("@Price", 0));

                sqlConnection.Open();

                rtbOutput.Text = "Rows affected: " + sqlCommand.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {

            }
        }
    }
}
