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
    public partial class FrmCreateEtudiant : Form
    {
        private object loadData;

        public FrmCreateEtudiant(object loadData)
        {
            this.loadData = loadData;
        }

        public FrmCreateEtudiant(Action loadData)
        {
            this.loadData = loadData;
        }

        public FrmCreateEtudiant(BO.Etudiants etudiants, object loadData)
        {
            InitializeComponent();
        }
    }
}
