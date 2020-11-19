using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CC01.WinForms;
using CC01.BO;


namespace CC01.WinForms
{
    public partial class FrmEtudiantEdit : Form
    {
        private object loadData;

        public FrmEtudiantEdit()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }


        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new FrmCreateEtudiant
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as Etudiants,
                        loadData
                    ) ;
                    f.ShowDialog();
                }
            }
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Form f = new FrmCreateEtudiant(LoadData);
            f.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                LoadData();
            else
                txtSearch.Clear();
        }

        private void LoadData()
        {
            
        }
    }
}
