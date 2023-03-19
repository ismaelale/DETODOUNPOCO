using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace DETODOUNPOCO.CLASESFORM2
{
    public class PROMEDIOS
    {

        public int notas(int n1, int n2, int n3, int n4)
        {

            int resultado = 0; 

            resultado = (n1 + n2 + n3 + n4) / 4 ;

            if(resultado < 70)
            {
                MessageBox.Show("Reprobado", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aprobado", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            return resultado;
        }

    }
}
