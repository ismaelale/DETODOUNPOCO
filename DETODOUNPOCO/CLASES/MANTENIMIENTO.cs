using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace DETODOUNPOCO.CLASES
{
    public class MANTENIMIENTO
    {

        public void llenarcombos(Form frm, ComboBox canti)
        {
           
           for(int i = 1; i <= 20; i++)
            {
                canti.Items.Add(i);
            }

        }

        public void agregr(string nombre, string productos, int canti, DateTime compra, int total,
            DataGridView data, int fila)
        {
            data.Rows[fila].Cells[0].Value = nombre;
            data.Rows[fila].Cells[1].Value = productos;
            data.Rows[fila].Cells[2].Value = canti; 
            data.Rows[fila].Cells[3].Value = compra.ToShortDateString();
            data.Rows[fila].Cells[4].Value = total; 
        }

        public void limpiarr(Form frm)
        {
            TextBox nombre = frm.Controls.OfType<TextBox>().FirstOrDefault(a=>a.Name == "txtnombre");

            nombre.Text = ""; 

            TextBox productos = frm.Controls.OfType<TextBox>().FirstOrDefault(b=>b.Name == "txtproducto");

            productos.Text = "";

            ComboBox cantid = frm.Controls.OfType<ComboBox>().FirstOrDefault(c=>c.Name == "cbcantproducto");

            cantid.ResetText();
            
            DateTimePicker compras = frm.Controls.OfType<DateTimePicker>().FirstOrDefault(x=>x.Name == "datecompra");
            compras.Value = DateTime.Now; 
           
            TextBox precio = frm.Controls.OfType<TextBox>().FirstOrDefault(b=>b.Name == "txtprecio");

            precio.Text = "";

            TextBox total = frm.Controls.OfType<TextBox>().FirstOrDefault(n=>n.Name == "txttotal");

            total.Text = ""; 
            

        }



    }
}
