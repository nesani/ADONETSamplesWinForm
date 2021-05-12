
namespace ADONETSamplesWinForm
{
    partial class frmDataReader
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
            this.btnReadData = new System.Windows.Forms.Button();
            this.rtbDisplayData = new System.Windows.Forms.RichTextBox();
            this.btnGetGenericList = new System.Windows.Forms.Button();
            this.tblDataGrid = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRetireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetGenericAuto = new System.Windows.Forms.Button();
            this.btnGetGenericListWithHelpers = new System.Windows.Forms.Button();
            this.btnGetMultipleResults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(13, 69);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(75, 23);
            this.btnReadData.TabIndex = 0;
            this.btnReadData.Text = "DataReader";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // rtbDisplayData
            // 
            this.rtbDisplayData.Location = new System.Drawing.Point(13, 98);
            this.rtbDisplayData.Name = "rtbDisplayData";
            this.rtbDisplayData.Size = new System.Drawing.Size(775, 161);
            this.rtbDisplayData.TabIndex = 1;
            this.rtbDisplayData.Text = "";
            // 
            // btnGetGenericList
            // 
            this.btnGetGenericList.Location = new System.Drawing.Point(94, 69);
            this.btnGetGenericList.Name = "btnGetGenericList";
            this.btnGetGenericList.Size = new System.Drawing.Size(121, 23);
            this.btnGetGenericList.TabIndex = 2;
            this.btnGetGenericList.Text = "Get Generic List";
            this.btnGetGenericList.UseVisualStyleBackColor = true;
            this.btnGetGenericList.Click += new System.EventHandler(this.btnGetGenericList_Click);
            // 
            // tblDataGrid
            // 
            this.tblDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmName,
            this.clmDate,
            this.clmUrl,
            this.clmPrice,
            this.clmRetireDate});
            this.tblDataGrid.Location = new System.Drawing.Point(12, 265);
            this.tblDataGrid.Name = "tblDataGrid";
            this.tblDataGrid.Size = new System.Drawing.Size(775, 150);
            this.tblDataGrid.TabIndex = 3;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.Width = 125;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.Width = 125;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Starting Date";
            this.clmDate.Name = "clmDate";
            this.clmDate.Width = 125;
            // 
            // clmUrl
            // 
            this.clmUrl.HeaderText = "URL";
            this.clmUrl.Name = "clmUrl";
            this.clmUrl.Width = 125;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Price";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.Width = 125;
            // 
            // clmRetireDate
            // 
            this.clmRetireDate.HeaderText = "RetireDate";
            this.clmRetireDate.Name = "clmRetireDate";
            this.clmRetireDate.Width = 125;
            // 
            // btnGetGenericAuto
            // 
            this.btnGetGenericAuto.Location = new System.Drawing.Point(221, 69);
            this.btnGetGenericAuto.Name = "btnGetGenericAuto";
            this.btnGetGenericAuto.Size = new System.Drawing.Size(205, 23);
            this.btnGetGenericAuto.TabIndex = 4;
            this.btnGetGenericAuto.Text = "Get Generic List Automatic Conversion";
            this.btnGetGenericAuto.UseVisualStyleBackColor = true;
            this.btnGetGenericAuto.Click += new System.EventHandler(this.btnGetGenericAuto_Click);
            // 
            // btnGetGenericListWithHelpers
            // 
            this.btnGetGenericListWithHelpers.Location = new System.Drawing.Point(432, 69);
            this.btnGetGenericListWithHelpers.Name = "btnGetGenericListWithHelpers";
            this.btnGetGenericListWithHelpers.Size = new System.Drawing.Size(157, 23);
            this.btnGetGenericListWithHelpers.TabIndex = 5;
            this.btnGetGenericListWithHelpers.Text = "Get Generic List with Helpers";
            this.btnGetGenericListWithHelpers.UseVisualStyleBackColor = true;
            this.btnGetGenericListWithHelpers.Click += new System.EventHandler(this.btnGetGenericListWithHelpers_Click);
            // 
            // btnGetMultipleResults
            // 
            this.btnGetMultipleResults.Location = new System.Drawing.Point(595, 69);
            this.btnGetMultipleResults.Name = "btnGetMultipleResults";
            this.btnGetMultipleResults.Size = new System.Drawing.Size(168, 23);
            this.btnGetMultipleResults.TabIndex = 6;
            this.btnGetMultipleResults.Text = "Multiple results";
            this.btnGetMultipleResults.UseVisualStyleBackColor = true;
            this.btnGetMultipleResults.Click += new System.EventHandler(this.btnGetMultipleResults_Click);
            // 
            // frmDataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetMultipleResults);
            this.Controls.Add(this.btnGetGenericListWithHelpers);
            this.Controls.Add(this.btnGetGenericAuto);
            this.Controls.Add(this.tblDataGrid);
            this.Controls.Add(this.btnGetGenericList);
            this.Controls.Add(this.rtbDisplayData);
            this.Controls.Add(this.btnReadData);
            this.Name = "frmDataReader";
            this.Text = "frmDataReader";
            ((System.ComponentModel.ISupportInitialize)(this.tblDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.RichTextBox rtbDisplayData;
        private System.Windows.Forms.Button btnGetGenericList;
        private System.Windows.Forms.DataGridView tblDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRetireDate;
        private System.Windows.Forms.Button btnGetGenericAuto;
        private System.Windows.Forms.Button btnGetGenericListWithHelpers;
        private System.Windows.Forms.Button btnGetMultipleResults;
    }
}