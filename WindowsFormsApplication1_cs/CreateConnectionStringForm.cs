using Microsoft.Data.ConnectionUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1_cs
{
    public partial class CreateConnectionStringForm : Form
    {
        public CreateConnectionStringForm()
        {
            InitializeComponent();
        }

        private void OpenDialogButton_Click(object sender, EventArgs e)
        {
            textBox1.Text =  CreateConnectionString();
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

        private void ClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
    }
}
