﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorFusion
{
    public partial class FuelConsumption : Form
    {
        public FuelConsumption()
        {
            InitializeComponent();
        }

        private void cmdEmployeeInfo_Click(object sender, EventArgs e)
        {
            ViewEmployees form = new ViewEmployees();
            form.Show();
            this.Close();
        }

        private void cmdShiftChange_Click(object sender, EventArgs e)
        {
            ShiftChange form = new ShiftChange();
            form.Show();
            this.Close();
        }

        private void cmdRidersInfo_Click(object sender, EventArgs e)
        {
            ViewRiders form = new ViewRiders();
            form.Show();
            this.Close();
        }

        private void cmdReorder_Click(object sender, EventArgs e)
        {
            Re_order_Requests form = new Re_order_Requests();
            form.Show();
            this.Close();
        }

        private void cmdRetailersPurchases_Click(object sender, EventArgs e)
        {
            RetailersPurchases form = new RetailersPurchases();
            form.Show();
            this.Close();
        }

        private void cmdSoldProducts_Click(object sender, EventArgs e)
        {
            Sales form = new Sales();
            form.Show();
            this.Close();
        }

        private void cmdEmployeesPerformance_Click(object sender, EventArgs e)
        {
            EmployeePerformance form = new EmployeePerformance();
            form.Show();
            this.Close();
        }

        private void cmdRidersPerformance_Click(object sender, EventArgs e)
        {
            RiderPerformance form = new RiderPerformance();
            form.Show();
            this.Close();
        }

        private void cmdSuppliersReport_Click(object sender, EventArgs e)
        {
            SuppliersReport form = new SuppliersReport();
            form.Show();
            this.Close();
        }
    }
}
