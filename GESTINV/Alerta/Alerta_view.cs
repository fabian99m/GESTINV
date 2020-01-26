using System;
using MaterialSkin;
using MaterialSkin.Controls;
using Modelo.DTO;

namespace Vista.Alerta
{
    public partial class Alerta : MaterialForm
    {
        public Alerta(Producto producto)
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                 (Primary)6732650, (Primary)1793568,
                (Primary)6732650, (Accent)6732650,
                 TextShade.BLACK
             ); ;

            lbNombre.Text = producto.Nombre;
            lbId.Text = producto.ID;
            lbPrecio.Text = producto.Precio.ToString();
            lbStock.Text = producto.Stock.ToString();
            lbStockMin.Text = producto.StockMin.ToString();
            lbCategoria.Text = producto.Categoria;
        }
    }
}
