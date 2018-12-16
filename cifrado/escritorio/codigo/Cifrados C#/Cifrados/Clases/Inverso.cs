using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrados.Clases
{
    class Inverso
    {
        public Inverso()
        {
            texto = "";
        }

        public String texto;

        public String encriptar()
        {
            String resultado = "";
            for(int i=texto.Length-1; i >= 0; i--){
            char caracter_cifrado = texto[i];
            resultado += caracter_cifrado.ToString();
    }
    return resultado;
        }
    }
}
