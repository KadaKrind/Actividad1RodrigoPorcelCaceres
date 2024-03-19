using Computadora.BSS;
using Computadora.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computadora.VISTA.ComputadoraVista
{
    public partial class ComputadoraInsertar : Form
    {
        public ComputadoraInsertar()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        ComputadoraBSS bss = new ComputadoraBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            computadora c=new computadora();
            c.NOMBRE=textBox1.Text;
            c.DESCRIPCION=textBox2.Text;
            c.PRECIO=textBox3.Text;
            c.FECHAFABRICACION = dateTimePicker1.Value;
            bss.InsertarComputadoraBss(c);
            MessageBox.Show("Se guardo correctamente");
        }
    }
}
