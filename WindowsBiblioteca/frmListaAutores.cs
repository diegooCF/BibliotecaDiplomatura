﻿using System;
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
    public partial class frmListaAutores : Form
    {
        public frmListaAutores()
        {
            InitializeComponent();
        }
        void TraerAutores()
        {
            Logica.Autor objLogicaAutor = new Logica.Autor();
            dgvAutores.DataSource = objLogicaAutor.TraerTodos();
        }

        private void frmListaAutores_Load(object sender, EventArgs e)
        {
            TraerAutores();
        }
    }
}
