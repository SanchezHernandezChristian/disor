using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrados.Clases
{
    class Gruposinverso
    {

        public Gruposinverso()
        {
            texto = "";
            tamañogrupo = "";
        }

        public String texto;
        public String tamañogrupo;
        private String resultado = "";
        private static int grupoconvertido;

        public static int aentero(String tamañogrupo)
        {
            if (string.IsNullOrEmpty(tamañogrupo))
            {
                return 0;
            }
            return 1;
        }

        public String encriptar()
        {
            if (aentero(tamañogrupo) != 0)
            {
                grupoconvertido = Int32.Parse(tamañogrupo);
                int pares = texto.Length / grupoconvertido;
                Console.WriteLine(pares);
                for (int i = texto.Length - 1; i >= 0; i--)
                {
                    for (int grupo = 0; grupo >= pares; grupo = grupo + grupoconvertido)
                    {
                        Console.Write("for 2");

                        char caracter_cifrado = texto[i];
                        resultado += caracter_cifrado.ToString();
                    }
                }
                Console.Write(resultado);
                return resultado;
            }

            return "ingrese el tamaño del grupo";
        }
            
    }
}
