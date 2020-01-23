using System;
using MaterialSkin;
using MaterialSkin.Controls;
using Modelo.DTO;

namespace Vista.Alerta
{
    public partial class Alerta : MaterialForm
    {
        public Alerta(ProductoDTO producto)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            lbNombre.Text = producto.Nombre;
            lbId.Text = producto.ID;
            lbPrecio.Text = producto.Precio.ToString();
            lbStock.Text = producto.Stock.ToString();
            lbStockMin.Text = producto.StockMin.ToString();
            lbCategoria.Text = producto.Categoria;
        }
    }
}
