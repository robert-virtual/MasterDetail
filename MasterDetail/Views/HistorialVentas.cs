using MasterDetail.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using MasterDetail.Models;

namespace MasterDetail.Views
{
    public partial class HistorialVentas : UserControl
    {
        List<DetalleVenta> detalles;
        List<Venta> ventas;
        public HistorialVentas()
        {
            InitializeComponent();
            CargarVentas();
        }
        void CargarDGV(int idx = 0)
        {
            if (idx == 0)
            {
                dgv_ventas.DataSource = ventas ;

            } 
            else
            {
                dgv_ventas.DataSource = detalles ;

            }
        }
        void CargarVentas(int type = 0)
        {

            using (var db = new VentasDBContext())
            {
                if (type == 0)
                {
                     ventas = ventas == null ? db.Ventas
                        .Include("Colaborador")
                        .Include("Cliente")
                        .Include("TipoVenta")
                        .ToList() : ventas;
                    CargarDGV();
                } 
                else 
                {
                    detalles = detalles == null ? db.DetallesVenta
                        .Include("Venta.TipoVenta")
                        .Include("Producto")
                        .ToList(): detalles;
                    CargarDGV(1);
                
                } 
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            detalles = null;
            ventas = null;
            CargarVentas();
        }

        private void cb_show_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarVentas(cb_show.SelectedIndex);
        }
    }
}
