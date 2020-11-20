using CC01.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FrmEcoleEdit : Form
    {
        private EtudiantBLO etudiantsBLO;
        private EcoleBLO ecoleBLO;
        public FrmEcoleEdit()
        {
            InitializeComponent();
            etudiantsBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
            ecoleBLO = new EcoleBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Form f = new FrmCreateSchool(loadData);
            f.Show();
        }
    }
}
