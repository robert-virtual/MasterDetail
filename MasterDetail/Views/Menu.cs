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
        public Menu(Colaborador colaborador_)
        {
            InitializeComponent();
            colaborador = colaborador_;
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ventas = new VentasView();
            SwitchPage(ventas);
        }
        void SwitchPage(Control value)
        {
            main_panel.Controls.Clear();
            main_panel.Controls.Add(value);
        }
        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inventario = new InventarioView();
            SwitchPage(inventario);

        }
    }
}
