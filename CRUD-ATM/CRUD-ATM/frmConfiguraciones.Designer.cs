namespace GenisysATM_CRUD
{
    partial class frmConfiguraciones
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
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lstconfiguracion = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpOperaciones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.Controls.Add(this.btnEliminar);
            this.grpOperaciones.Controls.Add(this.btnEditar);
            this.grpOperaciones.Controls.Add(this.btnAgregar);
            this.grpOperaciones.Location = new System.Drawing.Point(568, 75);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Size = new System.Drawing.Size(120, 210);
            this.grpOperaciones.TabIndex = 29;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Opciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 287);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 30);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(7, 154);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 30);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(7, 86);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 30);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Actualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(7, 20);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 105);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(291, 79);
            this.txtDescripcion.TabIndex = 26;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(95, 53);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(211, 20);
            this.txtValor.TabIndex = 25;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(95, 20);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(211, 20);
            this.txtNombres.TabIndex = 24;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(12, 86);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 16);
            this.lblDireccion.TabIndex = 20;
            this.lblDireccion.Text = "Descripción:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(12, 53);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(43, 16);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Valor:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 16);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre:";
            // 
            // lstconfiguracion
            // 
            this.lstconfiguracion.FormattingEnabled = true;
            this.lstconfiguracion.Location = new System.Drawing.Point(18, 10);
            this.lstconfiguracion.Name = "lstconfiguracion";
            this.lstconfiguracion.Size = new System.Drawing.Size(176, 186);
            this.lstconfiguracion.TabIndex = 16;
            this.lstconfiguracion.Click += new System.EventHandler(this.lstconfiguracion_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.txtNombres);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 206);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstconfiguracion);
            this.panel2.Location = new System.Drawing.Point(338, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 206);
            this.panel2.TabIndex = 31;
            // 
            // frmConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 329);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpOperaciones);
            this.Name = "frmConfiguraciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de cajeros automáticos GenisysATM";
            this.Load += new System.EventHandler(this.frmConfiguraciones_Load);
            this.grpOperaciones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListBox lstconfiguracion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}