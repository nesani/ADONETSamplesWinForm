
namespace ADONETSamplesWinForm
{
    partial class frmCommands
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
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lblIntroductionDate = new System.Windows.Forms.Label();
            this.tbIntroductionDate = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblRetireDate = new System.Windows.Forms.Label();
            this.tbRetireDate = new System.Windows.Forms.TextBox();
            this.rtInput = new System.Windows.Forms.RichTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnScallar = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnGetValuesUsingParameters = new System.Windows.Forms.Button();
            this.btnInsertWithParameters = new System.Windows.Forms.Button();
            this.btnInsertWIthOutput = new System.Windows.Forms.Button();
            this.btnInsertWithTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(141, 17);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Size = new System.Drawing.Size(647, 20);
            this.tbProductID.TabIndex = 0;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(12, 20);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(58, 13);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Product ID";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 46);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Product Name";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(141, 43);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(647, 20);
            this.tbProductName.TabIndex = 2;
            // 
            // lblIntroductionDate
            // 
            this.lblIntroductionDate.AutoSize = true;
            this.lblIntroductionDate.Location = new System.Drawing.Point(12, 72);
            this.lblIntroductionDate.Name = "lblIntroductionDate";
            this.lblIntroductionDate.Size = new System.Drawing.Size(89, 13);
            this.lblIntroductionDate.TabIndex = 5;
            this.lblIntroductionDate.Text = "Introduction Date";
            // 
            // tbIntroductionDate
            // 
            this.tbIntroductionDate.Location = new System.Drawing.Point(141, 65);
            this.tbIntroductionDate.Name = "tbIntroductionDate";
            this.tbIntroductionDate.Size = new System.Drawing.Size(647, 20);
            this.tbIntroductionDate.TabIndex = 4;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(12, 98);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(29, 13);
            this.lblURL.TabIndex = 7;
            this.lblURL.Text = "URL";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(141, 95);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(647, 20);
            this.tbURL.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 124);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(141, 121);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(647, 20);
            this.tbPrice.TabIndex = 8;
            // 
            // lblRetireDate
            // 
            this.lblRetireDate.AutoSize = true;
            this.lblRetireDate.Location = new System.Drawing.Point(12, 150);
            this.lblRetireDate.Name = "lblRetireDate";
            this.lblRetireDate.Size = new System.Drawing.Size(59, 13);
            this.lblRetireDate.TabIndex = 11;
            this.lblRetireDate.Text = "Retire date";
            // 
            // tbRetireDate
            // 
            this.tbRetireDate.Location = new System.Drawing.Point(141, 147);
            this.tbRetireDate.Name = "tbRetireDate";
            this.tbRetireDate.Size = new System.Drawing.Size(647, 20);
            this.tbRetireDate.TabIndex = 10;
            // 
            // rtInput
            // 
            this.rtInput.Location = new System.Drawing.Point(13, 248);
            this.rtInput.Name = "rtInput";
            this.rtInput.Size = new System.Drawing.Size(782, 94);
            this.rtInput.TabIndex = 12;
            this.rtInput.Text = "";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(13, 361);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(782, 94);
            this.rtbOutput.TabIndex = 13;
            this.rtbOutput.Text = "";
            // 
            // btnScallar
            // 
            this.btnScallar.Location = new System.Drawing.Point(15, 214);
            this.btnScallar.Name = "btnScallar";
            this.btnScallar.Size = new System.Drawing.Size(75, 23);
            this.btnScallar.TabIndex = 14;
            this.btnScallar.Text = "Scalar";
            this.btnScallar.UseVisualStyleBackColor = true;
            this.btnScallar.Click += new System.EventHandler(this.btnScallar_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(96, 214);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnGetValuesUsingParameters
            // 
            this.btnGetValuesUsingParameters.Location = new System.Drawing.Point(177, 214);
            this.btnGetValuesUsingParameters.Name = "btnGetValuesUsingParameters";
            this.btnGetValuesUsingParameters.Size = new System.Drawing.Size(136, 23);
            this.btnGetValuesUsingParameters.TabIndex = 16;
            this.btnGetValuesUsingParameters.Text = "Scalar with parameters";
            this.btnGetValuesUsingParameters.UseVisualStyleBackColor = true;
            this.btnGetValuesUsingParameters.Click += new System.EventHandler(this.btnGetValuesUsingParameters_Click);
            // 
            // btnInsertWithParameters
            // 
            this.btnInsertWithParameters.Location = new System.Drawing.Point(319, 214);
            this.btnInsertWithParameters.Name = "btnInsertWithParameters";
            this.btnInsertWithParameters.Size = new System.Drawing.Size(136, 23);
            this.btnInsertWithParameters.TabIndex = 17;
            this.btnInsertWithParameters.Text = "Insert with parameters";
            this.btnInsertWithParameters.UseVisualStyleBackColor = true;
            this.btnInsertWithParameters.Click += new System.EventHandler(this.btnInsertWithParameters_Click);
            // 
            // btnInsertWIthOutput
            // 
            this.btnInsertWIthOutput.Location = new System.Drawing.Point(461, 214);
            this.btnInsertWIthOutput.Name = "btnInsertWIthOutput";
            this.btnInsertWIthOutput.Size = new System.Drawing.Size(136, 23);
            this.btnInsertWIthOutput.TabIndex = 18;
            this.btnInsertWIthOutput.Text = "Insert with Output";
            this.btnInsertWIthOutput.UseVisualStyleBackColor = true;
            this.btnInsertWIthOutput.Click += new System.EventHandler(this.btnInsertWIthOutput_Click);
            // 
            // btnInsertWithTransaction
            // 
            this.btnInsertWithTransaction.Location = new System.Drawing.Point(603, 214);
            this.btnInsertWithTransaction.Name = "btnInsertWithTransaction";
            this.btnInsertWithTransaction.Size = new System.Drawing.Size(136, 23);
            this.btnInsertWithTransaction.TabIndex = 19;
            this.btnInsertWithTransaction.Text = "Insert with Transaction";
            this.btnInsertWithTransaction.UseVisualStyleBackColor = true;
            this.btnInsertWithTransaction.Click += new System.EventHandler(this.btnInsertWithTransaction_Click);
            // 
            // frmCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 485);
            this.Controls.Add(this.btnInsertWithTransaction);
            this.Controls.Add(this.btnInsertWIthOutput);
            this.Controls.Add(this.btnInsertWithParameters);
            this.Controls.Add(this.btnGetValuesUsingParameters);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnScallar);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtInput);
            this.Controls.Add(this.lblRetireDate);
            this.Controls.Add(this.tbRetireDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.lblIntroductionDate);
            this.Controls.Add(this.tbIntroductionDate);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.tbProductID);
            this.Name = "frmCommands";
            this.Text = "frmCommands";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lblIntroductionDate;
        private System.Windows.Forms.TextBox tbIntroductionDate;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblRetireDate;
        private System.Windows.Forms.TextBox tbRetireDate;
        private System.Windows.Forms.RichTextBox rtInput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnScallar;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnGetValuesUsingParameters;
        private System.Windows.Forms.Button btnInsertWithParameters;
        public System.Windows.Forms.Button btnInsertWIthOutput;
        public System.Windows.Forms.Button btnInsertWithTransaction;
    }
}