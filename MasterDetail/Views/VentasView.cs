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
    public partial class VentasView : UserControl
    {
        private Venta venta = new Venta();
        List<Producto> productos;
        Cliente cliente;
        public VentasView()
        {
            InitializeComponent();
            LoadProds();
        }
        void LoadProds()
        {
            using (var db = new VentasDBContext())
            {
                productos = db.Productos.Include("Categoria").ToList();
                dgv_prods.DataSource = productos; 
            }
        }

        dynamic GetDGVCell(int cell)
        {
            int row = dgv_prods.CurrentRow.Index;

            return dgv_prods.Rows[row].Cells[cell].Value;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            var descuento = n_precio.Value * (n_decuento.Value/100);
            var prodId = GetDGVCell(0);
            var detalle = new DetalleVenta()
            {
                ProductoId = prodId,
                Producto = productos.Find( p => p.Id == prodId),
                Cantidad = (int)n_cantidad.Value,
                PrecioVenta = n_precio.Value - descuento,
                Descuento = descuento,
                Venta = venta,
                
            };
            venta.DetallesVenta.Add(detalle);
            UpdateListBoxVenta();
        }
        void UpdateListBoxVenta() 
        {
            lb_prods_venta.DataSource = null;
            lb_prods_venta.DataSource = venta.DetallesVenta;
        }
        private void btn_terminar_venta_Click(object sender, EventArgs e)
        {
            try
            {
                venta.ClienteDNI = cliente == null ? null: cliente.DNI;
                cliente = cliente == null ? new Cliente()
                {
                    DNI = txt_dni_cliente.Text.Trim(),
                    Nombre = txt_nombre_cliente.Text.Trim(),
                    Telefono = txt_tel_cliente.Text.Trim()
                } : null;
                venta.ColaboradorDNI = Menu.colaborador.DNI;
                venta.Cliente = cliente;
                venta.TipoVentaId = 1;
                venta.DetallesVenta = venta.DetallesVenta.ConvertAll(dv => 
                {
                    
                    dv.Producto = null;
                    return dv;
                });
                using (var db = new VentasDBContext())
                {
                    db.Ventas.Add(venta);
                    db.SaveChanges();
                }
                MessageBox.Show($"Venta Realizada", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            catch (Exception err)
            {

                MessageBox.Show($"Erros: {err}", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
        }

        private void dgv_prods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n_precio.Value = GetDGVCell(2);
        }

        private void txt_dni_cliente_KeyUp(object sender, KeyEventArgs e)
        {
            var dni = txt_dni_cliente.Text.Trim();
            if (dni.Length == 13)
            {
                using (var db = new VentasDBContext())
                {
                    cliente = db.Clientes.Find(dni);
                    
                    CargarCliente(cliente);
                }
            }
        }
        void CargarCliente(Cliente cliente)
        {

            txt_nombre_cliente.Text = cliente == null ? "" : cliente.Nombre;
            txt_tel_cliente.Text = cliente == null ?  "" : cliente.Telefono;
        }
    }
}
