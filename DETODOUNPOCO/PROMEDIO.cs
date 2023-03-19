using DETODOUNPOCO.CLASES;
using DETODOUNPOCO.CLASESFORM2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DETODOUNPOCO
{
    public partial class PROMEDIO : Form
    {
        ESTUDIANTES estu = new ESTUDIANTES();
        restricciones res = new restricciones();
        PROMEDIOS pro = new PROMEDIOS();
        public PROMEDIO()
        {
            InitializeComponent();
        }

        private void PROMEDIO_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            estu.depas(this, cbdepa, cbgrado, cbseccion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            int fila = dataregistros.Rows.Add();

            estu.agregar(cbdepa.SelectedItem.ToString(), txtnombre.Text, txtapellido.Text, cbgrado.SelectedItem.ToString(),
                cbseccion.SelectedItem.ToString(), Convert.ToInt32(txtprom.Text), dataregistros, fila);

            estu.limpiaaaar(this);
            estu.groulimpiar(this, txtp1, txtp2, txtp3, txtp4, txtprom);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            res.letraas(txtnombre, e);
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            res.letraas(txtapellido, e);
        }

        private void btcalcular_Click(object sender, EventArgs e)
        {
            txtprom.Text = pro.notas(Convert.ToInt32(txtp1.Text), Convert.ToInt32(txtp2.Text), Convert.ToInt32(txtp3.Text), Convert.ToInt32(txtp4.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PERSONALES personal = new PERSONALES();
            this.Hide();
            personal.Show();
        }
    }
}
