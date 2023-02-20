namespace WindowsFormsApplication1_cs
{
    partial class CreateConnectionStringForm
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
            this.OpenDialogButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClipboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenDialogButton
            // 
            this.OpenDialogButton.Location = new System.Drawing.Point(22, 40);
            this.OpenDialogButton.Name = "OpenDialogButton";
            this.OpenDialogButton.Size = new System.Drawing.Size(134, 37);
            this.OpenDialogButton.TabIndex = 0;
            this.OpenDialogButton.Text = "Open Dialog";
            this.OpenDialogButton.UseVisualStyleBackColor = true;
            this.OpenDialogButton.Click += new System.EventHandler(this.OpenDialogButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(755, 22);
            this.textBox1.TabIndex = 1;
            // 
            // ClipboardButton
            // 
            this.ClipboardButton.Location = new System.Drawing.Point(643, 40);
            this.ClipboardButton.Name = "ClipboardButton";
            this.ClipboardButton.Size = new System.Drawing.Size(134, 37);
            this.ClipboardButton.TabIndex = 2;
            this.ClipboardButton.Text = "To Clipboad";
            this.ClipboardButton.UseVisualStyleBackColor = true;
            this.ClipboardButton.Click += new System.EventHandler(this.ClipboardButton_Click);
            // 
            // CreateConnectionStringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 102);
            this.Controls.Add(this.ClipboardButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OpenDialogButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateConnectionStringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Connection String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenDialogButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ClipboardButton;
    }
}