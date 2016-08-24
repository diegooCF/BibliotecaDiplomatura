namespace WindowsBiblioteca
{
    partial class frmNuevoAutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cboPaises = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtApellido, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCodigo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblApellido, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaNac, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblNacionalidad, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAgregar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCerrar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtCodigo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaNac, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cboPaises, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 227);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Location = new System.Drawing.Point(281, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.Location = new System.Drawing.Point(281, 46);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(262, 20);
            this.txtApellido.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(218, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(55, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "CODIGO :";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(208, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "APELLIDO :";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(213, 87);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE :";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(137, 124);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(136, 13);
            this.lblFechaNac.TabIndex = 3;
            this.lblFechaNac.Text = "FECHA DE NACIMIENTO :";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(180, 161);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(93, 13);
            this.lblNacionalidad.TabIndex = 4;
            this.lblNacionalidad.Text = "NACIONALIDAD :";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(5, 190);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(268, 32);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(281, 190);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(269, 32);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(281, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(281, 120);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNac.TabIndex = 2;
            // 
            // cboPaises
            // 
            this.cboPaises.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaises.FormattingEnabled = true;
            this.cboPaises.Items.AddRange(new object[] {
            "Argentina",
            "Brasil",
            "Uruguay",
            "Bolivia",
            "Colombia",
            "Chile",
            "Peru"});
            this.cboPaises.Location = new System.Drawing.Point(281, 157);
            this.cboPaises.Name = "cboPaises";
            this.cboPaises.Size = new System.Drawing.Size(262, 21);
            this.cboPaises.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(154, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(355, 23);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "INGRESO DE DATOS DEL AUTOR";
            // 
            // frmNuevoAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 349);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmNuevoAutor";
            this.Text = "NUEVO AUTOR";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.ComboBox cboPaises;
        private System.Windows.Forms.Label lblTitulo;
    }
}