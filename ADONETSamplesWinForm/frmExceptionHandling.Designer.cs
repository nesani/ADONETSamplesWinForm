
namespace ADONETSamplesWinForm
{
    partial class frmExceptionHandling
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
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnSimpleException = new System.Windows.Forms.Button();
            this.btnSQlException = new System.Windows.Forms.Button();
            this.btnSqlExceptionManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 83);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(767, 355);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // btnSimpleException
            // 
            this.btnSimpleException.Location = new System.Drawing.Point(13, 13);
            this.btnSimpleException.Name = "btnSimpleException";
            this.btnSimpleException.Size = new System.Drawing.Size(104, 23);
            this.btnSimpleException.TabIndex = 1;
            this.btnSimpleException.Text = "Simple Exception";
            this.btnSimpleException.UseVisualStyleBackColor = true;
            this.btnSimpleException.Click += new System.EventHandler(this.btnSimpleException_Click);
            // 
            // btnSQlException
            // 
            this.btnSQlException.Location = new System.Drawing.Point(123, 13);
            this.btnSQlException.Name = "btnSQlException";
            this.btnSQlException.Size = new System.Drawing.Size(124, 23);
            this.btnSQlException.TabIndex = 2;
            this.btnSQlException.Text = "Catch SQL Exception";
            this.btnSQlException.UseVisualStyleBackColor = true;
            this.btnSQlException.Click += new System.EventHandler(this.btnSQlException_Click);
            // 
            // btnSqlExceptionManager
            // 
            this.btnSqlExceptionManager.Location = new System.Drawing.Point(253, 13);
            this.btnSqlExceptionManager.Name = "btnSqlExceptionManager";
            this.btnSqlExceptionManager.Size = new System.Drawing.Size(149, 23);
            this.btnSqlExceptionManager.TabIndex = 3;
            this.btnSqlExceptionManager.Text = "SQL Exception Manager";
            this.btnSqlExceptionManager.UseVisualStyleBackColor = true;
            this.btnSqlExceptionManager.Click += new System.EventHandler(this.btnSqlExceptionManager_Click);
            // 
            // frmExceptionHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSqlExceptionManager);
            this.Controls.Add(this.btnSQlException);
            this.Controls.Add(this.btnSimpleException);
            this.Controls.Add(this.rtbOutput);
            this.Name = "frmExceptionHandling";
            this.Text = "frmExceptionHandling";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnSimpleException;
        private System.Windows.Forms.Button btnSQlException;
        private System.Windows.Forms.Button btnSqlExceptionManager;
    }
}