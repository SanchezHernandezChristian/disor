using Cifrados.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cifrados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textoclaro_KeyUp(object sender, KeyEventArgs e)
        {
            crearcesar();
            crearinverso();
            crearinversogrupos();

        }
        private void boxdesplazamiento_KeyUp(object sender, KeyEventArgs e)
        {
            crearcesar();
        }

        public void crearcesar()
        {
            Cesar cesar = new Cesar();
            cesar.texto = textoclaro.Text;
            cesar.alfabeto = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789";
            cesar.desplazamiento = boxdesplazamiento.Text;
            txtcifradocesar.Text = cesar.encriptar();

        }

        public void crearinverso()
        {
            Inverso inverso = new Inverso();
            inverso.texto = textoclaro.Text;
            txtcifradoinverso.Text = inverso.encriptar();
        }

        

        public void crearinversogrupos()
        {
            Gruposinverso gruposinverso = new Gruposinverso();
            gruposinverso.texto = textoclaro.Text;
            gruposinverso.tamañogrupo = boxgrupos.Text;
            cifradogruposinverso.Text = gruposinverso.encriptar();
        }

        private void boxgrupos_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
