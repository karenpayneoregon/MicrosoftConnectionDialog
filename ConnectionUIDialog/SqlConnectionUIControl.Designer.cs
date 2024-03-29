﻿namespace Microsoft.Data.ConnectionUI
{
	public partial class SqlConnectionUIControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlConnectionUIControl));
            this.serverLabel = new System.Windows.Forms.Label();
            this.serverTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.serverComboBox = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.logonGroupBox = new System.Windows.Forms.GroupBox();
            this.loginTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.savePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.sqlAuthenticationRadioButton = new System.Windows.Forms.RadioButton();
            this.windowsAuthenticationRadioButton = new System.Windows.Forms.RadioButton();
            this.databaseGroupBox = new System.Windows.Forms.GroupBox();
            this.logicalDatabaseNameTextBox = new System.Windows.Forms.TextBox();
            this.logicalDatabaseNameLabel = new System.Windows.Forms.Label();
            this.attachDatabaseTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.attachDatabaseTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.attachDatabaseRadioButton = new System.Windows.Forms.RadioButton();
            this.selectDatabaseComboBox = new System.Windows.Forms.ComboBox();
            this.selectDatabaseRadioButton = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ServerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalDbServerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverTableLayoutPanel.SuspendLayout();
            this.logonGroupBox.SuspendLayout();
            this.loginTableLayoutPanel.SuspendLayout();
            this.databaseGroupBox.SuspendLayout();
            this.attachDatabaseTableLayoutPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverLabel
            // 
            resources.ApplyResources(this.serverLabel, "serverLabel");
            this.serverLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.serverLabel.Name = "serverLabel";
            // 
            // serverTableLayoutPanel
            // 
            resources.ApplyResources(this.serverTableLayoutPanel, "serverTableLayoutPanel");
            this.serverTableLayoutPanel.Controls.Add(this.serverComboBox, 0, 0);
            this.serverTableLayoutPanel.Controls.Add(this.refreshButton, 1, 0);
            this.serverTableLayoutPanel.Name = "serverTableLayoutPanel";
            // 
            // serverComboBox
            // 
            resources.ApplyResources(this.serverComboBox, "serverComboBox");
            this.serverComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.serverComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.serverComboBox.FormattingEnabled = true;
            this.serverComboBox.Items.AddRange(new object[] {
            resources.GetString("serverComboBox.Items"),
            resources.GetString("serverComboBox.Items1")});
            this.serverComboBox.Name = "serverComboBox";
            this.serverComboBox.DropDown += new System.EventHandler(this.EnumerateServers);
            this.serverComboBox.TextChanged += new System.EventHandler(this.SetServer);
            this.serverComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleComboBoxDownKey);
            this.serverComboBox.Leave += new System.EventHandler(this.TrimControlText);
            // 
            // refreshButton
            // 
            resources.ApplyResources(this.refreshButton, "refreshButton");
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Click += new System.EventHandler(this.RefreshServers);
            // 
            // logonGroupBox
            // 
            resources.ApplyResources(this.logonGroupBox, "logonGroupBox");
            this.logonGroupBox.Controls.Add(this.loginTableLayoutPanel);
            this.logonGroupBox.Controls.Add(this.sqlAuthenticationRadioButton);
            this.logonGroupBox.Controls.Add(this.windowsAuthenticationRadioButton);
            this.logonGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logonGroupBox.Name = "logonGroupBox";
            this.logonGroupBox.TabStop = false;
            // 
            // loginTableLayoutPanel
            // 
            resources.ApplyResources(this.loginTableLayoutPanel, "loginTableLayoutPanel");
            this.loginTableLayoutPanel.Controls.Add(this.userNameLabel, 0, 0);
            this.loginTableLayoutPanel.Controls.Add(this.userNameTextBox, 1, 0);
            this.loginTableLayoutPanel.Controls.Add(this.passwordLabel, 0, 1);
            this.loginTableLayoutPanel.Controls.Add(this.passwordTextBox, 1, 1);
            this.loginTableLayoutPanel.Controls.Add(this.savePasswordCheckBox, 1, 2);
            this.loginTableLayoutPanel.Name = "loginTableLayoutPanel";
            // 
            // userNameLabel
            // 
            resources.ApplyResources(this.userNameLabel, "userNameLabel");
            this.userNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.userNameLabel.Name = "userNameLabel";
            // 
            // userNameTextBox
            // 
            resources.ApplyResources(this.userNameTextBox, "userNameTextBox");
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.TextChanged += new System.EventHandler(this.SetUserName);
            this.userNameTextBox.Leave += new System.EventHandler(this.TrimControlText);
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.passwordLabel.Name = "passwordLabel";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.SetPassword);
            // 
            // savePasswordCheckBox
            // 
            resources.ApplyResources(this.savePasswordCheckBox, "savePasswordCheckBox");
            this.savePasswordCheckBox.Name = "savePasswordCheckBox";
            this.savePasswordCheckBox.CheckedChanged += new System.EventHandler(this.SetSavePassword);
            // 
            // sqlAuthenticationRadioButton
            // 
            resources.ApplyResources(this.sqlAuthenticationRadioButton, "sqlAuthenticationRadioButton");
            this.sqlAuthenticationRadioButton.Name = "sqlAuthenticationRadioButton";
            this.sqlAuthenticationRadioButton.CheckedChanged += new System.EventHandler(this.SetAuthenticationOption);
            // 
            // windowsAuthenticationRadioButton
            // 
            resources.ApplyResources(this.windowsAuthenticationRadioButton, "windowsAuthenticationRadioButton");
            this.windowsAuthenticationRadioButton.Name = "windowsAuthenticationRadioButton";
            this.windowsAuthenticationRadioButton.CheckedChanged += new System.EventHandler(this.SetAuthenticationOption);
            // 
            // databaseGroupBox
            // 
            resources.ApplyResources(this.databaseGroupBox, "databaseGroupBox");
            this.databaseGroupBox.Controls.Add(this.logicalDatabaseNameTextBox);
            this.databaseGroupBox.Controls.Add(this.logicalDatabaseNameLabel);
            this.databaseGroupBox.Controls.Add(this.attachDatabaseTableLayoutPanel);
            this.databaseGroupBox.Controls.Add(this.attachDatabaseRadioButton);
            this.databaseGroupBox.Controls.Add(this.selectDatabaseComboBox);
            this.databaseGroupBox.Controls.Add(this.selectDatabaseRadioButton);
            this.databaseGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.databaseGroupBox.Name = "databaseGroupBox";
            this.databaseGroupBox.TabStop = false;
            // 
            // logicalDatabaseNameTextBox
            // 
            resources.ApplyResources(this.logicalDatabaseNameTextBox, "logicalDatabaseNameTextBox");
            this.logicalDatabaseNameTextBox.Name = "logicalDatabaseNameTextBox";
            this.logicalDatabaseNameTextBox.TextChanged += new System.EventHandler(this.SetLogicalFilename);
            this.logicalDatabaseNameTextBox.Leave += new System.EventHandler(this.TrimControlText);
            // 
            // logicalDatabaseNameLabel
            // 
            resources.ApplyResources(this.logicalDatabaseNameLabel, "logicalDatabaseNameLabel");
            this.logicalDatabaseNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logicalDatabaseNameLabel.Name = "logicalDatabaseNameLabel";
            // 
            // attachDatabaseTableLayoutPanel
            // 
            resources.ApplyResources(this.attachDatabaseTableLayoutPanel, "attachDatabaseTableLayoutPanel");
            this.attachDatabaseTableLayoutPanel.Controls.Add(this.attachDatabaseTextBox, 0, 0);
            this.attachDatabaseTableLayoutPanel.Controls.Add(this.browseButton, 1, 0);
            this.attachDatabaseTableLayoutPanel.Name = "attachDatabaseTableLayoutPanel";
            // 
            // attachDatabaseTextBox
            // 
            resources.ApplyResources(this.attachDatabaseTextBox, "attachDatabaseTextBox");
            this.attachDatabaseTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.attachDatabaseTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.attachDatabaseTextBox.Name = "attachDatabaseTextBox";
            this.attachDatabaseTextBox.TextChanged += new System.EventHandler(this.SetAttachDatabase);
            this.attachDatabaseTextBox.Leave += new System.EventHandler(this.TrimControlText);
            // 
            // browseButton
            // 
            resources.ApplyResources(this.browseButton, "browseButton");
            this.browseButton.Name = "browseButton";
            this.browseButton.Click += new System.EventHandler(this.Browse);
            // 
            // attachDatabaseRadioButton
            // 
            resources.ApplyResources(this.attachDatabaseRadioButton, "attachDatabaseRadioButton");
            this.attachDatabaseRadioButton.Name = "attachDatabaseRadioButton";
            this.attachDatabaseRadioButton.CheckedChanged += new System.EventHandler(this.SetDatabaseOption);
            // 
            // selectDatabaseComboBox
            // 
            resources.ApplyResources(this.selectDatabaseComboBox, "selectDatabaseComboBox");
            this.selectDatabaseComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.selectDatabaseComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selectDatabaseComboBox.FormattingEnabled = true;
            this.selectDatabaseComboBox.Name = "selectDatabaseComboBox";
            this.selectDatabaseComboBox.DropDown += new System.EventHandler(this.EnumerateDatabases);
            this.selectDatabaseComboBox.TextChanged += new System.EventHandler(this.SetDatabase);
            this.selectDatabaseComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HandleComboBoxDownKey);
            this.selectDatabaseComboBox.Leave += new System.EventHandler(this.TrimControlText);
            // 
            // selectDatabaseRadioButton
            // 
            resources.ApplyResources(this.selectDatabaseRadioButton, "selectDatabaseRadioButton");
            this.selectDatabaseRadioButton.Name = "selectDatabaseRadioButton";
            this.selectDatabaseRadioButton.CheckedChanged += new System.EventHandler(this.SetDatabaseOption);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerNameToolStripMenuItem,
            this.LocalDbServerNameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // ServerNameToolStripMenuItem
            // 
            this.ServerNameToolStripMenuItem.Name = "ServerNameToolStripMenuItem";
            resources.ApplyResources(this.ServerNameToolStripMenuItem, "ServerNameToolStripMenuItem");
            this.ServerNameToolStripMenuItem.Click += new System.EventHandler(this.ServerNameToolStripMenuItem_Click);
            // 
            // LocalDbServerNameToolStripMenuItem
            // 
            this.LocalDbServerNameToolStripMenuItem.Name = "LocalDbServerNameToolStripMenuItem";
            resources.ApplyResources(this.LocalDbServerNameToolStripMenuItem, "LocalDbServerNameToolStripMenuItem");
            this.LocalDbServerNameToolStripMenuItem.Click += new System.EventHandler(this.LocalDbServerNameToolStripMenuItem_Click);
            // 
            // SqlConnectionUIControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.databaseGroupBox);
            this.Controls.Add(this.logonGroupBox);
            this.Controls.Add(this.serverTableLayoutPanel);
            this.Controls.Add(this.serverLabel);
            this.Name = "SqlConnectionUIControl";
            this.serverTableLayoutPanel.ResumeLayout(false);
            this.serverTableLayoutPanel.PerformLayout();
            this.logonGroupBox.ResumeLayout(false);
            this.logonGroupBox.PerformLayout();
            this.loginTableLayoutPanel.ResumeLayout(false);
            this.loginTableLayoutPanel.PerformLayout();
            this.databaseGroupBox.ResumeLayout(false);
            this.databaseGroupBox.PerformLayout();
            this.attachDatabaseTableLayoutPanel.ResumeLayout(false);
            this.attachDatabaseTableLayoutPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label serverLabel;
		private System.Windows.Forms.TableLayoutPanel serverTableLayoutPanel;
		private System.Windows.Forms.ComboBox serverComboBox;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.GroupBox logonGroupBox;
		private System.Windows.Forms.RadioButton windowsAuthenticationRadioButton;
		private System.Windows.Forms.RadioButton sqlAuthenticationRadioButton;
		private System.Windows.Forms.TableLayoutPanel loginTableLayoutPanel;
		private System.Windows.Forms.Label userNameLabel;
		private System.Windows.Forms.TextBox userNameTextBox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.CheckBox savePasswordCheckBox;
		private System.Windows.Forms.GroupBox databaseGroupBox;
		private System.Windows.Forms.RadioButton selectDatabaseRadioButton;
		private System.Windows.Forms.ComboBox selectDatabaseComboBox;
		private System.Windows.Forms.RadioButton attachDatabaseRadioButton;
		private System.Windows.Forms.TableLayoutPanel attachDatabaseTableLayoutPanel;
		private System.Windows.Forms.TextBox attachDatabaseTextBox;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.Label logicalDatabaseNameLabel;
		private System.Windows.Forms.TextBox logicalDatabaseNameTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ServerNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LocalDbServerNameToolStripMenuItem;
    }
}
