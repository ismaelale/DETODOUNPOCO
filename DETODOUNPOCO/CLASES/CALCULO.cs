using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace DETODOUNPOCO.CLASES
{
    public class CALCULO
    {

        private int cantidad;
        private int preciooos;

        public int Cantidad { get; set; }   
        public int Precioos { get; set; }   

        public int calculos(int canti, int precio) 
        {

            int resultado = canti * precio;

            return  resultado; 
        }
    }
}
