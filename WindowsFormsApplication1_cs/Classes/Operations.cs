using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;
// ReSharper disable PossibleNullReferenceException

namespace WindowsFormsApplication1_cs.Classes
{
    public class Operations
    {
        public string ConnectionString { get; set; }
        /// <summary>
        /// SQL-Server name returned in GetConnection method
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// SQL-Server database returned in GetConnection method
        /// </summary>
        public string InitialCatalog { get; set; }
        /// <summary>
        /// Table names in ServerName.InitialCatalog 
        /// </summary>
        public List<string> TableNames { get; set; }

        public static void CreateConnectionString()
        {
            var dcd = new DataConnectionDialog();

            var dcs = new DataConnectionConfiguration(null);

            dcs.LoadConfiguration(dcd);

            if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
            {
                var connectionString = dcd.ConnectionString;
                Console.WriteLine(connectionString);
            }
        }

        /// <summary>
        /// Create connection string using Microsoft's ConnectionUI class
        /// </summary>
        /// <param name="dataSource">Default catalog</param>
        /// <param name="saveConfiguration">true to save, false not to save</param>
        /// <returns></returns>
        public bool GetConnection(ref string dataSource, bool saveConfiguration = false)
        {
            var success = false;

            var dcd = new DataConnectionDialog();

            var dcs = new DataConnectionConfiguration(AppDomain.CurrentDomain.BaseDirectory);

            dcs.LoadConfiguration(dcd);

            if (DataConnectionDialog.Show(dcd) == DialogResult.OK)
            {
                DbProviderFactory factory = DbProviderFactories.GetFactory(dcd.SelectedDataProvider.Name);
                using (var connection = factory.CreateConnection())
                {
                    connection.ConnectionString = dcd.ConnectionString;
                    ConnectionString = connection.ConnectionString;
                    dataSource = connection.DataSource;
                    connection.Open();
                    var cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES";

                    var dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    TableNames = dt.AsEnumerable()
                        .Select(row => row.Field<string>("table_name"))
                        .OrderBy(field => field)
                        .ToList();
                }

                var builder = new SqlConnectionStringBuilder() { ConnectionString = dcd.ConnectionString };

                ServerName = builder.DataSource;
                InitialCatalog = builder.InitialCatalog;

                if (saveConfiguration)
                {
                    dcs.SaveConfiguration(dcd);
                }

                if (TableNames.Count > 0)
                {
                    success = true;
                }
            }

            return success;

        }
        /// <summary>
        /// Get column names for a table
        /// </summary>
        /// <param name="server">SQL-SERVER name</param>
        /// <param name="catalog">Initial catalog to work with</param>
        /// <param name="tableName">Existing table name in catalog</param>
        /// <returns></returns>
        public List<ColumnInformation> ColumnNameSelection(string server, string catalog, string tableName)
        {

            if (string.IsNullOrWhiteSpace(server))
            {
                return new List<ColumnInformation>();
            }
            var information = new List<ColumnInformation>();
            var dt = new DataTable();
            var connectionString = $"Data Source={server};Initial Catalog={catalog};Integrated Security=True";

            using (SqlConnection cn = new SqlConnection { ConnectionString = connectionString })
            {
                using (SqlCommand cmd = new SqlCommand { Connection = cn })
                {

                    cmd.CommandText = "SELECT COLUMN_NAME,DATA_TYPE,ORDINAL_POSITION " +
                                      "FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @TableName;";

                    cmd.Parameters.AddWithValue("@TableName", tableName);

                    cn.Open();

                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            information.Add(new ColumnInformation()
                            {
                                Name = reader.GetString(0),
                                DataType = reader.GetString(1),
                                Position = (int)reader.GetSqlInt32(2)
                            });
                        }
                    }
                }

            }

            return information;

        }
    }
}

