namespace AplicacionDePago
{
    partial class frmPago
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
            groupBox1 = new GroupBox();
            rbtnEfectivo = new RadioButton();
            rbtnTarjeta = new RadioButton();
            label1 = new Label();
            lstTarjetas = new ListBox();
            txtNroTarjeta = new TextBox();
            label2 = new Label();
            cmbMesExpiracion = new ComboBox();
            cmbAñoExpiracion = new ComboBox();
            label3 = new Label();
            btnOk = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnEfectivo);
            groupBox1.Controls.Add(rbtnTarjeta);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 66);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Facturacion";
            // 
            // rbtnEfectivo
            // 
            rbtnEfectivo.AutoSize = true;
            rbtnEfectivo.Location = new Point(175, 29);
            rbtnEfectivo.Name = "rbtnEfectivo";
            rbtnEfectivo.Size = new Size(67, 19);
            rbtnEfectivo.TabIndex = 1;
            rbtnEfectivo.TabStop = true;
            rbtnEfectivo.Text = "Efectivo";
            rbtnEfectivo.UseVisualStyleBackColor = true;
            rbtnEfectivo.CheckedChanged += TipoFacturacion_CheckedChanged;
            // 
            // rbtnTarjeta
            // 
            rbtnTarjeta.AutoSize = true;
            rbtnTarjeta.Location = new Point(54, 29);
            rbtnTarjeta.Name = "rbtnTarjeta";
            rbtnTarjeta.Size = new Size(59, 19);
            rbtnTarjeta.TabIndex = 0;
            rbtnTarjeta.TabStop = true;
            rbtnTarjeta.Text = "Tarjeta";
            rbtnTarjeta.UseVisualStyleBackColor = true;
            rbtnTarjeta.CheckedChanged += TipoFacturacion_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 105);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Tipo de tarjeta";
            // 
            // lstTarjetas
            // 
            lstTarjetas.FormattingEnabled = true;
            lstTarjetas.ItemHeight = 15;
            lstTarjetas.Location = new Point(122, 105);
            lstTarjetas.Name = "lstTarjetas";
            lstTarjetas.Size = new Size(173, 94);
            lstTarjetas.TabIndex = 2;
            // 
            // txtNroTarjeta
            // 
            txtNroTarjeta.Location = new Point(122, 217);
            txtNroTarjeta.Name = "txtNroTarjeta";
            txtNroTarjeta.Size = new Size(173, 23);
            txtNroTarjeta.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 220);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 4;
            label2.Text = "Nro de tarjeta";
            // 
            // cmbMesExpiracion
            // 
            cmbMesExpiracion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMesExpiracion.FormattingEnabled = true;
            cmbMesExpiracion.Location = new Point(122, 262);
            cmbMesExpiracion.Name = "cmbMesExpiracion";
            cmbMesExpiracion.Size = new Size(116, 23);
            cmbMesExpiracion.TabIndex = 5;
            // 
            // cmbAñoExpiracion
            // 
            cmbAñoExpiracion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAñoExpiracion.FormattingEnabled = true;
            cmbAñoExpiracion.Location = new Point(249, 262);
            cmbAñoExpiracion.Name = "cmbAñoExpiracion";
            cmbAñoExpiracion.Size = new Size(94, 23);
            cmbAñoExpiracion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 265);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 7;
            label3.Text = "Fecha expiracion";
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(144, 331);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 27);
            btnOk.TabIndex = 9;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(249, 331);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 27);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 388);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(label3);
            Controls.Add(cmbAñoExpiracion);
            Controls.Add(cmbMesExpiracion);
            Controls.Add(label2);
            Controls.Add(txtNroTarjeta);
            Controls.Add(lstTarjetas);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "frmPago";
            Text = "frmPago";
            Load += frmPago_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbtnEfectivo;
        private RadioButton rbtnTarjeta;
        private Label label1;
        private ListBox lstTarjetas;
        private TextBox txtNroTarjeta;
        private Label label2;
        private ComboBox cmbMesExpiracion;
        private ComboBox cmbAñoExpiracion;
        private Label label3;
        private Button btnOk;
        private Button btnCancelar;
    }
}