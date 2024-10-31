namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInsertar = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabActualizar = new System.Windows.Forms.TabPage();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tabMostrar = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textObservacion = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabInsertar.SuspendLayout();
            this.tabActualizar.SuspendLayout();
            this.tabMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Observacion";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInsertar);
            this.tabControl1.Controls.Add(this.tabActualizar);
            this.tabControl1.Controls.Add(this.tabMostrar);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(281, 245);
            this.tabControl1.TabIndex = 7;
            // 
            // tabInsertar
            // 
            this.tabInsertar.BackColor = System.Drawing.Color.Transparent;
            this.tabInsertar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabInsertar.Controls.Add(this.textNombre);
            this.tabInsertar.Controls.Add(this.textObservacion);
            this.tabInsertar.Controls.Add(this.textApellido);
            this.tabInsertar.Controls.Add(this.label7);
            this.tabInsertar.Controls.Add(this.label6);
            this.tabInsertar.Controls.Add(this.btnGuardar);
            this.tabInsertar.Controls.Add(this.label4);
            this.tabInsertar.Location = new System.Drawing.Point(4, 22);
            this.tabInsertar.Name = "tabInsertar";
            this.tabInsertar.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsertar.Size = new System.Drawing.Size(273, 219);
            this.tabInsertar.TabIndex = 0;
            this.tabInsertar.Text = "Insertar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(92, 158);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 26);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Observacion";
            // 
            // tabActualizar
            // 
            this.tabActualizar.BackColor = System.Drawing.Color.Transparent;
            this.tabActualizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabActualizar.Controls.Add(this.txtObservacion);
            this.tabActualizar.Controls.Add(this.txtApellido);
            this.tabActualizar.Controls.Add(this.label2);
            this.tabActualizar.Controls.Add(this.label1);
            this.tabActualizar.Controls.Add(this.txtNombre);
            this.tabActualizar.Controls.Add(this.label5);
            this.tabActualizar.Controls.Add(this.txtID);
            this.tabActualizar.Controls.Add(this.label3);
            this.tabActualizar.Controls.Add(this.btnActualizar);
            this.tabActualizar.Location = new System.Drawing.Point(4, 22);
            this.tabActualizar.Name = "tabActualizar";
            this.tabActualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tabActualizar.Size = new System.Drawing.Size(273, 219);
            this.tabActualizar.TabIndex = 1;
            this.tabActualizar.Text = "Actualizar";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(85, 117);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(100, 20);
            this.txtObservacion.TabIndex = 13;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(85, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(6, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(56, 20);
            this.txtID.TabIndex = 7;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(97, 157);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(76, 26);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tabMostrar
            // 
            this.tabMostrar.Controls.Add(this.dataGridView1);
            this.tabMostrar.Location = new System.Drawing.Point(4, 22);
            this.tabMostrar.Name = "tabMostrar";
            this.tabMostrar.Size = new System.Drawing.Size(273, 219);
            this.tabMostrar.TabIndex = 2;
            this.tabMostrar.Text = "Mostrar";
            this.tabMostrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(264, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(79, 68);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 12;
            // 
            // textObservacion
            // 
            this.textObservacion.Location = new System.Drawing.Point(79, 117);
            this.textObservacion.Name = "textObservacion";
            this.textObservacion.Size = new System.Drawing.Size(100, 20);
            this.textObservacion.TabIndex = 13;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(79, 19);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabInsertar.ResumeLayout(false);
            this.tabInsertar.PerformLayout();
            this.tabActualizar.ResumeLayout(false);
            this.tabActualizar.PerformLayout();
            this.tabMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInsertar;
        private System.Windows.Forms.TabPage tabActualizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TabPage tabMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox textObservacion;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
    }
}

