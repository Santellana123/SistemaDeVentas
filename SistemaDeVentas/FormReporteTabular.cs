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
    public partial class FormReporteTabular : Form
    {
        public FormReporteTabular()
        {
            InitializeComponent();
        }
        public FormReporteTabular(List<Venta> ventas)
        {
            InitializeComponent();
            dataGridView1.DataSource = ventas;
        }
    }
}
