using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApplication1_cs.Classes;

namespace WindowsFormsApplication1_cs
{
    /// <summary>
    /// Pleases note the buttons being enabled as we move forward
    /// is to ensure the operator of this demo does not go into
    /// an event and crash. For production usage you would need
    /// to control things as you see fit.
    /// </summary>
    public partial class MainForm : Form
    {
        public string ServerName { get; set; }
        public string InitialCatalog { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create connection string and show tables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateNewConnectionButton_Click(object sender, EventArgs e)
        {
            SelectColumnButton.Enabled = false;
            GenerateSelectStatementButton.Enabled = false;

            var ops = new Operations();
            var dataSource = "";

            try
            {
                if (!ops.GetConnection(ref dataSource, true)) return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to connect\n{ex.Message}");
                return;
            }

            listBox1.DataSource = ops.TableNames;

            ServerName = ops.ServerName;
            InitialCatalog = ops.InitialCatalog;

            SelectColumnButton.Enabled = true;

        }
        /// <summary>
        /// Show column names for selected table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectColumnButton_Click(object sender, EventArgs e)
        {
            SetTableColumns();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTableColumns();
        }
        private void SetTableColumns()
        {
            checkedListBox1.Items.Clear();
            var ops = new Operations();

            var columnInformation = ops.ColumnNameSelection(ServerName, InitialCatalog, listBox1.Text);

            foreach (var item in columnInformation)
            {
                checkedListBox1.Items.Add(item);
            }

            GenerateSelectStatementButton.Enabled = true;
            ExportToDelimitedFileButton.Enabled = true;

        }
        /// <summary>
        /// Create a SELECT statement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateSelectStatementButton_Click(object sender, EventArgs e)
        {
            var columnInformation = new List<ColumnInformation>();

            for (int index = 0; index < checkedListBox1.Items.Count; index++)
            {
                if (checkedListBox1.GetItemChecked(index))
                {
                    columnInformation.Add(((ColumnInformation)checkedListBox1.Items[index]));
                }
            }

            var f = new SelectStatementForm {Statement = columnInformation.SelectStatement(listBox1.Text)};

            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExportToDelimitedFileButton_Click(object sender, EventArgs e)
        {

            var columnInformation = GetColumnInformation();

            saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var ops = new Exporter();

                ops.ToCsv(ServerName, InitialCatalog, columnInformation.SelectStatement(listBox1.Text), saveFileDialog1.FileName);
            }
        }

        private List<ColumnInformation> GetColumnInformation()
        {
            var columnInformation = new List<ColumnInformation>();

            for (int index = 0; index < checkedListBox1.Items.Count; index++)
            {
                if (checkedListBox1.GetItemChecked(index))
                {
                    columnInformation.Add(((ColumnInformation)checkedListBox1.Items[index]));
                }
            }

            return columnInformation;
        }

        private void GenerateConnectionStringButton_Click(object sender, EventArgs e)
        {
            Operations.CreateConnectionString();
        }
    }
}
