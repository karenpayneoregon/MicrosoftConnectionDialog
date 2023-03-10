using Microsoft.Data.ConnectionUI;
using System;
using System.IO;
using System.Windows.Forms;

namespace DatabaseConnector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RemoveConfigurationFile();
        }

        private static void RemoveConfigurationFile()
        {
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataConnection.xml");
            if (File.Exists(fileName))
            {
                try
                {
                    File.Delete(fileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to remove file");
                }
            }
        }

        public static string CreateConnectionString()
        {
            RemoveConfigurationFile();

            var dcd = new DataConnectionDialog();

            var dcs = new DataConnectionConfiguration(null);

            dcs.LoadConfiguration(dcd);

            if (DataConnectionDialog.Show(dcd) != DialogResult.OK) return "Aborted";

            var connectionString = dcd.ConnectionString;

            if (dcd.UseEncryptionCheckBox.Checked)
            {
                connectionString += ";Encrypt=True";
            }
            else
            {
                connectionString += ";Encrypt=False";
            }

            return connectionString;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            ConnectionStringTextBox.Text = "";

            var connection = CreateConnectionString();

            ConnectionStringTextBox.Text = connection;
            var connectionString = Properties.Resources.BlankConntection
                .Replace("_TOKEN_", connection)
                .Replace("\\", "\\\\");
            
            ResultTextBox.Text = connectionString;
        }
    }

}
