using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP1MOlina
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // Open the Especialidades form
        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            var f = new FormEspecialidades();
            f.ShowDialog();
        }

        // Open the Medicos form
        private void btnMedicos_Click(object sender, EventArgs e)
        {
            var f = new FormMedicos();
            f.ShowDialog();
        }

        // Open the Consulta form
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            var f = new FormConsulta();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
