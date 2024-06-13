namespace miDolar
{
    public partial class Form1 : Form
    {
        Estatus pag = new Estatus();
        private async void status()
        {
            string estado = await pag.Estado();

            if (estado == "Disponible")
            {
                rbEstado.Checked = true;
            }

        }


        public Form1()
        {
            InitializeComponent();
            status();
        }

        Conversor conv = new Conversor();
        private async void btConvert_Click(object sender, EventArgs e)
        {
            
            string estado = await pag.Estado();

            if (tbMonto.Text != "")
            {
                decimal i = Convert.ToDecimal(tbMonto.Text);
                switch (cbDolar.SelectedIndex)
                {
                    case 0:


                        decimal blueC = await conv.blueCompra(i);
                        decimal blueV = await conv.blueVenta(i);
                        lbPrec.Items.Add(String.Format("-- [{0}] --", cbDolar.Text));
                        lbPrec.Items.Add(String.Format("[ Compra]  ${0:N2}", blueC));
                        lbPrec.Items.Add(String.Format("[ Venta ]  ${0:N2}", blueV));
                        tbMonto.Clear();
                        

                        break;

                    case 1:

                        decimal bolsaC = await conv.blueCompra(i);
                        decimal bolsaV = await conv.blueVenta(i);



                        lbPrec.Items.Add(String.Format("-- [{0}] --", cbDolar.Text));
                        lbPrec.Items.Add(String.Format("[ Compra ] ${0:N2}", bolsaC));
                        lbPrec.Items.Add(String.Format("[ Venta  ] ${0:N2}", bolsaV));
                        tbMonto.Clear();


                        break;

                    case 2:

                        decimal tarjetaC = await conv.blueCompra(i);
                        decimal tarjetaV = await conv.blueVenta(i);

                        lbPrec.Items.Add(String.Format("-- [{0}] --", cbDolar.Text));
                        lbPrec.Items.Add(String.Format("[ Compra ] ${0:N2}", tarjetaC));
                        lbPrec.Items.Add(String.Format("[ Venta  ] ${0:N2}", tarjetaV));
                        tbMonto.Clear();

                        break;
                    default:


                        MessageBox.Show("[ERROR]: Elijio un formato incorrecto", "DolarizaTE.", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        break;

                }

            }
            else
            {
                MessageBox.Show("[ERROR]: Ingrese un valor mayor a 0!", "DolarizaTE.", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbDolar_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbMonto.Enabled = true;
            
        }
    }
}