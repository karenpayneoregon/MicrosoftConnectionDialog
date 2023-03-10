namespace WindowsFormsApplication1_cs
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateNewConnectionButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SelectColumnButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.GenerateSelectStatementButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.ExportToDelimitedFileButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.GenerateConnectionStringButton = new System.Windows.Forms.Button();
            this.DeleteDataConnectionFileButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateNewConnectionButton
            // 
            this.CreateNewConnectionButton.Location = new System.Drawing.Point(16, 15);
            this.CreateNewConnectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateNewConnectionButton.Name = "CreateNewConnectionButton";
            this.CreateNewConnectionButton.Size = new System.Drawing.Size(219, 28);
            this.CreateNewConnectionButton.TabIndex = 0;
            this.CreateNewConnectionButton.Text = "Create connection";
            this.CreateNewConnectionButton.UseVisualStyleBackColor = true;
            this.CreateNewConnectionButton.Click += new System.EventHandler(this.CreateNewConnectionButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(243, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 244);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SelectColumnButton
            // 
            this.SelectColumnButton.Enabled = false;
            this.SelectColumnButton.Location = new System.Drawing.Point(16, 50);
            this.SelectColumnButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectColumnButton.Name = "SelectColumnButton";
            this.SelectColumnButton.Size = new System.Drawing.Size(219, 28);
            this.SelectColumnButton.TabIndex = 1;
            this.SelectColumnButton.Text = "Select columns";
            this.SelectColumnButton.UseVisualStyleBackColor = true;
            this.SelectColumnButton.Click += new System.EventHandler(this.SelectColumnButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(477, 15);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(232, 242);
            this.checkedListBox1.TabIndex = 5;
            // 
            // GenerateSelectStatementButton
            // 
            this.GenerateSelectStatementButton.Enabled = false;
            this.GenerateSelectStatementButton.Location = new System.Drawing.Point(16, 86);
            this.GenerateSelectStatementButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateSelectStatementButton.Name = "GenerateSelectStatementButton";
            this.GenerateSelectStatementButton.Size = new System.Drawing.Size(219, 28);
            this.GenerateSelectStatementButton.TabIndex = 2;
            this.GenerateSelectStatementButton.Text = "Generate SQL SELECT";
            this.GenerateSelectStatementButton.UseVisualStyleBackColor = true;
            this.GenerateSelectStatementButton.Click += new System.EventHandler(this.GenerateSelectStatementButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteDataConnectionFileButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 267);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 55);
            this.panel1.TabIndex = 6;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(616, 12);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 28);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ExportToDelimitedFileButton
            // 
            this.ExportToDelimitedFileButton.Enabled = false;
            this.ExportToDelimitedFileButton.Location = new System.Drawing.Point(16, 122);
            this.ExportToDelimitedFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExportToDelimitedFileButton.Name = "ExportToDelimitedFileButton";
            this.ExportToDelimitedFileButton.Size = new System.Drawing.Size(219, 28);
            this.ExportToDelimitedFileButton.TabIndex = 3;
            this.ExportToDelimitedFileButton.Text = "Export CSV";
            this.ExportToDelimitedFileButton.UseVisualStyleBackColor = true;
            this.ExportToDelimitedFileButton.Click += new System.EventHandler(this.ExportToDelimitedFileButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "csv|*.csv|txt|*.txt";
            // 
            // GenerateConnectionStringButton
            // 
            this.GenerateConnectionStringButton.Location = new System.Drawing.Point(16, 229);
            this.GenerateConnectionStringButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateConnectionStringButton.Name = "GenerateConnectionStringButton";
            this.GenerateConnectionStringButton.Size = new System.Drawing.Size(219, 28);
            this.GenerateConnectionStringButton.TabIndex = 7;
            this.GenerateConnectionStringButton.Text = "Create connection string";
            this.GenerateConnectionStringButton.UseVisualStyleBackColor = true;
            this.GenerateConnectionStringButton.Click += new System.EventHandler(this.GenerateConnectionStringButton_Click);
            // 
            // DeleteDataConnectionFileButton
            // 
            this.DeleteDataConnectionFileButton.Location = new System.Drawing.Point(16, 12);
            this.DeleteDataConnectionFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteDataConnectionFileButton.Name = "DeleteDataConnectionFileButton";
            this.DeleteDataConnectionFileButton.Size = new System.Drawing.Size(219, 28);
            this.DeleteDataConnectionFileButton.TabIndex = 8;
            this.DeleteDataConnectionFileButton.Text = "Delete DataConnection.xml";
            this.DeleteDataConnectionFileButton.UseVisualStyleBackColor = true;
            this.DeleteDataConnectionFileButton.Click += new System.EventHandler(this.DeleteDataConnectionFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 322);
            this.Controls.Add(this.GenerateConnectionStringButton);
            this.Controls.Add(this.ExportToDelimitedFileButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GenerateSelectStatementButton);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.SelectColumnButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CreateNewConnectionButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNewConnectionButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SelectColumnButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button GenerateSelectStatementButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button ExportToDelimitedFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button GenerateConnectionStringButton;
        private System.Windows.Forms.Button DeleteDataConnectionFileButton;
    }
}

