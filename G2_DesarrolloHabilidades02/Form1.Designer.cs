namespace G2_DesarrolloHabilidades02
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lblNombreBanco = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblDui = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblNumCuenta = new System.Windows.Forms.Label();
            this.lblMontoDispo = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.tbxDui = new System.Windows.Forms.MaskedTextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxTipoCuenta = new System.Windows.Forms.ComboBox();
            this.tbxNit = new System.Windows.Forms.MaskedTextBox();
            this.tbxNumCuenta = new System.Windows.Forms.MaskedTextBox();
            this.tbxMonto = new System.Windows.Forms.TextBox();
            this.tbxSucursal = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lblNombreBanco
            // 
            this.lblNombreBanco.AutoSize = true;
            this.lblNombreBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBanco.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNombreBanco.Location = new System.Drawing.Point(259, 9);
            this.lblNombreBanco.Name = "lblNombreBanco";
            this.lblNombreBanco.Size = new System.Drawing.Size(214, 32);
            this.lblNombreBanco.TabIndex = 0;
            this.lblNombreBanco.Text = "Banco Nacional";
            this.lblNombreBanco.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.tbxSucursal);
            this.gbCliente.Controls.Add(this.tbxMonto);
            this.gbCliente.Controls.Add(this.tbxNumCuenta);
            this.gbCliente.Controls.Add(this.tbxNit);
            this.gbCliente.Controls.Add(this.tbxTipoCuenta);
            this.gbCliente.Controls.Add(this.tbxApellido);
            this.gbCliente.Controls.Add(this.tbxNombre);
            this.gbCliente.Controls.Add(this.tbxDui);
            this.gbCliente.Controls.Add(this.lblSucursal);
            this.gbCliente.Controls.Add(this.lblMontoDispo);
            this.gbCliente.Controls.Add(this.lblNumCuenta);
            this.gbCliente.Controls.Add(this.lblNit);
            this.gbCliente.Controls.Add(this.lblTipoCuenta);
            this.gbCliente.Controls.Add(this.lblApellido);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.lblDui);
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(12, 56);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(438, 441);
            this.gbCliente.TabIndex = 1;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos de Cliente";
            // 
            // lblDui
            // 
            this.lblDui.AutoSize = true;
            this.lblDui.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDui.Location = new System.Drawing.Point(6, 50);
            this.lblDui.Name = "lblDui";
            this.lblDui.Size = new System.Drawing.Size(38, 20);
            this.lblDui.TabIndex = 0;
            this.lblDui.Text = "DUI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(6, 150);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.AutoSize = true;
            this.lblTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCuenta.Location = new System.Drawing.Point(6, 200);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(122, 20);
            this.lblTipoCuenta.TabIndex = 3;
            this.lblTipoCuenta.Text = "Tipo de Cuenta";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.Location = new System.Drawing.Point(6, 250);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(35, 20);
            this.lblNit.TabIndex = 4;
            this.lblNit.Text = "NIT";
            // 
            // lblNumCuenta
            // 
            this.lblNumCuenta.AutoSize = true;
            this.lblNumCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCuenta.Location = new System.Drawing.Point(6, 300);
            this.lblNumCuenta.Name = "lblNumCuenta";
            this.lblNumCuenta.Size = new System.Drawing.Size(149, 20);
            this.lblNumCuenta.TabIndex = 5;
            this.lblNumCuenta.Text = "Número de Cuenta";
            // 
            // lblMontoDispo
            // 
            this.lblMontoDispo.AutoSize = true;
            this.lblMontoDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoDispo.Location = new System.Drawing.Point(6, 350);
            this.lblMontoDispo.Name = "lblMontoDispo";
            this.lblMontoDispo.Size = new System.Drawing.Size(139, 20);
            this.lblMontoDispo.TabIndex = 6;
            this.lblMontoDispo.Text = "Monto Disponible";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(6, 400);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(75, 20);
            this.lblSucursal.TabIndex = 7;
            this.lblSucursal.Text = "Sucursal";
            // 
            // tbxDui
            // 
            this.tbxDui.Location = new System.Drawing.Point(200, 43);
            this.tbxDui.Mask = "00000000-0";
            this.tbxDui.Name = "tbxDui";
            this.tbxDui.Size = new System.Drawing.Size(160, 30);
            this.tbxDui.TabIndex = 8;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(200, 93);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(160, 30);
            this.tbxNombre.TabIndex = 9;
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(200, 143);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(160, 30);
            this.tbxApellido.TabIndex = 10;
            // 
            // tbxTipoCuenta
            // 
            this.tbxTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbxTipoCuenta.FormattingEnabled = true;
            this.tbxTipoCuenta.Location = new System.Drawing.Point(200, 193);
            this.tbxTipoCuenta.Name = "tbxTipoCuenta";
            this.tbxTipoCuenta.Size = new System.Drawing.Size(160, 33);
            this.tbxTipoCuenta.TabIndex = 11;
            // 
            // tbxNit
            // 
            this.tbxNit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNit.Location = new System.Drawing.Point(200, 243);
            this.tbxNit.Mask = "0000-000000-000-0";
            this.tbxNit.Name = "tbxNit";
            this.tbxNit.Size = new System.Drawing.Size(160, 27);
            this.tbxNit.TabIndex = 12;
            // 
            // tbxNumCuenta
            // 
            this.tbxNumCuenta.Location = new System.Drawing.Point(200, 293);
            this.tbxNumCuenta.Mask = "000-000000";
            this.tbxNumCuenta.Name = "tbxNumCuenta";
            this.tbxNumCuenta.Size = new System.Drawing.Size(160, 30);
            this.tbxNumCuenta.TabIndex = 13;
            // 
            // tbxMonto
            // 
            this.tbxMonto.Location = new System.Drawing.Point(200, 343);
            this.tbxMonto.Name = "tbxMonto";
            this.tbxMonto.Size = new System.Drawing.Size(160, 30);
            this.tbxMonto.TabIndex = 14;
            // 
            // tbxSucursal
            // 
            this.tbxSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbxSucursal.FormattingEnabled = true;
            this.tbxSucursal.Location = new System.Drawing.Point(200, 393);
            this.tbxSucursal.Name = "tbxSucursal";
            this.tbxSucursal.Size = new System.Drawing.Size(160, 33);
            this.tbxSucursal.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(550, 100);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.Location = new System.Drawing.Point(550, 200);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(100, 35);
            this.btnDeposito.TabIndex = 3;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnRetiro
            // 
            this.btnRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetiro.Location = new System.Drawing.Point(550, 300);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(100, 35);
            this.btnRetiro.TabIndex = 4;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(550, 400);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 35);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 527);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.lblNombreBanco);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label lblNombreBanco;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDui;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.Label lblMontoDispo;
        private System.Windows.Forms.Label lblNumCuenta;
        private System.Windows.Forms.MaskedTextBox tbxDui;
        private System.Windows.Forms.ComboBox tbxSucursal;
        private System.Windows.Forms.TextBox tbxMonto;
        private System.Windows.Forms.MaskedTextBox tbxNumCuenta;
        private System.Windows.Forms.MaskedTextBox tbxNit;
        private System.Windows.Forms.ComboBox tbxTipoCuenta;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnEliminar;
    }
}

