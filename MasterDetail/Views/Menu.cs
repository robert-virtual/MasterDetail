using MasterDetail.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MasterDetail.Views
{
    public partial class Menu : Form
    {
        public static Colaborador colaborador;
        private List<UserControl> Pages = new List<UserControl>() 
        {
            new VentasView(),
            new InventarioView(), 
            new HistorialVentas(),
            new ClientesView(),
        };

        public Menu(Colaborador colaborador_)
        {
            InitializeComponent();
            colaborador = colaborador_;
            this.Text = $"Menu - {colaborador}";
            LoadNavegacion();  
        }
        void LoadNavegacion(int pageIdx = 0)
        {
            
            SwitchPage(Pages[pageIdx]);

        }
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNavegacion(0);
        }
        void SwitchPage(Control value)
        {
            main_panel.Controls.Clear();
            main_panel.Controls.Add(value);
        }
        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNavegacion(1);

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }

        private void historialVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LoadNavegacion(2);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNavegacion(3);

        }
    }
}
