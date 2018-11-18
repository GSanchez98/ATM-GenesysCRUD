namespace GenisysATM_CRUD
{
    partial class frmServicioPublico
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
            this.lblIdentidad = new System.Windows.Forms.Label();
            this.lstServicios = new System.Windows.Forms.ListBox();
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
            this.grpOperaciones.Location = new System.Drawing.Point(525, 82);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Size = new System.Drawing.Size(116, 214);
            this.grpOperaciones.TabIndex = 29;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Opciones";
            this.grpOperaciones.Enter += new System.EventHandler(this.grpOperaciones_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(13, 311);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 30);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 168);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 30);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(6, 89);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 30);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Actualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(17, 36);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(215, 164);
            this.txtDescripcion.TabIndex = 23;
            // 
            // lblIdentidad
            // 
            this.lblIdentidad.AutoSize = true;
            this.lblIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentidad.Location = new System.Drawing.Point(17, 17);
            this.lblIdentidad.Name = "lblIdentidad";
            this.lblIdentidad.Size = new System.Drawing.Size(83, 16);
            this.lblIdentidad.TabIndex = 17;
            this.lblIdentidad.Text = "Descripción:";
            this.lblIdentidad.Click += new System.EventHandler(this.lblIdentidad_Click);
            // 
            // lstServicios
            // 
            this.lstServicios.FormattingEnabled = true;
            this.lstServicios.Location = new System.Drawing.Point(15, 25);
            this.lstServicios.Name = "lstServicios";
            this.lstServicios.Size = new System.Drawing.Size(215, 173);
            this.lstServicios.TabIndex = 16;
            this.lstServicios.Click += new System.EventHandler(this.lstServicios_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.lblIdentidad);
            this.panel1.Location = new System.Drawing.Point(13, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 214);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstServicios);
            this.panel2.Location = new System.Drawing.Point(269, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 214);
            this.panel2.TabIndex = 31;
            // 
            // frmServicioPublico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 350);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpOperaciones);
            this.Name = "frmServicioPublico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de cajeros automáticos GenisysATM";
            this.Load += new System.EventHandler(this.frmServicioPublico_Load);
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
        private System.Windows.Forms.Label lblIdentidad;
        private System.Windows.Forms.ListBox lstServicios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}