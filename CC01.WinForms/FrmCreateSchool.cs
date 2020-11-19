using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FrmCreateSchool : Form
    {
        public FrmCreateSchool()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCreateSchool_Load(object sender, EventArgs e)
        {

        }
    }
}
