using MasterDetail.DataAccess;
using MasterDetail.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace MasterDetail.Views.promps
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
            LoadCategorias();
        }
        void LoadCategorias()
        {
            using (var db = new VentasDBContext())
            {
                cb_categoria.DataSource = db.Categorias.ToList();
                cb_categoria.DisplayMember = "Nombre";
                cb_categoria.ValueMember = "Id";
            }
        }

        



        void ShowMsg(dynamic text,string type = "info")
        {
            var icon = MessageBoxIcon.Information;
            if (type == "error")
            {
                icon = MessageBoxIcon.Error;
            }
            MessageBox.Show($"{text}", "Guardar Producto", MessageBoxButtons.OK,icon);

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                using (var db = new VentasDBContext())
                {

                    var catText = txt_nuevaCategoria.Text.Trim();
                    var cat = new Categoria();
                    bool validCat = catText.Length > 2;
                    if (validCat)
                    {
                        cat.Nombre = catText;
                        
                        db.Categorias.Add(cat);
                        //ShowMsg($"cat id: {cat.Id}");
                    }
                    var prod = new Producto() 
                    {
                        Nombre = txt_nombre.Text,
                        Cantidad = (int)n_cantidad.Value,
                        Precio = n_precio.Value,
                        Impuesto = n_impuesto.Value,
                        CategoriaId = validCat ? cat.Id : (int) cb_categoria.SelectedValue,
                        Categoria = validCat ? cat : null
                    };
                    db.Productos.Add(prod);
                    db.SaveChanges();
                    ShowMsg("Producto Guardado con exito");
                    LoadCategorias();
                }


            }
            catch (Exception err)
            {
                ShowMsg($"Error:{err.Message}","error");
            }
        }

       
    }
}
