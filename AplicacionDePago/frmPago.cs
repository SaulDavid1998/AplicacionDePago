using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDePago
{
    public partial class frmPago : Form
    {
        public frmPago()
        {
            InitializeComponent();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            lstTarjetas.Items.Add("Visa");
            lstTarjetas.Items.Add("Mastercad");

            string[] meses = {"Selecciona mes", "Enero" ,  "Febrero", "Marzo",
            "Abri","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};

            for (int i = 0; i < meses.Length; i++)
            {
                cmbMesExpiracion.Items.Add(meses[i]);
            }

            int año = DateTime.Now.Year;
            int añoExpiracion = año + 8;

            cmbAñoExpiracion.Items.Add("Selecciona año");
            while (año < añoExpiracion)
            {
                cmbAñoExpiracion.Items.Add(año);
                año++;
            }

            cmbAñoExpiracion.SelectedIndex = 0;
            cmbMesExpiracion.SelectedIndex = 0;
        }

        private bool Validacion()
        {
            if (rbtnTarjeta.Checked == true)
            {
                if (lstTarjetas.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe seleccionar un tipo de tarjeta", "Error: seleccion de tarjeta");
                    return false;
                }
                if (txtNroTarjeta.Text == "")
                {
                    MessageBox.Show("Se debe ingresar un numero de tarjeta", "Error: numero de tarjeta");
                    return false;
                }
                if (cmbMesExpiracion.SelectedIndex == 0)
                {
                    MessageBox.Show("Se debe seleccionar un mes", "Error: seleccion de mes");
                    return false;
                }

                if (cmbAñoExpiracion.SelectedIndex == 0)
                {
                    MessageBox.Show("Se debe seleccionar un año", "Error: seleccion de año");
                    return false;
                }

            }
            return true;
        }

        private void GuardarDatos()
        {
            string mensaje = "";

            if (rbtnTarjeta.Checked == true)
            {
                mensaje = "Cargado a tarjeta de credito\n\n" +
                    "Tipo de tarjeta: " + lstTarjetas.SelectedItem.ToString() + "\n" +
                    "Numero de tarjeta:" + txtNroTarjeta.Text + "\n" +
                    "Expiracion: " + cmbMesExpiracion.Text + "/" + cmbAñoExpiracion.Text;
            }

            if (rbtnEfectivo.Checked == true)
            {
                mensaje = "Enviar factura al cliente";
            }

            Tag = mensaje;

        }


        private void btnOk_Click(object sender, EventArgs e)
        {

            if (Validacion() == true)
            {
                GuardarDatos();
                //DialogResult=DialogResult.Ok //establecido en el diseñador en la propiedad del boton
            }

            else
            {
                DialogResult = DialogResult.None;
            }
        }

        private void TipoFacturacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEfectivo.Checked == true)
            {
                lstTarjetas.Enabled = false;
                txtNroTarjeta.Enabled = false;
                cmbAñoExpiracion.Enabled = false;
                cmbMesExpiracion.Enabled = false;

            }

            else
            {
                lstTarjetas.Enabled = true;
                txtNroTarjeta.Enabled = true;
                cmbAñoExpiracion.Enabled = true;
                cmbMesExpiracion.Enabled = true;
            }
        }
    }
}
