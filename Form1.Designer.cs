namespace Guia02
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxEmpleado = new System.Windows.Forms.GroupBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.txtdiario = new System.Windows.Forms.TextBox();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.gbxEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(210, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculo de salario de trabajadores";
            // 
            // gbxEmpleado
            // 
            this.gbxEmpleado.Controls.Add(this.btnguardar);
            this.gbxEmpleado.Controls.Add(this.txtdias);
            this.gbxEmpleado.Controls.Add(this.txtdiario);
            this.gbxEmpleado.Controls.Add(this.txtidentificacion);
            this.gbxEmpleado.Controls.Add(this.txtnombre);
            this.gbxEmpleado.Controls.Add(this.lblDias);
            this.gbxEmpleado.Controls.Add(this.lblSalario);
            this.gbxEmpleado.Controls.Add(this.lblIdentificacion);
            this.gbxEmpleado.Controls.Add(this.lblNombre);
            this.gbxEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmpleado.Location = new System.Drawing.Point(35, 59);
            this.gbxEmpleado.Name = "gbxEmpleado";
            this.gbxEmpleado.Size = new System.Drawing.Size(729, 207);
            this.gbxEmpleado.TabIndex = 1;
            this.gbxEmpleado.TabStop = false;
            this.gbxEmpleado.Text = "Empleado";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(543, 76);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(141, 52);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar Empleado";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(278, 154);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(190, 27);
            this.txtdias.TabIndex = 7;
            // 
            // txtdiario
            // 
            this.txtdiario.Location = new System.Drawing.Point(278, 110);
            this.txtdiario.Name = "txtdiario";
            this.txtdiario.Size = new System.Drawing.Size(190, 27);
            this.txtdiario.TabIndex = 6;
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Location = new System.Drawing.Point(278, 73);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(190, 27);
            this.txtidentificacion.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(278, 33);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(190, 27);
            this.txtnombre.TabIndex = 4;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(24, 157);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(122, 20);
            this.lblDias.TabIndex = 3;
            this.lblDias.Text = "Dias laborados";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(21, 113);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(215, 20);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Asignación de salario diario";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacion.Location = new System.Drawing.Point(21, 76);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(107, 20);
            this.lblIdentificacion.TabIndex = 1;
            this.lblIdentificacion.Text = "Identificación";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(24, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(56, 330);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(170, 20);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor total devengado";
            // 
            // txtsalario
            // 
            this.txtsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario.Location = new System.Drawing.Point(313, 330);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(190, 27);
            this.txtsalario.TabIndex = 8;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(335, 272);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(137, 31);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "Calcular Salario";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(561, 406);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(95, 35);
            this.btnnuevo.TabIndex = 10;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(675, 406);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(95, 35);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.gbxEmpleado);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxEmpleado.ResumeLayout(false);
            this.gbxEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxEmpleado;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtdiario;
        private System.Windows.Forms.TextBox txtidentificacion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnsalir;
    }
}

