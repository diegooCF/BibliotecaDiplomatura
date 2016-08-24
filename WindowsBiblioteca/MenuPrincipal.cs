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
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // cierra el mdi
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. crear objeto del form a mostrar
            frmNuevoAutor objForm = new frmNuevoAutor();

            //2. establecer que sea hijo del mdi
            objForm.MdiParent = this;

            // 3. que se muestre en el centro de la pantalla
            objForm.StartPosition = FormStartPosition.CenterScreen;

            // 4. mostrar form
            objForm.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. crear objeto del form a mostrar
            frmListaAutores objForm = new frmListaAutores();

            //2. establecer que sea hijo del mdi
            objForm.MdiParent = this;

            // 3. que se muestre en el centro de la pantalla
            objForm.StartPosition = FormStartPosition.CenterScreen;

            // 4. mostrar form
            objForm.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificar objform = new frmModificar();
            objform.MdiParent = this;
            objform.StartPosition = FormStartPosition.CenterScreen;
            objform.Show();
        }
    }
}
