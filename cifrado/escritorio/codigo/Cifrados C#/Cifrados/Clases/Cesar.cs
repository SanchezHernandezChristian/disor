using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrados.Clases
{
    class Cesar : ICifrados
    {
        public Cesar()
        {
            texto = "";
            desplazamiento = "";
            alfabeto = "";
        }

        public String texto;
        public String desplazamiento;
        public String alfabeto;
        private String resultado = "";
        private int sobrante;
        private static int desplazamientoconvertido;


        public static int aentero(String desplazamiento)
        { 
            if (string.IsNullOrEmpty(desplazamiento))
            {
                return 0;
            }
            return 1; 
        }

        public String encriptar(){

            if (aentero(desplazamiento) != 0)
            {
                desplazamientoconvertido = Int32.Parse(desplazamiento);
                for (int i = 0; i < texto.Length; i++)
                {
                    char caracter_cifrado = ' ';
                    int indice_actual = alfabeto.IndexOf(texto[i]);
                    int residuo = desplazamientoconvertido % alfabeto.Length;
                    if ((indice_actual + residuo) < alfabeto.Length)
                    {
                        caracter_cifrado = alfabeto[(indice_actual + residuo)];
                        resultado += caracter_cifrado.ToString();
                    }
                    else
                    {
                        var indice_actual_temporal = indice_actual + residuo;
                        sobrante = indice_actual_temporal - alfabeto.Length;
                        caracter_cifrado = alfabeto[sobrante];
                        resultado += caracter_cifrado.ToString();
                    }
                }
                return resultado;
            }
            return "ingrese desplazamiento";
            }
    
    }
}
