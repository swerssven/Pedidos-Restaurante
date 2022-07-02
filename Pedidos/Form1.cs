using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pedido pedido1 = new Pedido();
        Pago pago1 = new Pago();
        public void resetTxt()
        {
            txt_Hamburguesa.Text = pedido1.hamburguesa.getCantidad().ToString();
            txt_Papas.Text = pedido1.papas.getCantidad().ToString();
            txt_Refresco.Text = pedido1.refresco.getCantidad().ToString();
            txt_Pizza.Text = pedido1.pizza.getCantidad().ToString();
            txt_Nugget.Text = pedido1.nugget.getCantidad().ToString();
            txt_Ensalada.Text = pedido1.ensalada.getCantidad().ToString();
            txt_Yogur.Text = pedido1.yogur.getCantidad().ToString();
            txt_Agua.Text = pedido1.agua.getCantidad().ToString();
        }

        // Método para mostrar botones.
        public void muestraBotonesPedido()
        {
            btn_MasHamburguesa.Show();
            btn_MasPapas.Show();
            btn_MasRefresco.Show();
            btn_MasPizza.Show();
            btn_MasNugget.Show();
            btn_MasEnsalada.Show();
            btn_MasYogur.Show();
            btn_MasAgua.Show();
            btn_MenosHamburguesa.Show();
            btn_MenosPapas.Show();
            btn_MenosRefresco.Show();
            btn_MenosPizza.Show();
            btn_MenosNugget.Show();
            btn_MenosEnsalada.Show();
            btn_MenosYogur.Show();
            btn_MenosAgua.Show();
        }

        // Método para ocultar botones.
        public void ocultaBotonesPedido()
        {
            btn_MasHamburguesa.Hide();
            btn_MasPapas.Hide();
            btn_MasRefresco.Hide();
            btn_MasPizza.Hide();
            btn_MasNugget.Hide();
            btn_MasEnsalada.Hide();
            btn_MasYogur.Hide();
            btn_MasAgua.Hide();
            btn_MenosHamburguesa.Hide();
            btn_MenosPapas.Hide();
            btn_MenosRefresco.Hide();
            btn_MenosPizza.Hide();
            btn_MenosNugget.Hide();
            btn_MenosEnsalada.Hide();
            btn_MenosYogur.Hide();
            btn_MenosAgua.Hide();
        }

        // Paquete 1
        private void rdb_Hamburg_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Hamburg.Checked)
            {
                btn_MasPaq1.Show();
                btn_MenosPaq1.Show();
            }
            else
            {
                btn_MasPaq1.Hide();
                btn_MenosPaq1.Hide();
            }
        }

        // Paquete 2
        private void rdb_Pizza_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Pizza.Checked)
            {
                btn_MasPaq2.Show();
                btn_MenosPaq2.Show();
            }
            else
            {
                btn_MasPaq2.Hide();
                btn_MenosPaq2.Hide();
            }
        }

        // Paquete 3
        private void rdb_Ensalada_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Ensalada.Checked)
            {
                btn_MasPaq3.Show();
                btn_MenosPaq3.Show();
            }
            else
            {
                btn_MasPaq3.Hide();
                btn_MenosPaq3.Hide();
            }
        }

        // Otras opciones
        private void rdb_Otros_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Otros.Checked)
            {
                muestraBotonesPedido();
            }
            else
            {
                ocultaBotonesPedido();
            }
        }

        private void btn_MasPaq1_Click(object sender, EventArgs e)
        {
            pedido1.hamburguesa.addCantidad();
            pedido1.papas.addCantidad();
            pedido1.refresco.addCantidad();
            resetTxt();
        }

        private void btn_MenosPaq1_Click(object sender, EventArgs e)
        {
            pedido1.hamburguesa.restCantidad();
            pedido1.papas.restCantidad();
            pedido1.refresco.restCantidad();
            resetTxt();
        }

        private void btn_MasPaq2_Click(object sender, EventArgs e)
        {
            pedido1.pizza.addCantidad();
            pedido1.nugget.addCantidad();
            pedido1.refresco.addCantidad();
            resetTxt();
        }

        private void btn_MenosPaq2_Click(object sender, EventArgs e)
        {
            pedido1.pizza.restCantidad();
            pedido1.nugget.restCantidad();
            pedido1.refresco.restCantidad();
            resetTxt();
        }

        private void btn_MasPaq3_Click(object sender, EventArgs e)
        {
            pedido1.ensalada.addCantidad();
            pedido1.yogur.addCantidad();
            pedido1.agua.addCantidad();
            resetTxt();
        }

        private void btn_MenosPaq3_Click(object sender, EventArgs e)
        {
            pedido1.ensalada.restCantidad();
            pedido1.yogur.restCantidad();
            pedido1.agua.restCantidad();
            resetTxt();
        }
        private void btn_MasHamburguesa_Click(object sender, EventArgs e)
        {
            pedido1.hamburguesa.addCantidad();
            resetTxt();
        }

        private void btn_MenosHamburguesa_Click(object sender, EventArgs e)
        {
            pedido1.hamburguesa.restCantidad();
            resetTxt();
        }

        private void btn_MasPapas_Click(object sender, EventArgs e)
        {
            pedido1.papas.addCantidad();
            resetTxt();
        }

        private void btn_MenosPapas_Click(object sender, EventArgs e)
        {
            pedido1.papas.restCantidad();
            resetTxt();
        }

        private void btn_MasRefresco_Click(object sender, EventArgs e)
        {
            pedido1.refresco.addCantidad();
            resetTxt();
        }

        private void btn_MenosRefresco_Click(object sender, EventArgs e)
        {
            pedido1.refresco.restCantidad();
            resetTxt();
        }

        private void btn_MasPizza_Click(object sender, EventArgs e)
        {
            pedido1.pizza.addCantidad();
            resetTxt();
        }

        private void btn_MenosPizza_Click(object sender, EventArgs e)
        {
            pedido1.pizza.restCantidad();
            resetTxt();
        }

        private void btn_MasNugget_Click(object sender, EventArgs e)
        {
            pedido1.nugget.addCantidad();
            resetTxt();
        }

        private void btn_MenosNugget_Click(object sender, EventArgs e)
        {
            pedido1.nugget.restCantidad();
            resetTxt();
        }

        private void btn_MenosYogur_Click(object sender, EventArgs e)
        {
            pedido1.yogur.restCantidad();
            resetTxt();
        }

        private void btn_MasYogur_Click(object sender, EventArgs e)
        {
            pedido1.yogur.addCantidad();
            resetTxt();
        }

        private void btn_MenosEnsalada_Click(object sender, EventArgs e)
        {
            pedido1.ensalada.restCantidad();
            resetTxt();
        }

        private void btn_MasEnsalada_Click(object sender, EventArgs e)
        {
            pedido1.ensalada.addCantidad();
            resetTxt();
        }

        private void btn_MasAgua_Click(object sender, EventArgs e)
        {
            pedido1.agua.addCantidad();
            resetTxt();
        }

        private void btn_MenosAgua_Click(object sender, EventArgs e)
        {
            pedido1.agua.restCantidad();
            resetTxt();
        }

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            try
            {
                // Cuando el campo pago esta vacio, calculamos subtotal, iva y total. Cuando no esta vacio significa que ya se
                // calculado los valores y le tendremos que pedir que instroduzca el codigo postal al cliente.
                if (txt_Pago.Text == "0")
                {
                    txt_CodigoPostal.Enabled = true;
                    txt_SubTotal.Text = pago1.getSubTotal(pedido1).ToString() + "$";
                    txt_IVA.Text = (Math.Round(pago1.getIva() * 100) / 100).ToString() + "$";
                    txt_Total.Text = pago1.getTotal().ToString() + "$";
                }
                else
                {
                    pago1.setCodigoPostal(Int32.Parse(txt_CodigoPostal.Text));
                    pago1.calculaCambio(Double.Parse(txt_Pago.Text));
                    txt_Cambio.Text = (Math.Round(pago1.getCambio() * 100) / 100).ToString() + "$";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campo \"Pago\" es solo numérico","Error");
            }
        }

        // Boton para generar nuevo pedido, destruye el pedido anterior y resetea todos los valores.
        private void btn_NuevaOperacion_Click(object sender, EventArgs e)
        {
            pedido1 = new Pedido();
            pago1 = new Pago();
            txt_CodigoPostal.Enabled = false;
            resetTxt();
            txt_SubTotal.Text = "0";
            txt_IVA.Text = "0";
            txt_Total.Text = "0";
            txt_Pago.Text = "0";
            txt_Cambio.Text = "0";
            txt_CodigoPostal.Text = "0";
        }

        // boton para salir de programa.
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "Salir?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txt_CodigoPostal.ValidatingType = typeof(String);
            this.txt_CodigoPostal.Mask = "00000";
        }

        private void txt_CodigoPostal_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput && txt_CodigoPostal.Text != "0")
            {
                this.Error1.SetError(this.txt_CodigoPostal, "Código postal incorrecto");
                // e.Cancel = true; Esto sirve para que el usuario no pueda abandonar.
            }
            else
            {
                this.Error1.Clear();
            }
            

        }

        // Al haber 2 formularios, para cerrar el form1 con la X hay que forzarlo.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
