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
    public partial class VentanaReporteCliente : Form
    {
        public VentanaReporteCliente()
        {
            InitializeComponent();
        }

        private void VentanaReporteCliente_Load(object sender, EventArgs e)
        {
            ReporteCliente reporte = new ReporteCliente();
            ClienteCrystalReportViewer.ReportSource = reporte;
            ClienteCrystalReportViewer.RefreshReport();
        }
    }
}
