using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONETSamplesWinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnectionStringSettings_Click(object sender, EventArgs e)
        {
            var frmConnectionStringSettings = new frmConnectionStringSettings();

            frmConnectionStringSettings.Show();
        }

        private void btnCommands_Click(object sender, EventArgs e)
        {
            var frmCommands = new frmCommands();

            frmCommands.Show();
        }

        private void btnDataReader_Click(object sender, EventArgs e)
        {
            var frmDataReader = new frmDataReader();

            frmDataReader.Show();
        }

        private void btnExceptionHandling_Click(object sender, EventArgs e)
        {
            var frmDataReader = new frmExceptionHandling();

            frmDataReader.Show();
        }
    }
}
