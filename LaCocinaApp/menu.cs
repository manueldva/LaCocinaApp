using System.Windows.Forms;
using System;

namespace LaCocinaApp
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdclientes_Click(object sender, EventArgs e)
        {
            

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea Salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes FormularioVista = new frmClientes();
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosing += Frm_Closing;
        }


        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}