using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {

        ArbolBinarioBusqueda b = new ArbolBinarioBusqueda();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarea nuevaTarea = new Tarea(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            Nodo n = new Nodo(nuevaTarea);
            b.insertar(n);
            MessageBox.Show("Agregado Exitosamente");
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
            textBox4.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String a=ArbolBinario.preorden(b.raizArbol());
            agregartexto(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String a = ArbolBinario.postorden(b.raizArbol());
            agregartexto(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String a = ArbolBinario.inorden(b.raizArbol());
            agregartexto(a);
        }

        public void agregartexto(string full) {

            listBox1.Items.Clear();
            string[] pasando = full.Split(new char[] { '-' });
            List<string> lines = new List<string>();
            foreach(string s in pasando){
                listBox1.Items.Add(s);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nodo resultado= b.buscar(new Tarea(textBox5.Text));
            if (resultado == null)
                MessageBox.Show("No se encontro el resultado");
            else {
                Tarea t = (Tarea)resultado.valorNodo();

                MessageBox.Show("Encontrado: Nombre:"+t.nombre()+" Duracion: "+t.duracion()+"  Porcentaje: "+t.porcentaje()+" Programador: "+t.programador());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Nodo resultado= b.buscar(new Tarea(textBox5.Text));
            b.eliminar(resultado);
            MessageBox.Show("Elminacion exitosa");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
