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
    }
}
