using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DETODOUNPOCO.CLASESFORM2
{
    public  class ESTUDIANTES
    {

        public void depas(Form frm, ComboBox departamentos, ComboBox grados, ComboBox seccion)
        {

            string[] a = {"Choluteca", "Gracias a Dios", "Lempira", "La Paz", "Copan", "Francisco Morazan", "Olancho", 
                "Intibuca", "Islas de la Bahía", "Valle","Yoro","Santa Barbara"};

            departamentos.Items.AddRange(a);

            string[] b = { "Septimo", "Octavo", "Noveno", "Decimo", "Onceavo", "Doceavo" };

            grados.Items.AddRange(b);

            string[] c = { "A", "B", "C", "D" };

            seccion.Items.AddRange(c);

        }

        public void agregar(string depa, string nombre, string apellido, string grado, string seccion,
            int total, DataGridView data, int fila)
        {
            data.Rows[fila].Cells[0].Value = depa;
            data.Rows[fila].Cells[1].Value = nombre;
            data.Rows[fila].Cells[2].Value = apellido;
            data.Rows[fila].Cells[3].Value = grado;
            data.Rows[fila].Cells[4].Value = seccion;
            data.Rows[fila].Cells[5].Value = total; 
        }

        public void limpiaaaar(Form form)
        {
            ComboBox depa = form.Controls.OfType<ComboBox>().FirstOrDefault(a=>a.Name == "cbdepa");

            depa.ResetText();

            TextBox nombre = form.Controls.OfType<TextBox>().FirstOrDefault(c=>c.Name == "txtnombre");

            nombre.Text = "";

            TextBox apellido = form.Controls.OfType<TextBox>().FirstOrDefault(b=>b.Name == "txtapellido");

            apellido.Text = ""; 

            ComboBox grado = form.Controls.OfType<ComboBox>().FirstOrDefault(g=>g.Name == "cbgrado");

            grado.ResetText();

            ComboBox seccion = form.Controls.OfType<ComboBox>().FirstOrDefault(h=>h.Name == "cbseccion");

            seccion.ResetText();

        }

        public void groulimpiar(Form form, TextBox p1, TextBox p2, TextBox p3, TextBox p4, TextBox total)
        {
            p1.Text = "";
            p2.Text = "";
            p3.Text = "";
            p4.Text = "";
            total.Text = ""; 
        }

    }
}
