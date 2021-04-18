using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBanco
{
    public partial class FrmCalculadoraPrestamoo : Form
    {
        double montoPrestamo = 0;
        double tasaInteres = 0;
        int cantCuotas = 0;

        public FrmCalculadoraPrestamoo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!parametrosValidos())
                return;
            limpiarResultados();
            calcularPrestamo();
        }

        private bool parametrosValidos()
        {
            try
            {
                montoPrestamo = double.Parse(txtMontoPrestamo.Text);
                tasaInteres = double.Parse(txtTasaInteres.Text);
                cantCuotas = (int)NudCuotas.Value;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existen parametros incorrectos");
                return false;
            }
        }

        private void limpiarResultados()
        {
            try
            {
                LstNumCuota.Items.Clear();
                LstCapitalCuota.Items.Clear();
                LstInteresCuota.Items.Clear();
                LstMontoCuota.Items.Clear();
                LstCapitalPagado.Items.Clear();
                LstCapitalRestante.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar resultados. " + ex.Message);
            }
        }

        private void calcularPrestamo()
        {
            try
            {
                double capitalCuota = montoPrestamo/cantCuotas;
                double interesCuota = (montoPrestamo * tasaInteres / 100) / 12;
                double montoCuota = capitalCuota + interesCuota;
                double capitalPagado = 0;
                double capitalRestante = 0;

                for (int cuota = 1;  cuota <= cantCuotas;  cuota++)
                {
                    capitalPagado += capitalCuota;
                    capitalRestante = montoPrestamo - capitalPagado;

                    LstNumCuota.Items.Add(cuota);
                    LstCapitalCuota.Items.Add(capitalCuota.ToString("#,###,##0.00"));
                    LstInteresCuota.Items.Add(interesCuota.ToString("#,###,##0.00"));
                    LstMontoCuota.Items.Add(montoCuota.ToString("#,###,##0.00"));
                    LstCapitalPagado.Items.Add(capitalPagado.ToString("#,###,##0.00"));
                    LstCapitalRestante.Items.Add(capitalRestante.ToString("#,###,##0.00"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular prestamo. " + ex.Message);
            }
        }
    }
}
