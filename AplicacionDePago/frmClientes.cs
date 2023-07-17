namespace AplicacionDePago
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }


        bool datosGuardados = true;

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cboNombres.Items.Add("Matias Solari");
            cboNombres.Items.Add("Noelia Hernadez");
        }

        private void lblPago_TextChanged(object sender, EventArgs e)
        {
            datosGuardados = false;
        }

        private void cboNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            datosGuardados = false;
            lblPago.Text = "";
        }

        private void btnSeleccionarPago_Click(object sender, EventArgs e)
        {
            frmPago p = new frmPago();
            DialogResult botonElegigo = p.ShowDialog();
            if (botonElegigo == DialogResult.OK)
            {
                lblPago.Text = p.Tag.ToString();
            }
        }

        private void guargarDatos()
        {
            cboNombres.SelectedIndex = -1;
            lblPago.Text = "";
            datosGuardados = true;
            cboNombres.Focus();
        }

        private bool esDataValida()
        {
            if (cboNombres.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un cliente", "Error");
                cboNombres.Focus();
                return false;
            }
            if (lblPago.Text == "")
            {
                MessageBox.Show("Se debe ingresar un tipo de pago");
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (esDataValida() == true)
            {
                guargarDatos();
            }
        }

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (datosGuardados == false)
            {
                DialogResult boton = MessageBox.Show(
                    "Este formulario tiene datos sin guardar.¿Queres guardar la informacion?"
                    , "Atencion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (boton == DialogResult.Yes) 
                {
                    if (esDataValida()==true)
                    {
                        guargarDatos();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }

                if (boton == DialogResult.Cancel)
                {
                    e.Cancel=true;
                }
                

            }
        }
    }

}