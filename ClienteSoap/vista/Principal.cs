using ClienteSoap.vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteSoap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicacion Desarrollada por: \n" + "Juan Pablo Rodriguez \n" +"William Bueno Medina");
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarFootballer agregar = new AgregarFootballer();
            agregar.Show();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar__Footballer listar = new Listar__Footballer();
            listar.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarFootballer buscar = new BuscarFootballer();
            buscar.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EditarFootballer editar = new EditarFootballer();
            editar.Show();
           
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarFootballer buscar = new EliminarFootballer();
            buscar.Show();
        }
    }
}
