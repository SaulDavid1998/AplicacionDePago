namespace AplicacionDePago
{
    partial class frmClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            btnGuardar = new Button();
            lblPago = new Label();
            btnSeleccionarPago = new Button();
            label2 = new Label();
            label1 = new Label();
            cboNombres = new ComboBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.DialogResult = DialogResult.Cancel;
            btnSalir.Location = new Point(291, 217);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 27);
            btnSalir.TabIndex = 28;
            btnSalir.Text = "&Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(188, 217);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 27);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "&Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblPago
            // 
            lblPago.BorderStyle = BorderStyle.Fixed3D;
            lblPago.Location = new Point(11, 97);
            lblPago.Margin = new Padding(4, 0, 4, 0);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(233, 92);
            lblPago.TabIndex = 26;
            lblPago.TextChanged += lblPago_TextChanged;
            // 
            // btnSeleccionarPago
            // 
            btnSeleccionarPago.Location = new Point(263, 97);
            btnSeleccionarPago.Margin = new Padding(4, 3, 4, 3);
            btnSeleccionarPago.Name = "btnSeleccionarPago";
            btnSeleccionarPago.Size = new Size(121, 27);
            btnSeleccionarPago.TabIndex = 25;
            btnSeleccionarPago.Text = "Seleccionar";
            btnSeleccionarPago.Click += btnSeleccionarPago_Click;
            // 
            // label2
            // 
            label2.Location = new Point(11, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 27);
            label2.TabIndex = 24;
            label2.Text = "Metodo de pago:";
            // 
            // label1
            // 
            label1.Location = new Point(11, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 27);
            label1.TabIndex = 23;
            label1.Text = "Nombre del cliente:";
            // 
            // cboNombres
            // 
            cboNombres.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNombres.FormattingEnabled = true;
            cboNombres.Location = new Point(151, 23);
            cboNombres.Margin = new Padding(4, 3, 4, 3);
            cboNombres.Name = "cboNombres";
            cboNombres.Size = new Size(233, 23);
            cboNombres.TabIndex = 22;
            cboNombres.SelectedIndexChanged += cboNombres_SelectedIndexChanged;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 268);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(lblPago);
            Controls.Add(btnSeleccionarPago);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboNombres);
            MaximumSize = new Size(428, 307);
            MinimumSize = new Size(428, 307);
            Name = "frmClientes";
            FormClosing += frmClientes_FormClosing;
            Load += frmClientes_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSalir;
        private Button btnGuardar;
        private Label lblPago;
        private Button btnSeleccionarPago;
        private Label label2;
        private Label label1;
        private ComboBox cboNombres;
    }
}