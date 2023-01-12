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
            panelContenedor.Width = this.Width - 120;
            panelContenedor.Height = this.Height -65;
        }

        private void cmdclientes_Click(object sender, EventArgs e)
        {
            /*GestionClientes ventanaGestionClientes = new GestionClientes();
            ventanaGestionClientes.ShowDialog();*/
            AbrirFormEnPanel(new GestionClientes());

        }



        private void AbrirFormEnPanel(object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

    }
}