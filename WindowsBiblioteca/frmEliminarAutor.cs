using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBiblioteca
{
    public partial class frmEliminarAutor : Form
    {
        public frmEliminarAutor()
        {
            InitializeComponent();
        }
        private void llenarAutores()
        {
            Logica.Autor logicaAutor = new Logica.Autor();
            //enlace a cbo
            cboAutores.DataSource = logicaAutor.TraerTodos();
            //campo a mostrar
            cboAutores.DisplayMember = "Autor";
            //campo a guardar
            cboAutores.ValueMember = "Codigo";
            this.cboAutores.SelectedIndexChanged += new System.EventHandler(this.cboAutores_SelectedIndexChanged);
        }
        private void frmEliminarAutor_Load(object sender, EventArgs e)
        {
            llenarAutores();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Logica.Autor logicaAutor = new Logica.Autor();
            Entidades.Autor objAutor = new Entidades.Autor();
            int pCodigo = Convert.ToInt32(cboAutores.SelectedValue);
            try
            {
                logicaAutor.Eliminar(pCodigo);
                MessageBox.Show("Autor eliminado satisfactoriamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void cboAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigoSeleccionado = Convert.ToInt32(cboAutores.SelectedValue);
            Logica.Autor logicaAutor = new Logica.Autor();
            Entidades.Autor objAutor = logicaAutor.TraerAutor(codigoSeleccionado);

            try
            {
                txtNombre.Text = objAutor.Nombre;
                txtApellido.Text = objAutor.Apellido;
                dtpFechaNac.Value = objAutor.FechaNacimiento;
                txtNacionalidad.Text = objAutor.Nacionalidad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
