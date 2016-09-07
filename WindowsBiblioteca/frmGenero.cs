using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class frmGenero : WindowsBiblioteca.frmBaseForm
    {
        public frmGenero()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Logica.Genero objLogica = new Logica.Genero();
            dgv.DataSource = objLogica.Traer();
        }
    }
}
