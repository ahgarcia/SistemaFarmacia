﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillEasy0._1._0
{
    public partial class VentanaReporteCompra : Form
    {
        public VentanaReporteCompra()
        {
            InitializeComponent();
        }

        private void VentanaReporteCompra_Load(object sender, EventArgs e)
        {
            ReporteCompra compra = new ReporteCompra();
            CompraCrystalReportViewer.ReportSource = compra;
            CompraCrystalReportViewer.RefreshReport();
        }
    }
}
