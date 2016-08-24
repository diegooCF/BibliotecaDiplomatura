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
    public partial class frmNuevoAutor : Form
    {
        public frmNuevoAutor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // creo un objeto de Entidades.Autor 
            // para completar sus propiedades
            // y enviarlo como parametro al metodo agregar de logica
            Entidades.Autor objEntidadAutor = new Entidades.Autor();
            objEntidadAutor.Apellido = txtApellido.Text;
            objEntidadAutor.Nombre = txtNombre.Text;
            objEntidadAutor.FechaNacimiento = dtpFechaNac.Value;
            objEntidadAutor.Nacionalidad = cboPaises.SelectedItem.ToString();

            try
            {
                // creo objeto de logica
                Logica.Autor objLogicaAutor = new Logica.Autor();
                objLogicaAutor.Agregar(objEntidadAutor);

                MessageBox.Show("Autor agregado!!");

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }
    }
}
