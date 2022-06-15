using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalDBApp
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        FormArea f4 = new FormArea();
        FormDoc f5 = new FormDoc();
        FormCovid f6 = new FormCovid();
        FormPCR f7 = new FormPCR();
        FormRTest f8 = new FormRTest();
        FormDocA f9 = new FormDocA();
        FormDocH f10 = new FormDocH();
        FormHRP f11 = new FormHRP();
        FormLRP f12 = new FormLRP();
        FormPatDoc f13 = new FormPatDoc();
        FormPatH f14 = new FormPatH();
        FormPCRhistory f15 = new FormPCRhistory();
        FormPCRpayments f16 = new FormPCRpayments();
        FormPatInHos f17 = new FormPatInHos();
        FormPatVShos f18 = new FormPatVShos();
        FormDelPat f19 = new FormDelPat();
        public Form1()
        {
            InitializeComponent();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void searchPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.Show();
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.Show();
        }

        private void covidTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f6.Show();
        }

        private void pCRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f7.Show();
        }

        private void rtestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f8.Show();
        }

        private void docAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f9.Show();
        }

        private void docHospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f10.Show();
        }

        private void hRPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f11.Show();
        }

        private void lRPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f12.Show();
        }

        private void patDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f13.Show();
        }

        private void patHospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f14.Show();
        }

        private void pCRHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f15.Show();
        }

        private void pCRPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f16.Show();
        }

        private void numOfPatientsInHospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f17.Show();
        }

        private void numOfPatientsVsHospitalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f18.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void patientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f19.Show();
        }
    }
}
