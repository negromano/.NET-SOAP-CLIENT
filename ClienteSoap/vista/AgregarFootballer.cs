using ClienteSoap.ServiceFootballer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteSoap.vista
{

    

    public partial class AgregarFootballer : Form
    {
        private ClienteSoap.ServiceFootballer.footballer footballer;
            

        public AgregarFootballer()
        {

            InitializeComponent();
         
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicacion Desarrollada por: \n" + "Juan Pablo Rodriguez \n" + "William Bueno Medina");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ServiceFootballer.ServicesClient soap = new ServiceFootballer.ServicesClient();

            String id;
            String name;
            String forename;
            String position;
            String club;
            int number;
            double height;

            id = txtId.Text;
            name = txtNombre.Text;
            forename = txtApellido.Text;
            position = txtNumero.Text;
            club = txtClub.Text;
            number = Convert.ToInt32(txtNumero.Text);
            height = Convert.ToDouble(txtEstatura.Text);

            footballer = new ClienteSoap.ServiceFootballer.footballer();
            footballer.surname = name;
            footballer.id = id;
            footballer.forename = forename;
            footballer.position = position;
            footballer.number = number;
            footballer.height = height;
            footballer.club = club;

            soap.create(footballer);

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
