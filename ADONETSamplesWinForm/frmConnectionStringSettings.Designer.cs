
namespace ADONETSamplesWinForm
{
    partial class frmConnectionStringSettings
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
            this.tbConnectionString = new System.Windows.Forms.TextBox();
            this.btnOpenConnection = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.frmOpenConnectionUsingBLocks = new System.Windows.Forms.Button();
            this.btnOpenConnectionWithErrors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbConnectionString
            // 
            this.tbConnectionString.Location = new System.Drawing.Point(12, 21);
            this.tbConnectionString.Name = "tbConnectionString";
            this.tbConnectionString.Size = new System.Drawing.Size(776, 20);
            this.tbConnectionString.TabIndex = 0;
            // 
            // btnOpenConnection
            // 
            this.btnOpenConnection.Location = new System.Drawing.Point(12, 47);
            this.btnOpenConnection.Name = "btnOpenConnection";
            this.btnOpenConnection.Size = new System.Drawing.Size(122, 23);
            this.btnOpenConnection.TabIndex = 1;
            this.btnOpenConnection.Text = "Open Connection";
            this.btnOpenConnection.UseVisualStyleBackColor = true;
            this.btnOpenConnection.Click += new System.EventHandler(this.btnOpenConnection_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(12, 96);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(776, 327);
            this.rtbDisplay.TabIndex = 2;
            this.rtbDisplay.Text = "";
            // 
            // frmOpenConnectionUsingBLocks
            // 
            this.frmOpenConnectionUsingBLocks.Location = new System.Drawing.Point(140, 47);
            this.frmOpenConnectionUsingBLocks.Name = "frmOpenConnectionUsingBLocks";
            this.frmOpenConnectionUsingBLocks.Size = new System.Drawing.Size(187, 23);
            this.frmOpenConnectionUsingBLocks.TabIndex = 3;
            this.frmOpenConnectionUsingBLocks.Text = "Open Connection(Using Blocks)";
            this.frmOpenConnectionUsingBLocks.UseVisualStyleBackColor = true;
            this.frmOpenConnectionUsingBLocks.Click += new System.EventHandler(this.frmOpenConnectionUsingBLocks_Click);
            // 
            // btnOpenConnectionWithErrors
            // 
            this.btnOpenConnectionWithErrors.Location = new System.Drawing.Point(333, 47);
            this.btnOpenConnectionWithErrors.Name = "btnOpenConnectionWithErrors";
            this.btnOpenConnectionWithErrors.Size = new System.Drawing.Size(187, 23);
            this.btnOpenConnectionWithErrors.TabIndex = 4;
            this.btnOpenConnectionWithErrors.Text = "Open Connection(WithErrors";
            this.btnOpenConnectionWithErrors.UseVisualStyleBackColor = true;
            this.btnOpenConnectionWithErrors.Click += new System.EventHandler(this.btnOpenConnectionWithErrors_Click);
            // 
            // frmConnectionStringSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenConnectionWithErrors);
            this.Controls.Add(this.frmOpenConnectionUsingBLocks);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.btnOpenConnection);
            this.Controls.Add(this.tbConnectionString);
            this.Name = "frmConnectionStringSettings";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbConnectionString;
        private System.Windows.Forms.Button btnOpenConnection;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button frmOpenConnectionUsingBLocks;
        private System.Windows.Forms.Button btnOpenConnectionWithErrors;
    }
}