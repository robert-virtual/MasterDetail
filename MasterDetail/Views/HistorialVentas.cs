using MasterDetail.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace MasterDetail.Views
{
    public partial class HistorialVentas : UserControl
    {
        public HistorialVentas()
        {
            InitializeComponent();
            CargarVentas();
        }
        void CargarVentas()
        {
            using (var db = new VentasDBContext())
            {
                //dgv_ventas.DataSource = db.Ventas
                //    .Include("Colaborador")
                //    .Include("Cliente")
                //    .Include("TipoVenta")
                //    .ToList(); 
                dgv_ventas.DataSource = db.DetallesVenta
                    .Include("Venta.TipoVenta")
                    .Include("Producto")
                    .ToList();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }
    }
}
