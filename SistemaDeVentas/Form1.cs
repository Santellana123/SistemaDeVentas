using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace SistemaDeVentas
{
    public partial class Form1 : Form
    {
        private List<Venta> ventas = new List<Venta>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text;
            decimal precioProducto = decimal.Parse(txtPrecioProducto.Text);
            int cantidad = int.Parse(txtCantidad.Text);

            Producto producto = new Producto { Nombre = nombreProducto, Precio = precioProducto };
            Venta venta = new Venta { Producto = producto, Cantidad = cantidad, Fecha = DateTime.Now };

            ventas.Add(venta);
            MessageBox.Show("Venta agregada con éxito.");
        }
        private void btnReporteTabular_Click(object sender, EventArgs e)
        {
            var formReporteTabular = new FormReporteTabular(ventas);
            formReporteTabular.Show();
        }

        private void btnReporteGrafico_Click(object sender, EventArgs e)
        {
            var formReporteGrafico = new FormReporteGrafico(ventas);
            formReporteGrafico.Show();
        }
    }
}
