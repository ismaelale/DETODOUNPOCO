using DETODOUNPOCO.CLASES;

namespace DETODOUNPOCO
{
    public partial class Form1 : Form
    {
        MANTENIMIENTO mante = new MANTENIMIENTO();
        CALCULO cal = new CALCULO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mante.llenarcombos(this, cbcantproducto);

        }

        private void cbcantproducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            txttotal.Text = cal.calculos(Convert.ToInt32(cbcantproducto.SelectedItem), Convert.ToInt32(txtprecio.Text)).ToString();
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            int fila = dataregistros.Rows.Add();

            mante.agregr(txtnombre.Text, txtproducto.Text, Convert.ToInt32(cbcantproducto.SelectedItem),
                datecompra.Value, Convert.ToInt32(txttotal.Text), dataregistros, fila);
            MessageBox.Show("Se ha agregado correctamente", "Confimation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mante.limpiarr(this);

        }

        private void btcambios_Click(object sender, EventArgs e)
        {
            PROMEDIO pro = new PROMEDIO();
            this.Hide(); 
            pro.Show();

        }
    }
}