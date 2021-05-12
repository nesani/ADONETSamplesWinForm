
namespace ADONETSamplesWinForm
{
    partial class frmMain
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
            this.btnConnectionStringSettings = new System.Windows.Forms.Button();
            this.btnCommands = new System.Windows.Forms.Button();
            this.btnDataReader = new System.Windows.Forms.Button();
            this.btnExceptionHandling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnectionStringSettings
            // 
            this.btnConnectionStringSettings.Location = new System.Drawing.Point(12, 21);
            this.btnConnectionStringSettings.Name = "btnConnectionStringSettings";
            this.btnConnectionStringSettings.Size = new System.Drawing.Size(171, 23);
            this.btnConnectionStringSettings.TabIndex = 0;
            this.btnConnectionStringSettings.Text = "Connection String Settings";
            this.btnConnectionStringSettings.UseVisualStyleBackColor = true;
            this.btnConnectionStringSettings.Click += new System.EventHandler(this.btnConnectionStringSettings_Click);
            // 
            // btnCommands
            // 
            this.btnCommands.Location = new System.Drawing.Point(189, 21);
            this.btnCommands.Name = "btnCommands";
            this.btnCommands.Size = new System.Drawing.Size(171, 23);
            this.btnCommands.TabIndex = 1;
            this.btnCommands.Text = "Commands";
            this.btnCommands.UseVisualStyleBackColor = true;
            this.btnCommands.Click += new System.EventHandler(this.btnCommands_Click);
            // 
            // btnDataReader
            // 
            this.btnDataReader.Location = new System.Drawing.Point(366, 21);
            this.btnDataReader.Name = "btnDataReader";
            this.btnDataReader.Size = new System.Drawing.Size(171, 23);
            this.btnDataReader.TabIndex = 2;
            this.btnDataReader.Text = "Data Reader";
            this.btnDataReader.UseVisualStyleBackColor = true;
            this.btnDataReader.Click += new System.EventHandler(this.btnDataReader_Click);
            // 
            // btnExceptionHandling
            // 
            this.btnExceptionHandling.Location = new System.Drawing.Point(543, 21);
            this.btnExceptionHandling.Name = "btnExceptionHandling";
            this.btnExceptionHandling.Size = new System.Drawing.Size(171, 23);
            this.btnExceptionHandling.TabIndex = 3;
            this.btnExceptionHandling.Text = "Exceptions";
            this.btnExceptionHandling.UseVisualStyleBackColor = true;
            this.btnExceptionHandling.Click += new System.EventHandler(this.btnExceptionHandling_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExceptionHandling);
            this.Controls.Add(this.btnDataReader);
            this.Controls.Add(this.btnCommands);
            this.Controls.Add(this.btnConnectionStringSettings);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnectionStringSettings;
        private System.Windows.Forms.Button btnCommands;
        private System.Windows.Forms.Button btnDataReader;
        private System.Windows.Forms.Button btnExceptionHandling;
    }
}

