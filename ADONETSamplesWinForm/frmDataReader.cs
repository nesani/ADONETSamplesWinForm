using ADONETSamplesWinForm.ClassProperties;
using ADONETSamplesWinForm.ExtensionMethods;
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
    public partial class frmDataReader : Form
    {
        public frmDataReader()
        {
            InitializeComponent();
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(1024);

            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.Product", sqlConnection))
                {
                    sqlConnection.Open();


                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (sqlDataReader.Read())
                        {
                            sb.AppendLine("Product: " + sqlDataReader["id"].ToString());
                            sb.AppendLine(sqlDataReader["Name"].ToString());
                            sb.AppendLine(Convert.ToDateTime(sqlDataReader["Date"]).ToShortDateString());
                            sb.AppendLine(Convert.ToDecimal(sqlDataReader["Price"]).ToString("c"));
                            sb.AppendLine();

                        }
                    }

                }
            }

            rtbDisplayData.Text = sb.ToString();

        }

        private void btnGetGenericList_Click(object sender, EventArgs e)
        {
            var product = new List<Product>();

            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.Product", sqlConnection))
                {
                    sqlConnection.Open();


                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (sqlDataReader.Read())
                        {
                            product.Add(new Product
                            {
                                ProductId = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("id")),
                                Name = sqlDataReader.GetString(sqlDataReader.GetOrdinal("Name")),
                                StartingDate = sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("Date")),
                                URL = sqlDataReader.GetString(sqlDataReader.GetOrdinal("URL")),
                                Price = sqlDataReader.GetDecimal(sqlDataReader.GetOrdinal("Price")),
                                RetireDate = sqlDataReader.IsDBNull(sqlDataReader.GetOrdinal("RetireDate")) ? (DateTime?)null : Convert.ToDateTime(sqlDataReader["RetireDate"]) 
                                
                            });

                        }
                    }

                }


            }

            foreach( var item in product)
            {
                tblDataGrid.Rows.Add(item.ProductId, item.Name, item.StartingDate,item.URL, item.Price, item.RetireDate );
            }

        }

        private void btnGetGenericAuto_Click(object sender, EventArgs e)
        {

            var product = new List<Product>();

            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.Product", sqlConnection))
                {
                    sqlConnection.Open();


                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (sqlDataReader.Read())
                        {
                            product.Add(new Product
                            {
                                ProductId = sqlDataReader.GetFieldValue<int>(sqlDataReader.GetOrdinal("id")),
                                Name = sqlDataReader.GetFieldValue<string>(sqlDataReader.GetOrdinal("Name")),
                                StartingDate = sqlDataReader.GetFieldValue<DateTime>(sqlDataReader.GetOrdinal("Date")),
                                URL = sqlDataReader.GetFieldValue<string>(sqlDataReader.GetOrdinal("URL")),
                                Price = sqlDataReader.GetFieldValue<decimal>(sqlDataReader.GetOrdinal("Price")),

                                //fieldValues does not work with nulls
                                //sqlDataReader.GetFieldValue<DateTime?>(sqlDataReader.GetOrdinal("RetireDate")),
                                RetireDate = sqlDataReader.IsDBNull(sqlDataReader.GetOrdinal("RetireDate")) ? (DateTime?)null : Convert.ToDateTime(sqlDataReader["RetireDate"])

                            });

                        }
                    }

                }


            }

            foreach (var item in product)
            {
                tblDataGrid.Rows.Add(item.ProductId, item.Name, item.StartingDate, item.URL, item.Price, item.RetireDate);
            }

        }

        private void btnGetGenericListWithHelpers_Click(object sender, EventArgs e)
        {
            var product = new List<Product>();

            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.Product", sqlConnection))
                {
                    sqlConnection.Open();


                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (sqlDataReader.Read())
                        {
                            product.Add(new Product
                            {
                                ProductId = sqlDataReader.GetFieldValue<int>("id"),
                                Name = sqlDataReader.GetFieldValue<string>("Name"),
                                StartingDate = sqlDataReader.GetFieldValue<DateTime>("Date"),
                                URL = sqlDataReader.GetFieldValue<string>("URL"),
                                Price = sqlDataReader.GetFieldValue<decimal>("Price"),
                                RetireDate = sqlDataReader.GetFieldValue<DateTime?>("RetireDate")

                            });

                        }
                    }

                }


            }

            foreach (var item in product)
            {
                tblDataGrid.Rows.Add(item.ProductId, item.Name, item.StartingDate, item.URL, item.Price, item.RetireDate);
            }

        }

        private void btnGetMultipleResults_Click(object sender, EventArgs e)
        {
            rtbDisplayData.Clear();

            var product = new List<Product>();
            var productCategory = new List<ProductCategory>();

            using (SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.Product; SELECT * FROM dbo.ProductCategory", sqlConnection))
                {
                    sqlConnection.Open();


                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (sqlDataReader.Read())
                        {
                            product.Add(new Product
                            {
                                ProductId = sqlDataReader.GetFieldValue<int>("id"),
                                Name = sqlDataReader.GetFieldValue<string>("Name"),
                                StartingDate = sqlDataReader.GetFieldValue<DateTime>("Date"),
                                URL = sqlDataReader.GetFieldValue<string>("URL"),
                                Price = sqlDataReader.GetFieldValue<decimal>("Price"),
                                RetireDate = sqlDataReader.GetFieldValue<DateTime?>("RetireDate")

                            });

                        }

                        sqlDataReader.NextResult();

                        while (sqlDataReader.Read())
                        {
                            productCategory.Add(new ProductCategory
                            {
                                ProductCategoryId = sqlDataReader.GetFieldValue<int>("id"),
                                Name = sqlDataReader.GetFieldValue<string>("Name"),

                            });

                        }


                    }

                }


            }

            foreach (var item in product)
            {
                tblDataGrid.Rows.Add(item.ProductId, item.Name, item.StartingDate, item.URL, item.Price, item.RetireDate);
            }

            foreach(var item in productCategory)
            {
                rtbDisplayData.Text += $"{item.ProductCategoryId} {item.Name} \n";
            }
        }
    }
}
