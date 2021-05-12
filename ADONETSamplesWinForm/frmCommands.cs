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
    public partial class frmCommands : Form
    {
        public frmCommands()
        {
            InitializeComponent();
        }

        private void btnScallar_Click(object sender, EventArgs e)
        {

            //Textbox output rows Affected
            rtbOutput.Text = "0";

            //Create Select Statment to submit
            string sqlSelect = "SELECT COUNT(*) FROM dbo.Product";

            //Create Connection
            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {

                using (SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection))
                {
                    //Open Connection
                    sqlConnection.Open();
                    rtbOutput.Text = "Rows affected: " + sqlCommand.ExecuteScalar().ToString();
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            //Textbox output rows Affected
            rtbOutput.Text = "0";

            //Create Select Statment to submit
            string sqlInsert = $"INSERT INTO dbo.Product VALUES('{tbProductName.Text}', '{tbIntroductionDate.Text}', '{tbURL.Text}', '{tbPrice.Text}', NULL)";


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

        private void btnGetValuesUsingParameters_Click(object sender, EventArgs e)
        {

            //Textbox output rows Affected
            rtbOutput.Text = "0";

            //Create Select Statment to submit
            string sqlSelect = "SELECT COUNT(*) FROM dbo.Product WHERE Name Like @ProductName";

            //Create Connection
            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {

                using (SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection))
                {

                    sqlCommand.Parameters.Add(new SqlParameter("@ProductName", tbProductName.Text));
                    //Open Connection
                    sqlConnection.Open();
                    rtbOutput.Text = "Rows affected: " + sqlCommand.ExecuteScalar().ToString();
                }
            }

        }

        private void btnInsertWithParameters_Click(object sender, EventArgs e)
        {

            rtbOutput.Text = "0";

            //Create Select Statment to submit
            string sqlInsert = $"INSERT INTO dbo.Product VALUES(@ProductName,@IntroductionDate , @URL, @Price, @RetireDate)";


            try
            {
                //Create Connection
                using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {

                    using (SqlCommand sqlCommand = new SqlCommand(sqlInsert, sqlConnection))
                    {
                        //Defaukt option
                        sqlCommand.CommandType = CommandType.Text;

                        //Input Parameters
                        sqlCommand.Parameters.Add(new SqlParameter("@ProductName", tbProductName.Text));
                        sqlCommand.Parameters.Add(new SqlParameter("@IntroductionDate", tbIntroductionDate.Text));
                        sqlCommand.Parameters.Add(new SqlParameter("@URL", tbURL.Text));
                        sqlCommand.Parameters.Add(new SqlParameter("@Price", tbPrice.Text));
                        sqlCommand.Parameters.Add(new SqlParameter("@RetireDate", DBNull.Value));


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

        private void btnInsertWIthOutput_Click(object sender, EventArgs e)
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
                        sqlCommand.Parameters.Add(new SqlParameter("@ProductName", tbProductName.Text));
                        sqlCommand.Parameters.Add(new SqlParameter("@IntroductionDate", tbIntroductionDate.Text));
                        sqlCommand.Parameters.Add(new SqlParameter("@URL", tbURL.Text));
                        sqlCommand.Parameters.Add(new SqlParameter("@Price", tbPrice.Text));

                        //Output Parameter
                        sqlCommand.Parameters.Add(new SqlParameter { ParameterName = "@ProductId", Value = tbProductID.Text, IsNullable = false, DbType = DbType.Int32, Direction = ParameterDirection.Output });



                        //Open Connection
                        sqlConnection.Open();

                        rtbOutput.Text = "Rows affected: " + sqlCommand.ExecuteNonQuery();

                        tbProductID.Text = sqlCommand.Parameters["@ProductId"].Value.ToString();
                    }
                }
            }

            catch (Exception ex)
            {
                rtbOutput.Text = ex.ToString();
            }

        }

        private void btnInsertWithTransaction_Click(object sender, EventArgs e)
        {

            rtbOutput.Text = "0";

            //Create Select Statment to submit
            string sqlInsert = "ProductInsert";


            try
            {
                //Create Connection
                using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {


                    //Open Connection
                    sqlConnection.Open();

                    using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand sqlCommand = new SqlCommand(sqlInsert, sqlConnection))
                            {
                                sqlCommand.Transaction = sqlTransaction;

                                //Stored procedure
                                sqlCommand.CommandType = CommandType.StoredProcedure;

                                //Input Parameters
                                sqlCommand.Parameters.Add(new SqlParameter("@ProductName", tbProductName.Text));
                                sqlCommand.Parameters.Add(new SqlParameter("@IntroductionDate", tbIntroductionDate.Text));
                                sqlCommand.Parameters.Add(new SqlParameter("@URL", tbURL.Text));
                                sqlCommand.Parameters.Add(new SqlParameter("@Price", tbPrice.Text));

                                //Output Parameter
                                sqlCommand.Parameters.Add(new SqlParameter { ParameterName = "@ProductId", Value = tbProductID.Text, IsNullable = false, DbType = DbType.Int32, Direction = ParameterDirection.Output });




                                rtbOutput.Text = "Rows affected: " + sqlCommand.ExecuteNonQuery();

                                tbProductID.Text = sqlCommand.Parameters["@ProductId"].Value.ToString();


                                /////////////////////////////////////
                                ///SecondStatement
                                ////////////////////////////////////

                                sqlInsert = "INSERT INTO ProductCategory VALUES(@CategoryName)";

                                sqlCommand.CommandType = CommandType.Text;

                                sqlCommand.CommandText = sqlInsert;

                                sqlCommand.Parameters.Clear();

                                sqlCommand.Parameters.Add(new SqlParameter("@CategoryName", "New Name"));

                                sqlCommand.ExecuteNonQuery();

                                ///Complete transaction

                                sqlTransaction.Commit();


                            }
                        }

                        catch (Exception ex)
                        {
                            rtbOutput.Text = ex.ToString();
                            sqlTransaction.Rollback();
                        }

                    }
                }
            }

            catch (Exception ex)
            {
                rtbOutput.Text = ex.ToString();

            }

        }
    }
}
