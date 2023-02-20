using Microsoft.Data.ConnectionUI;
using System;
using System.Windows.Forms;

namespace DatabaseConnector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string CreateConnectionString()
        {
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
            textBox1.Text = "";
            var connectionString = Properties.Resources.BlankConntection
                .Replace("_TOKEN_", CreateConnectionString())
                .Replace("\\", "\\\\");
            
            textBox1.Text = connectionString;
        }
    }

}
