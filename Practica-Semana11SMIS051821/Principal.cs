using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Semana11SMIS051821
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void partesDelCocheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPartesCoches frm = new frmPartesCoches();
            frm.MdiParent = this;
            frm.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest frm = new frmTest();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
