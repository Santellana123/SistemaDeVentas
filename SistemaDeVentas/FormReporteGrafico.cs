using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas
{
    public partial class FormReporteGrafico : Form
    {
        private List<Venta> ventas;

        public FormReporteGrafico(List<Venta> ventas)
        {
            InitializeComponent();
            this.ventas = ventas; // Guardar la lista de ventas en un campo local
            GenerarGrafico();
        }

        private void GenerarGrafico()
        {
            var ventasPorFecha = ventas
                .GroupBy(v => v.Fecha.ToShortDateString())
                .Select(g => new { Fecha = g.Key, Total = g.Sum(v => v.Total) })
                .ToList();

            // Crear un objeto SeriesCollection para almacenar las series de datos
            SeriesCollection seriesCollection = new SeriesCollection();

            // Crear una serie para almacenar los puntos de datos
            LineSeries serie = new LineSeries
            {
                Title = "Ventas",
                Values = new ChartValues<decimal>()
            };

            // Agregar puntos de datos a la serie
            foreach (var venta in ventasPorFecha)
            {
                serie.Values.Add(venta.Total);
            }

            // Agregar la serie al SeriesCollection
            seriesCollection.Add(serie);

            // Configurar el gráfico
            cartesianChart1.Series = seriesCollection;
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Fecha",
                Labels = ventasPorFecha.Select(v => v.Fecha).ToList()
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Total Ventas",
                LabelFormatter = value => value.ToString("C")
            });
        }
    }
}
